using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SmartDigitalPsico.Domain.Enuns;

namespace SmartDigitalPsico.Data.Context.Configure
{
    public abstract class EntityBaseConfiguration<T> : IEntityTypeConfiguration<T> where T : class
    {
        protected EntityBaseConfiguration(ETypeDataBase eTypeDataBase)
        {
            ETypeDataBase = eTypeDataBase;
        }
        protected ETypeDataBase ETypeDataBase { get; private set; }

        public virtual void Configure(EntityTypeBuilder<T> builder)
        {
            throw new NotImplementedException();
        }
    }
}
