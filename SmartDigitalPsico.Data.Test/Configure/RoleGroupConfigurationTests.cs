using Microsoft.EntityFrameworkCore;
using SmartDigitalPsico.Data.Context.Configure.Entity;
using SmartDigitalPsico.Data.Tests.Context;
using SmartDigitalPsico.Core.SDK.Domain.Enuns;

using SmartDigitalPsico.Domain.EntityModels;

using SmartDigitalPsico.Data.Repository;
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

        // Cenário: o contexto de testes é inicializado com ModelBuilder.
        // Objetivo: garantir que a criação do modelo não lança exceção.
        [Test]
        public void InitializeContext_ValidSetup_DoesNotThrow()
        {
            // Arrange
            try
            {
                // Act
                var context = new SmartDigitalPsicoDataContextTest();
                context.TestModelCreation(new ModelBuilder());
            }
            catch (Exception ex)
            {
                // Assert
                Assert.Fail(ex.Message);
            }
        }

        // Cenário: ModelBuilder válido obtido a partir do contexto de testes.
        // Objetivo: configurar a entidade RoleGroup sem lançar exceção.
        [Test]
        public void Configure_ValidModelBuilder_DoesNotThrow()
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
