using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;

namespace SmartDigitalPsico.Data.Test.Migrations;

[TestFixture]
public sealed class MigrationModelCoverageTests
{
    // Cenário: cada migração registrada no assembly Data possui um modelo de destino gerado.
    // Objetivo: executar literalmente o BuildTargetModel de todos os artefatos de migração.
    [Test]
    public void TargetModel_AllMigrations_BuildsEveryGeneratedModel()
    {
        // Arrange
        var migrationTypes = GetDataAssemblyTypes()
            .Where(type => !type.IsAbstract && typeof(Migration).IsAssignableFrom(type))
            .ToArray();

        // Act
        var models = migrationTypes
            .Select(type => ((Migration)Activator.CreateInstance(type, nonPublic: true)!).TargetModel)
            .ToArray();

        // Assert
        using (Assert.EnterMultipleScope())
        {
            migrationTypes.Should().NotBeEmpty();
            models.Should().OnlyContain(model => model.GetEntityTypes().Any());
        }
    }

    // Cenário: o snapshot MySQL mantém o modelo completo da última migração.
    // Objetivo: executar BuildModel e cobrir o artefato ModelSnapshot gerado pelo EF Core.
    [Test]
    public void ModelSnapshot_DataAssembly_BuildsGeneratedModel()
    {
        // Arrange
        var snapshotTypes = GetDataAssemblyTypes()
            .Where(type => !type.IsAbstract && typeof(ModelSnapshot).IsAssignableFrom(type))
            .ToArray();

        // Act
        var models = snapshotTypes
            .Select(type => ((ModelSnapshot)Activator.CreateInstance(type, nonPublic: true)!).Model)
            .ToArray();

        // Assert
        using (Assert.EnterMultipleScope())
        {
            snapshotTypes.Should().ContainSingle();
            models.Should().OnlyContain(model => model.GetEntityTypes().Any());
        }
    }

    private static Type[] GetDataAssemblyTypes() =>
        typeof(SmartDigitalPsico.Data.Context.SmartDigitalPsicoDataContextMySql)
            .Assembly
            .GetTypes();
}
