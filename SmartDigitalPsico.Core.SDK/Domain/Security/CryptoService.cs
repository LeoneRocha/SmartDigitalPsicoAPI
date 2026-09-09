using Microsoft.Extensions.Configuration;
using SmartCoreHub.Core.SDK.Common.Attributes;
using SmartDigitalPsico.Core.SDK.Domain.Enuns;
using SmartDigitalPsico.Core.SDK.Domain.Interfaces.Security;
using SchCrypto = SmartCoreHub.Core.SDK.Domain.Security.Cryptography;
using SchEnums = SmartCoreHub.Core.SDK.Domain.Enums;
using SchSecurity = SmartCoreHub.Core.SDK.Domain.Interfaces.Security;

namespace SmartDigitalPsico.Core.SDK.Domain.Security;

/// <summary>
/// Casca CryptoService — herda SCH; bridge de <see cref="ICryptoAdapterFactory"/> SDP → SCH.
/// </summary>
[SdkWrappedSource(
    targetType: "SmartCoreHub.Core.SDK.Domain.Security.Cryptography.CryptoService",
    targetPackage: "SmartCoreHub.Core.SDK",
    description: "Casca/wrapper herdando CryptoService; factory SDP adaptada para enum SCH.")]
public class CryptoService : SchCrypto.CryptoService, ICryptoService
{
    public CryptoService(IConfiguration configuration, ICryptoAdapterFactory cryptoAdapterFactory)
        : base(configuration, new CryptoAdapterFactoryBridge(cryptoAdapterFactory))
    {
    }

    private sealed class CryptoAdapterFactoryBridge : SchSecurity.ICryptoAdapterFactory
    {
        private readonly ICryptoAdapterFactory _inner;

        public CryptoAdapterFactoryBridge(ICryptoAdapterFactory inner)
            => _inner = inner ?? throw new ArgumentNullException(nameof(inner));

        public SchSecurity.ICryptoAdpter Create(SchEnums.ECryptoServiceType cryptoServiceType, string key, string ivOrPublicKey)
            => _inner.Create((ECryptoServiceType)(int)cryptoServiceType, key, ivOrPublicKey);
    }
}
