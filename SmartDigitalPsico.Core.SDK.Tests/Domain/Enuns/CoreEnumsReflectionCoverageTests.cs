using System.Reflection;

namespace SmartDigitalPsico.Core.SDK.Tests.Domain.Enuns;

[TestFixture]
public class CoreEnumsReflectionCoverageTests
{
    private static readonly Assembly CoreAssembly = Assembly.Load("SmartDigitalPsico.Core.SDK");

    private static IEnumerable<TestCaseData> PublicEnums()
    {
        foreach (var type in CoreAssembly.GetExportedTypes()
                     .Where(type => type.IsEnum && type.Namespace == "SmartDigitalPsico.Core.SDK.Domain.Enuns")
                     .OrderBy(type => type.FullName))
        {
            yield return new TestCaseData(type).SetName($"Enum_{type.FullName}");
        }
    }

    // Cenário: enums públicos do Core.SDK.Domain.Enuns são convertíveis.
    // Objetivo: garantir membros válidos após a consolidação de enums genéricos no Core.
    [TestCaseSource(nameof(PublicEnums))]
    public void Values_PublicCoreEnums_ContainConvertibleMembers(Type enumType)
    {
        // Arrange
        var values = Enum.GetValues(enumType);

        // Act
        var converted = values.Cast<object>()
            .Select(value => Enum.ToObject(enumType, Convert.ToInt64(value)))
            .ToList();

        // Assert
        values.Length.Should().BeGreaterThan(0);
        for (var index = 0; index < values.Length; index++)
        {
            converted[index].Should().Be(values.GetValue(index));
        }
    }
}
