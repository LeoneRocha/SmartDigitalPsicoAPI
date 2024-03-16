using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using SmartDigitalPsico.Data.Configure;
using SmartDigitalPsico.Domain.Enuns;

namespace SmartDigitalPsico.Data.Context
{
    public sealed class SmartDigitalPsicoDataContext : EntityDataContext
    {
        public SmartDigitalPsicoDataContext(DbContextOptions<SmartDigitalPsicoDataContext> options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            var configuration = new ConfigurationBuilder().AddJsonFile("appsettings.json").Build();
            var typeDB = configuration.GetValue<ETypeDataBase>("DataBaseConfigurations:TypeDataBase");

            ConfigureProprietiesEntity.Configure(modelBuilder);

            ConfigureDataMock.GenerateMock(modelBuilder, typeDB);

            ConfigureRelationsHelper.Configure(modelBuilder);

            ConfigureDefaultValues.Configure(modelBuilder);

            base.OnModelCreating(modelBuilder);
        }
    }
}