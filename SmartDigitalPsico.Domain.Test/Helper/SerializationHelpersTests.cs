using System.ComponentModel;
using System.Text.Json;
using SmartDigitalPsico.Domain.Helpers;
using SmartDigitalPsicoAPI.Core.SDK.Domain.Helpers;

namespace SmartDigitalPsico.Domain.Test.Helper;

[TestFixture]
public class SerializationHelpersTests
{
    private enum DescribedEnum
    {
        [System.ComponentModel.Description("Human value")] Value,
        Plain
    }

    private sealed class SerializableModel
    {
        public string Keep { get; set; } = "keep";
        public string Ignore { get; set; } = "ignore";
    }

    // Cenário: Um enum é serializado por descrição e desserializado por descrição ou nome.
    // Objetivo: Converter todas as representações suportadas e rejeitar valor desconhecido.
    [Test]
    public void EnumDescriptionConverter_DescriptionsAndNames_ConvertsExpectedValues()
    {
        // Arrange
        var options = new JsonSerializerOptions();
        options.Converters.Add(new SmartDigitalPsicoAPI.Core.SDK.Domain.Helpers.EnumDescriptionConverter<DescribedEnum>());
        // Act
        var serializedDescription = JsonSerializer.Serialize(DescribedEnum.Value, options);
        var serializedName = JsonSerializer.Serialize(DescribedEnum.Plain, options);
        var byDescription = JsonSerializer.Deserialize<DescribedEnum>("\"Human value\"", options);
        var byName = JsonSerializer.Deserialize<DescribedEnum>("\"Plain\"", options);
        // Assert
        using (Assert.EnterMultipleScope())
        {
            serializedDescription.Should().Be("\"Human value\"");
            serializedName.Should().Be("\"Plain\"");
            byDescription.Should().Be(DescribedEnum.Value);
            byName.Should().Be(DescribedEnum.Plain);
            ((Action)(() => JsonSerializer.Deserialize<DescribedEnum>("\"unknown\"", options))).Should().Throw<ArgumentException>();
        }
    }

    // Cenário: Um resolvedor recebe propriedade que deve ser ignorada.
    // Objetivo: Excluir somente a propriedade configurada.
    [Test]
    public void IgnorableSerializerContractResolver_IgnoredProperty_ExcludesItFromJson()
    {
        // Arrange
        var resolver = new SmartDigitalPsicoAPI.Core.SDK.Domain.Helpers.IgnorableSerializerContractResolver(["Ignore"]);
        // Act
        var json = Newtonsoft.Json.JsonConvert.SerializeObject(new SerializableModel(), new Newtonsoft.Json.JsonSerializerSettings { ContractResolver = resolver });
        // Assert
        using (Assert.EnterMultipleScope())
        {
            json.Should().Contain("Keep");
            json.Should().NotContain("Ignore");
        }
    }
}
