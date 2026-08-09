using SmartDigitalPsico.Core.SDK.Domain.AppException;

namespace SmartDigitalPsico.Domain.Test.AppException;

[TestFixture]
public class AppExceptionTests
{
    // Cenário: exceção sem Source e sem InnerException.
    // Objetivo: cobrir ramos null-coalescing de ExceptionHandler.
    [Test]
    public void ExceptionHandler_ExceptionWithoutSourceOrInner_ReturnsFallbackValues()
    {
        // Arrange
        var exception = new InvalidOperationException("only-outer") { Source = null };

        // Act
        var errors = ExceptionHandler.GerateListErrorResponse(exception);
        var message = ExceptionHandler.GetMessage(exception);

        // Assert
        using (Assert.EnterMultipleScope())
        {
            errors[0].Name.Should().Be("SmartDigitalPsico");
            message.Should().Be(" only-outer - ");
        }
    }

    // Cenário: Uma exceção possui fonte, código e exceção interna.
    // Objetivo: Converter a exceção em resposta e mensagem detalhada.
    [Test]
    public void ExceptionHandler_ExceptionWithDetails_ReturnsMappedResponse()
    {
        // Arrange
        var exception = new InvalidOperationException("outer", new Exception("inner")) { Source = "unit-test" };
        // Act
        var errors = ExceptionHandler.GerateListErrorResponse(exception);
        var message = ExceptionHandler.GetMessage(exception);
        // Assert
        using (Assert.EnterMultipleScope())
        {
            errors.Should().ContainSingle();
            errors[0].Name.Should().Be("unit-test");
            errors[0].Message.Should().Be("outer");
            message.Should().Be(" outer - inner");
        }
    }

    // Cenário: Exceções de aviso são construídas com diferentes sobrecargas.
    // Objetivo: Preservar mensagem e exceção interna.
    [Test]
    public void AppWarningException_Constructors_ReturnExpectedExceptionState()
    {
        // Arrange
        var inner = new Exception("inner");
        // Act
        var empty = new AppWarningException();
        var message = new AppWarningException("warning");
        var detailed = new AppWarningException("warning", inner);
        // Assert
        using (Assert.EnterMultipleScope())
        {
            empty.Message.Should().NotBeNull();
            message.Message.Should().Be("warning");
            detailed.InnerException.Should().BeSameAs(inner);
        }
    }
}
