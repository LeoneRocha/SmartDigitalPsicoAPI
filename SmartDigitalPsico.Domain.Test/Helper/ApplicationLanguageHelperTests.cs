
using SmartDigitalPsico.Domain.Helpers;
using SmartDigitalPsico.Core.SDK.Domain.Helpers;

namespace SmartDigitalPsico.Domain.Test.Helper;

[TestFixture]
public class ApplicationLanguageHelperTests
{
    // Cenário: Uma mensagem possui tokens para substituição.
    // Objetivo: Retornar a chave com mensagem formatada.
    [Test]
    public void ReplaceTokensInMessage_MessageWithTokens_ReturnsFormattedMessage()
    {
        // Arrange
        var message = "IntervalInMinutes_Validator_InclusiveBetween_Key|{0} must be between {1} and {2}.|Interval In Minutes|15|1440";
        // Act
        var result = ApplicationLanguageHelper.ReplaceTokensInMessage(message);
        // Assert
        result.Should().Be("IntervalInMinutes_Validator_InclusiveBetween_Key|Interval In Minutes must be between 15 and 1440.");
    }

    // Cenário: Uma mensagem não possui tokens.
    // Objetivo: Preservar a mensagem original.
    [Test]
    public void ReplaceTokensInMessage_MessageWithoutTokens_ReturnsOriginalMessage()
    {
        // Arrange
        const string message = "Simple_Message_Key|This is a simple message.";
        // Act
        var result = ApplicationLanguageHelper.ReplaceTokensInMessage(message);
        // Assert
        result.Should().Be(message);
    }

    // Cenário: Um template contém todos os tokens fornecidos.
    // Objetivo: Substituir cada token correspondente.
    [Test]
    public void ReplaceTokens_TemplateWithValues_ReturnsFormattedTemplate()
    {
        // Arrange
        const string template = "{0} must be between {1} and {2}.";
        // Act
        var result = ApplicationLanguageHelper.ReplaceTokens(template, "Field", "MinValue", "MaxValue");
        // Assert
        result.Should().Be("Field must be between MinValue and MaxValue.");
    }

    // Cenário: Um template não recebe valores.
    // Objetivo: Preservar o template.
    [Test]
    public void ReplaceTokens_TemplateWithoutValues_ReturnsOriginalTemplate()
    {
        // Arrange
        const string template = "This is a template.";
        // Act
        var result = ApplicationLanguageHelper.ReplaceTokens(template);
        // Assert
        result.Should().Be(template);
    }
}
