using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SmartDigitalPsico.Domain.Enuns;

namespace SmartDigitalPsico.Data.Context.Configure
{
    /// <summary>
    /// Classe responsável por EntityBaseConfiguration.
    /// Responsabilidade: configuração de startup/DI da aplicação.
    /// Relação: integra as camadas Domain/Data/Service/WebAPI do SmartDigitalPsico.
    /// </summary>
    public abstract class EntityBaseConfiguration<T> : IEntityTypeConfiguration<T> where T : class
    {
        /// <summary>
        /// Método EntityBaseConfiguration: executa a operação EntityBaseConfiguration.
        /// </summary>
        protected EntityBaseConfiguration(ETypeDataBase eTypeDataBase)
        {
            ETypeDataBase = eTypeDataBase;
        }
        protected ETypeDataBase ETypeDataBase { get; private set; }

        /// <summary>
        /// Método Configure: configura estado ou dependencias.
        /// </summary>
        public virtual void Configure(EntityTypeBuilder<T> builder)
        {
            throw new NotImplementedException();
        }
    }
}
