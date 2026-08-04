using System.Reflection;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore.Metadata.Conventions;
using Microsoft.EntityFrameworkCore.Migrations;
using SmartDigitalPsico.Data.Context.Configure.Entity;
using SmartDigitalPsico.Domain.Enuns;

namespace SmartDigitalPsico.Data.Test.Infrastructure;

[TestFixture]
public class DataInfrastructureCoverageTests
{
    [Test]
    public void Configure_AllEntityConfigurations_AppliesToModelBuilder()
    {
        // Cenário: todas as configurações de entidades disponíveis.
        // Objetivo: garantir que cada mapeamento possa compor um modelo EF Core.
        var configurationTypes = typeof(RoleGroupConfiguration).Assembly
            .GetTypes()
            .Where(type => !type.IsAbstract && type.GetInterfaces()
                .Any(@interface => @interface.IsGenericType
                    && @interface.GetGenericTypeDefinition() == typeof(IEntityTypeConfiguration<>)))
            .ToArray();

        // Act
        foreach (var configurationType in configurationTypes)
        {
            var entityType = configurationType.GetInterfaces()
                .Single(@interface => @interface.IsGenericType
                    && @interface.GetGenericTypeDefinition() == typeof(IEntityTypeConfiguration<>))
                .GetGenericArguments()[0];
            var configuration = Activator.CreateInstance(configurationType, ETypeDataBase.Mysql)!;
            var builder = new ModelBuilder(new ConventionSet());
            var entityBuilder = typeof(ModelBuilder).GetMethod(nameof(ModelBuilder.Entity), Type.EmptyTypes)!
                .MakeGenericMethod(entityType)
                .Invoke(builder, null)!;

            configurationType.GetMethod(nameof(IEntityTypeConfiguration<object>.Configure))!
                .Invoke(configuration, [entityBuilder]);
        }

        // Assert
        configurationTypes.Should().NotBeEmpty();
    }

    [Test]
    public void UpAndDown_AllMigrations_AddOperations()
    {
        // Cenário: migrações MySql do assembly Data.
        // Objetivo: garantir que operações Up e Down sejam construídas sem conexão externa.
        var migrationTypes = typeof(RoleGroupConfiguration).Assembly
            .GetTypes()
            .Where(type => !type.IsAbstract && typeof(Migration).IsAssignableFrom(type))
            .ToArray();

        // Act
        foreach (var migrationType in migrationTypes)
        {
            var migration = (Migration)Activator.CreateInstance(migrationType)!;
            var up = new MigrationBuilder("Pomelo.EntityFrameworkCore.MySql");
            var down = new MigrationBuilder("Pomelo.EntityFrameworkCore.MySql");

            migration.GetType().GetMethod("Up", BindingFlags.Instance | BindingFlags.NonPublic)!
                .Invoke(migration, [up]);
            migration.GetType().GetMethod("Down", BindingFlags.Instance | BindingFlags.NonPublic)!
                .Invoke(migration, [down]);

            up.Operations.Should().NotBeNull();
            down.Operations.Should().NotBeNull();
        }

        // Assert
        migrationTypes.Should().NotBeEmpty();
    }
}
