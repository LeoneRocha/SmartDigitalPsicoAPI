using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Localization;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using Microsoft.IdentityModel.Tokens;
using Microsoft.Net.Http.Headers;
using Microsoft.OpenApi.Models;
using Pomelo.EntityFrameworkCore.MySql.Infrastructure;
using SmartDigitalPsico.Data.Context;
using SmartDigitalPsico.Domain.API;
using SmartDigitalPsico.Domain.Enuns;
using SmartDigitalPsico.Domain.Helpers;
using SmartDigitalPsico.Domain.Hypermedia;
using SmartDigitalPsico.Domain.Interfaces;
using SmartDigitalPsico.Domain.Mapper;
using SmartDigitalPsico.Domain.Resiliency;
using SmartDigitalPsico.Domain.Security;
using SmartDigitalPsico.Domain.VO.Domains;
using SmartDigitalPsico.WebAPI.Helper;
using Swashbuckle.AspNetCore.Filters;
using System.Configuration;
using System.Text;

namespace SmartDigitalPsico.WebAPI.Configure
{
    public static class ApplicationBuilderConfigure
    {
        private static IConfiguration? _configuration;

        public static void ConfigureServices(IServiceCollection services, IConfiguration configuration, Serilog.Core.Logger _logger)
        {
            _configuration = configuration;

            var tokenConfigurations = new TokenConfiguration();

            addGetAppConfig(services, tokenConfigurations);

            //For In-Memory Caching
            addCaching(services);

            //Security API
            addSecurity(services, tokenConfigurations);

            //AcceptHeader 
            services.AddControllers();

            //CORS
            addCors(services);

            //AcceptHeader 
            addAcceptHeader(services);

            //HyperMediaFilterOptions
            HyperMediaConfigure.AddHyperMedia(services);

            //Documenacao
            addDoc(services);

            // Auto Mapper 
            services.AddAutoMapper(typeof(AutoMapperProfile));

            //ORM API 
            addORM(services, WebApiHelpers.getTypeDataBase(_configuration));

            //Dependency Injection
            DependenciesInjectionConfigure.AddDependenciesInjection(services);

            //Add log 
            addLog(services, _logger);

            //ResiliencePolicies
            addResiliencePolicies(services, _configuration);
            services.AddEndpointsApiExplorer();
        }

        private static void addResiliencePolicies(IServiceCollection services, IConfiguration _configuration)
        {
            // Bind the PolicyConfig section of appsettings.json to the PolicyConfig class
            var policyConfig = new ResiliencePolicyConfig();
            var configValue = ConfigurationAppSettingsHelper.GetIResiliencePolicyConfig(_configuration);
            new ConfigureFromConfigurationOptions<ResiliencePolicyConfig>(configValue)
             .Configure(policyConfig); 
            // Register the PolicyConfig instance as a singleton
            services.AddSingleton<IResiliencePolicyConfig>(policyConfig);
        }

        private static void addLog(IServiceCollection services, Serilog.Core.Logger _logger)
        {
            services.AddLogging();
            services.AddSingleton<Serilog.ILogger>(sp =>
            {
                return _logger;
            });
        }

        #region PRIVATE


        private static void addGetAppConfig(IServiceCollection services, TokenConfiguration tokenConfigurations)
        {
            services.Configure<CacheConfigurationVO>(ConfigurationAppSettingsHelper.GetCacheConfiguration(_configuration));
            services.Configure<AuthConfigurationVO>(ConfigurationAppSettingsHelper.GetAuthConfiguration(_configuration));

            new ConfigureFromConfigurationOptions<TokenConfiguration>(ConfigurationAppSettingsHelper.GetTokenConfigurations(_configuration))
                .Configure(tokenConfigurations);

            services.AddSingleton(tokenConfigurations);
        }

        private static void addCaching(IServiceCollection services)
        {
            services.AddMemoryCache();
        }

        #region Cors
        private static void addCors(IServiceCollection services)
        {
#pragma warning disable S5122 // Disabling Sonar warning for CORS
            services.AddCors(options => options.AddDefaultPolicy(builder =>
            {
                builder.AllowAnyOrigin()
                .AllowAnyMethod()
                .AllowAnyHeader()
                .WithExposedHeaders("Content-Disposition");
            }));
#pragma warning restore S5122

        }
        #endregion

