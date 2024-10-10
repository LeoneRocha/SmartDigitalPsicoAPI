using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.IdentityModel.Tokens;
using SmartDigitalPsico.Domain.DTO.Security;
using System.Text;

namespace SmartDigitalPsico.WebAPI.Configure.Services
{
    public static class ApplicationConfigureSecurity
    {
        public static void Configure(IServiceCollection services, TokenConfigurationDto tokenConfigurations)
        {
            addSecurity(services, tokenConfigurations);
        }
        private static void addSecurity(IServiceCollection services, TokenConfigurationDto tokenConfigurations)
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
    }
}