using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace SmartDigitalPsico.Data.Context.Configure
{
    public static class HelperCharSet
    {
        public static void AddCharSet<T>(EntityTypeBuilder<T> builder) where T : class
        {
            builder.HasCharSet("latin1");
        }
    }
}
