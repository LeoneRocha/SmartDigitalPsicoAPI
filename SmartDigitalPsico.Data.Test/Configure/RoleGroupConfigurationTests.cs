using Microsoft.EntityFrameworkCore;
using SmartDigitalPsico.Data.ConfigureFluentAPI.Entity;
using SmartDigitalPsico.Data.Test.Context;
using SmartDigitalPsico.Domain.ModelEntity;

namespace SmartDigitalPsico.Data.Test.Configure
{
    [TestFixture]
    public class RoleGroupConfigurationTests
    {
        private RoleGroupConfiguration _roleGroupConfiguration;
        private ModelBuilder? _modelBuilder;

        [SetUp]
        public void Setup()
        {
            _roleGroupConfiguration = new RoleGroupConfiguration();
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
