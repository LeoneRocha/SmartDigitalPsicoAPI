using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Authorization;
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
using SmartDigitalPsico.Domain.Mapper;
using SmartDigitalPsico.Domain.Security;
using SmartDigitalPsico.Domain.VO.Domains;
using SmartDigitalPsico.WebAPI.Helper;
using Swashbuckle.AspNetCore.Filters;
using System.Text;

namespace SmartDigitalPsico.WebAPI.Configure
{
    public class ApplicationBuilderConfigure
    {
        private static IConfiguration? _configuration;

        public static void ConfigureServices(IServiceCollection services, IConfiguration configuration)
        {
            _configuration = configuration;

            var tokenConfigurations = new TokenConfiguration();
            //
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

            services.AddEndpointsApiExplorer();
        }

        #region PRIVATE


        private static void addGetAppConfig(IServiceCollection services, TokenConfiguration tokenConfigurations)
        {

            services.Configure<CacheConfigurationVO>(_configuration.GetSection("CacheConfiguration"));

            services.Configure<AuthConfigurationVO>(_configuration.GetSection("AuthConfiguration"));


            new ConfigureFromConfigurationOptions<TokenConfiguration>(_configuration.GetSection("TokenConfigurations"))
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
            services.AddCors(options => options.AddDefaultPolicy(builder =>
            {
                builder.AllowAnyOrigin()
                .AllowAnyMethod()
                .AllowAnyHeader()
                .WithExposedHeaders("Content-Disposition");
            }));
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
                    connection = _configuration.GetConnectionString("SmartDigitalPsicoDBConnectionMySQL");
                    services.AddDbContext<SmartDigitalPsicoDataContext>(optionsBuilder => 
                    optionsBuilder.UseMySql(connection, ServerVersion.AutoDetect(connection)
                    , optionsMySQL =>
                    {
                        optionsMySQL.MigrationsAssembly("SmartDigitalPsico.Data");
                        optionsMySQL.SchemaBehavior(MySqlSchemaBehavior.Ignore);  

                        //optionsMySQL.CharSetBehavior(CharSetBehavior.NeverAppend);
                        //optionsMySQL.OldCompatibilityMode(); 
                    })                     
                    );
                    break;
                case ETypeDataBase.MSsqlServer:
                    connection = _configuration.GetConnectionString("SmartDigitalPsicoDBConnectionSQLServer");
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

            services.AddScoped<LanguageActionFilter>();

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
            })
        .AddJwtBearer(options =>
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

            services.AddAuthorization(auth =>
            {
                auth.AddPolicy("Bearer", new AuthorizationPolicyBuilder()
                    .AddAuthenticationSchemes(JwtBearerDefaults.AuthenticationScheme)
                    .RequireAuthenticatedUser().Build());
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
