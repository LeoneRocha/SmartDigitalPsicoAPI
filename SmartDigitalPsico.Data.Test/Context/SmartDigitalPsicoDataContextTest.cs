using Microsoft.EntityFrameworkCore;
using SmartDigitalPsico.Data.Context;

namespace SmartDigitalPsico.Data.Tests.Context
{  
    public class SmartDigitalPsicoDataContextTest : SmartDigitalPsicoDataContext
    {
        public ModelBuilder? ModelBuilder { get; private set; }

        public SmartDigitalPsicoDataContextTest()
        {
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            this.ModelBuilder = modelBuilder;
        }
        public void TestModelCreation(ModelBuilder model)
        {
            OnModelCreating(model);
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseInMemoryDatabase(Guid.NewGuid().ToString());
        }
    } 
}
