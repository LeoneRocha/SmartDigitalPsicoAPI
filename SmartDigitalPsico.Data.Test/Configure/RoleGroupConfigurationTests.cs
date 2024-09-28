using Microsoft.EntityFrameworkCore;
using SmartDigitalPsico.Data.Context.Configure.Entity;
using SmartDigitalPsico.Data.Tests.Context;
using SmartDigitalPsico.Domain.Enuns;
using SmartDigitalPsico.Domain.ModelEntity;

namespace SmartDigitalPsico.Data.Tests.Configure
{
    [TestFixture]
    public class RoleGroupConfigurationTests
    {
        private RoleGroupConfiguration _roleGroupConfiguration;
        private ModelBuilder? _modelBuilder;

        [SetUp]
        public void Setup()
        {
            _roleGroupConfiguration = new RoleGroupConfiguration(ETypeDataBase.Mysql);
        }

        [Test]
        public void Should_Initialize_Context()
        {
            try
            {
                var context = new SmartDigitalPsicoDataContextTest();
                context.TestModelCreation(new ModelBuilder());
            }
            catch (Exception ex)
            {
                Assert.Fail(ex.Message);
            }
        }

        [Test]
        public void Configure_SuccessScenario()
        {
            // Arrange
            using (var context = new SmartDigitalPsicoDataContextTest())
            {
                context.TestModelCreation(new ModelBuilder());
                // Act
                _modelBuilder = context.ModelBuilder;

                // Assert
                if (_modelBuilder != null)
                {
                    Assert.DoesNotThrow(() => _roleGroupConfiguration.Configure(_modelBuilder.Entity<RoleGroup>()));
                }
                else
                {
                    Assert.Fail("ModelBuilder is null");
                }
            }
        }
    }
}
