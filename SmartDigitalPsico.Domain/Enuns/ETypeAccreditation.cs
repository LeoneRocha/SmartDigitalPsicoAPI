using System.ComponentModel;

namespace SmartDigitalPsico.Domain.Enuns
{
    /// <summary>
    /// Enumeração responsável por ETypeAccreditation.
    /// Responsabilidade: valores enumerados do domínio.
    /// Relação: usado em entidades, DTOs e regras de negócio.
    /// </summary>
    public enum ETypeAccreditation
    {
        [Description("Conselho Regional de Medicina")]
        CRM = 0,
        [Description("Conselho Regional de Psicologia")]
        CRP = 1
    }
}
