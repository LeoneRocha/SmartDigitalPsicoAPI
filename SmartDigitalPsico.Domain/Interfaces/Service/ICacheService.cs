using System;

namespace SmartDigitalPsico.Domain.Interfaces.Service
{
    [Obsolete("Movido para SmartDigitalPsico.Core.SDK. Use o tipo correspondente no pacote SmartDigitalPsico.Core.SDK.", error: false, DiagnosticId = "SDP_CORE_SDK_HELPER")]
    public interface ICacheService : SmartDigitalPsico.Core.SDK.Domain.Interfaces.Service.ICacheService
    {
    }
}
