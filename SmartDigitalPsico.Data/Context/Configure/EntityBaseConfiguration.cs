using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SmartDigitalPsico.Core.SDK.Domain.Enuns;

namespace SmartDigitalPsico.Data.Context.Configure
{
    /// <summary>
    /// Shim Obsolete — implementação canônica em SmartDigitalPsico.Core.SDK.
    /// </summary>
    // Movido para SmartDigitalPsico.Core.SDK — implementação canônica no pacote Core.
    [Obsolete("Movido para SmartDigitalPsico.Core.SDK. Use o tipo correspondente no pacote SmartDigitalPsico.Core.SDK.", error: false, DiagnosticId = "SDP_CORE_SDK_REPO")]
    public abstract class EntityBaseConfiguration<T> : SmartDigitalPsico.Core.SDK.Data.Context.Configure.EntityBaseConfiguration<T>
        where T : class
    {
        protected EntityBaseConfiguration(ETypeDataBase eTypeDataBase) : base(eTypeDataBase)
        {
        }

        public override void Configure(EntityTypeBuilder<T> builder)
            => base.Configure(builder);
    }
}
