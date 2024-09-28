using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SmartDigitalPsico.Domain.Enuns;

namespace SmartDigitalPsico.Data.Context.Configure
{
    public static class HelperCharSet
    {
        public static void AddCharSet<T>(EntityTypeBuilder<T> builder, ETypeDataBase eTypeDataBase) where T : class
        {
            if (eTypeDataBase == ETypeDataBase.Mysql)
                builder.HasCharSet("latin1");
        }
    }
}
