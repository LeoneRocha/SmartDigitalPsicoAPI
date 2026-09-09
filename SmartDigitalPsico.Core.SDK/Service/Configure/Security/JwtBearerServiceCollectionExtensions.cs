using SmartCoreHub.Core.SDK.Common.Attributes;
using System.Text;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.IdentityModel.Tokens;
using SmartDigitalPsico.Core.SDK.Domain.DTO.Security;

namespace SmartDigitalPsico.Core.SDK.Service.Configure.Security;

/// <summary>
/// DI JWT — SDP registra esquema JwtBearer completo (pacote no host).
/// SCH <c>AddCoreJwtBearer</c> só TokenConfiguration + policy (sem JwtBearer package no SDK).
/// </summary>
[SdkWrappedSource(
    targetType: "SmartCoreHub.Core.SDK.Service.DependenciesCollection.Extensions.CoreServiceCollectionExtensions.AddCoreJwtBearer",
    targetPackage: "SmartCoreHub.Core.SDK",
    description: "AddCoreJwtBearer SDP com AddAuthentication/AddJwtBearer; diverge do stub SCH (host-side).")]
public static class JwtBearerServiceCollectionExtensions
{
    public static IServiceCollection AddCoreJwtBearer(
        this IServiceCollection services,
        TokenConfigurationDto tokenConfigurations)
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

        return services;
    }
}
