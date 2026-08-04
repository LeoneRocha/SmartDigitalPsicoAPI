using SmartDigitalPsico.Domain.Constants;
using SmartDigitalPsico.Domain.Enuns;

namespace SmartDigitalPsico.Domain.Test.Constants;

[TestFixture]
public class ConstantsTests
{
    // Cenário: Todos os provedores de banco e um valor desconhecido solicitam tipos de texto.
    // Objetivo: Retornar os tipos e limites próprios de cada banco.
    [TestCase(ETypeDataBase.MSsqlServer, "varchar(max)", int.MaxValue)]
    [TestCase(ETypeDataBase.Mysql, "text", 65535)]
    [TestCase(ETypeDataBase.Postgree, "varchar(max)", int.MaxValue)]
    [TestCase(ETypeDataBase.FireBase, "varchar(max)", int.MaxValue)]
    [TestCase((ETypeDataBase)99, "varchar(max)", int.MaxValue)]
    public void EntityTypeConfiguration_DatabaseType_ReturnsExpectedStorageDefinition(ETypeDataBase database, string textType, int maxLength)
    {
        // Arrange
        // Act
        var type = EntityTypeConfigurationConstants.GetTypeTextByTypeDataBase(database);
        var length = EntityTypeConfigurationConstants.GetMaxLengthByTypeDataBase(database);
        // Assert
        using (Assert.EnterMultipleScope())
        {
            type.Should().Be(textType);
            length.Should().Be(maxLength);
        }
    }

    // Cenário: Chaves conhecidas, desconhecidas e corpos antigos solicitam template rico.
    // Objetivo: Resolver templates e atualizar somente conteúdos desatualizados.
    [Test]
    public void EmailTemplateBody_TemplateKeyAndBody_ReturnsExpectedUpgrade()
    {
        // Arrange
        var key = EmailTemplateTagConstants.AppointmentScheduledSuccess;
        // Act
        var resolved = EmailTemplateBodyConstants.Resolve(key);
        var upgrade = EmailTemplateBodyConstants.TryGetRichBody(key, "short");
        var current = EmailTemplateBodyConstants.TryGetRichBody(key, resolved);
        // Assert
        using (Assert.EnterMultipleScope())
        {
            resolved.Should().NotBeNull().And.Contain("Consulta Confirmada");
            upgrade.Should().Be(resolved);
            current.Should().BeNull();
            EmailTemplateBodyConstants.Resolve("unknown").Should().BeNull();
            EmailTemplateBodyConstants.TryGetRichBody("", "body").Should().BeNull();
            EmailTemplateBodyConstants.TryGetRichBody("unknown", "body").Should().BeNull();
        }
    }

    // Cenário: cada chave de template registrada é solicitada.
    // Objetivo: resolver todos os corpos canônicos disponíveis.
    [Test]
    public void EmailTemplateBody_AllKnownKeys_ReturnsCanonicalBody()
    {
        // Arrange
        var keys = new[]
        {
            EmailTemplateTagConstants.LoginReleaseEmail,
            EmailTemplateTagConstants.AccountChangeSuccess,
            EmailTemplateTagConstants.AppointmentScheduledSuccess,
            EmailTemplateTagConstants.AppointmentRescheduled,
            EmailTemplateTagConstants.AppointmentCancelled,
            EmailTemplateTagConstants.MedicalUpdateEmail,
            EmailTemplateTagConstants.NotificationDispatch
        };

        // Act
        var bodies = keys.Select(EmailTemplateBodyConstants.Resolve).ToList();

        // Assert
        bodies.Should().OnlyContain(body => !string.IsNullOrWhiteSpace(body));
    }
}