        #region AcceptHeader
        private static void addAcceptHeader(IServiceCollection services)
        {
            //AcceptHeader
            services.AddMvc(options =>
            {
                options.RespectBrowserAcceptHeader = true;

                options.FormatterMappings.SetMediaTypeMappingForFormat("xml", MediaTypeHeaderValue.Parse("application/xml"));
                options.FormatterMappings.SetMediaTypeMappingForFormat("json", MediaTypeHeaderValue.Parse("application/json"));
            })
            .AddXmlSerializerFormatters();
        }
        #endregion

        #region CONTEXTO
        private static void addORM(IServiceCollection services, ETypeDataBase etypeDataBase)
        {
            var connection = string.Empty;

            switch (etypeDataBase)
            {
                case ETypeDataBase.Mysql:
                    connection = ConfigurationAppSettingsHelper.GetConnectionStringMySQL(_configuration);
                    services.AddDbContext<SmartDigitalPsicoDataContext>(optionsBuilder =>
                    optionsBuilder.UseMySql(connection, ServerVersion.AutoDetect(connection)
                    , optionsMySQL =>
                    {
                        optionsMySQL.MigrationsAssembly("SmartDigitalPsico.Data");
                        optionsMySQL.SchemaBehavior(MySqlSchemaBehavior.Ignore);
                    })
                    );
                    break;
                case ETypeDataBase.MSsqlServer:
                    connection = ConfigurationAppSettingsHelper.GetConnectionStringSQL(_configuration);
                    services.AddDbContext<SmartDigitalPsicoDataContext>(optionsBuilder => optionsBuilder.UseSqlServer(connection,
                        optionsSQL => optionsSQL.MigrationsAssembly("SmartDigitalPsico.Data")));
                    break;
                default:
                    break;
            }
            addLocalization(services);

        }

        private static void addLocalization(IServiceCollection services)
        {
            services.AddMvc()
                    .AddViewLocalization()
                    .AddDataAnnotationsLocalization();

            services.AddScoped<LanguageActionFilterAttribute>();

            services.Configure<RequestLocalizationOptions>(
                options =>
                {
                    var supportedCultures = CultureDateTimeHelper.TranslateCulture(CultureDateTimeHelper.GetCultures());

                    options.DefaultRequestCulture = new RequestCulture(culture: "pt-BR", uiCulture: "pt-BR");

                    options.SupportedCultures = supportedCultures;
                    options.SupportedUICultures = supportedCultures;
                });

        }
        #endregion

        #region SEGURANCA
        private static void addSecurity(IServiceCollection services, TokenConfiguration tokenConfigurations)
        {
            services.AddAuthentication(options =>
            {
                options.DefaultAuthenticateScheme = JwtBearerDefaults.AuthenticationScheme;
                options.DefaultChallengeScheme = JwtBearerDefaults.AuthenticationScheme;
            }).AddJwtBearer(options =>
            {
                options.TokenValidationParameters = new TokenValidationParameters
                {
                    ValidateIssuer = true,
                    ValidateAudience = true,
                    ValidateLifetime = true,
                    ValidateIssuerSigningKey = true,
                    ValidIssuer = tokenConfigurations.Issuer,
                    ValidAudience = tokenConfigurations.Audience,
                    IssuerSigningKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(tokenConfigurations.Secret))
                };
            });
            services.AddAuthorizationCore(auth =>
            {
                auth.AddPolicy("Bearer", policyBuilder =>
                {
                    policyBuilder.AddAuthenticationSchemes(JwtBearerDefaults.AuthenticationScheme)
                        .RequireAuthenticatedUser();
                });
            });
        }

        #endregion

        #region DOCUMENTACAO
        private static void addDoc(IServiceCollection services)
        {
            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new OpenApiInfo { Title = "SmartDigitalPsico.WebAPI", Version = "v1" });
                c.AddSecurityDefinition("oauth2", new OpenApiSecurityScheme
                {
                    Description = "Standard Authorization header using the Bearer scheme. Example: \"bearer {token}\"",
                    In = ParameterLocation.Header,
                    Name = "Authorization",
                    Type = SecuritySchemeType.ApiKey
                });
                c.OperationFilter<SecurityRequirementsOperationFilter>();
            });
        }
        #endregion

        #endregion PRIVATE
    }
}
