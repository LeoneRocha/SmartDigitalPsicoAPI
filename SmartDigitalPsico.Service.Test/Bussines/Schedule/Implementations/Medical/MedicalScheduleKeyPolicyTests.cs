using SmartDigitalPsico.Service;
using SmartDigitalPsico.Service;

namespace SmartDigitalPsico.Service.Test.Bussines.Schedule.Implementations.Medical;
    using Medical = global::SmartDigitalPsico.Domain.EntityModels.Medical;
                                
[TestFixture]
public class MedicalScheduleKeyPolicyTests
{
    // Cenário: Identificadores clínicos válidos precisam atravessar a política de chaves.
    // Objetivo: Gerar e recuperar as chaves opacas de médico e paciente.
    [Test]
    public void KeyPolicy_ValidIdentifiers_BuildsAndParsesKeys()
    {
        // Arrange
        var policy = new MedicalScheduleKeyPolicy();

        var owner = policy.BuildOwnerKey(18);
        var subject = policy.BuildSubjectKey(27);
        var hasOwner = policy.TryParseOwnerId(owner, out var ownerId);
        var hasSubject = policy.TryParseSubjectId(subject, out var subjectId);

        // Act

        // Assert
        using (Assert.EnterMultipleScope())
        {
            policy.TenantKey.Should().Be(MedicalScheduleKeys.TenantKey);
            hasOwner.Should().BeTrue();
            ownerId.Should().Be(18);
            hasSubject.Should().BeTrue();
            subjectId.Should().Be(27);
        }
    }

    // Cenário: Uma chave não segue o padrão clínico.
    // Objetivo: Não expor um identificador inválido.
    [Test]
    public void KeyPolicy_InvalidKey_ReturnsFalseAndZeroIdentifier()
    {
        // Arrange
        var policy = new MedicalScheduleKeyPolicy();

        var parsed = policy.TryParseOwnerId("invalid-key", out var identifier);

        // Act

        // Assert
        using (Assert.EnterMultipleScope())
        {
            parsed.Should().BeFalse();
            identifier.Should().Be(0);
        }
    }
}
