using System.ComponentModel;

namespace SmartDigitalPsico.Domain.DTO.Report.Entity
{
    /// <summary>
    /// Classe responsável por PatientAdditionalInformationReportDto.
    /// Responsabilidade: geração de relatórios.
    /// Relação: integra as camadas Domain/Data/Service/WebAPI do SmartDigitalPsico.
    /// </summary>
    public class PatientAdditionalInformationReportDto
    {
        [SmartDigitalPsico.Core.SDK.Domain.Helpers.Order(0)]
        [Description("Psychiatric")]
        public string FollowUp_Psychiatric { get; set; } = string.Empty;

        [SmartDigitalPsico.Core.SDK.Domain.Helpers.Order(1)]
        [Description("Neurological")]
        public string FollowUp_Neurological { get; set; } = string.Empty;
    }
}
