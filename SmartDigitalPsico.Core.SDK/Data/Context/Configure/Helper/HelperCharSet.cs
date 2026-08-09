using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SmartDigitalPsico.Core.SDK.Domain.Enuns;

namespace SmartDigitalPsico.Core.SDK.Data.Context.Configure.Helper
{
    /// <summary>
    /// Helper genérico de charset Fluent API por tipo de banco.
    /// Usa anotação MySql:CharSet (sem dependência Pomelo no Core).
    /// </summary>
    public static class HelperCharSet
    {
        public static void AddCharSet<T>(EntityTypeBuilder<T> builder, ETypeDataBase eTypeDataBase) where T : class
        {
            if (eTypeDataBase == ETypeDataBase.Mysql)
                builder.HasAnnotation("MySql:CharSet", "latin1");
        }
    }
}
