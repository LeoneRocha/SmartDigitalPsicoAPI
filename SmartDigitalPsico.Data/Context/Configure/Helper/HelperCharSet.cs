using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SmartDigitalPsico.Domain.Enuns;

namespace SmartDigitalPsico.Data.Context.Configure.Helper
{
    /// <summary>
    /// Classe responsável por HelperCharSet.
    /// Responsabilidade: configuração de startup/DI da aplicação.
    /// Relação: integra as camadas Domain/Data/Service/WebAPI do SmartDigitalPsico.
    /// </summary>
    public static class HelperCharSet
    {
        public static void AddCharSet<T>(EntityTypeBuilder<T> builder, ETypeDataBase eTypeDataBase) where T : class
        {
            if (eTypeDataBase == ETypeDataBase.Mysql)
                builder.HasCharSet("latin1");
        }
    }
}
