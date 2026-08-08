using SmartDigitalPsico.Domain.Helpers;
using SmartDigitalPsicoAPI.Core.SDK.Domain.Helpers;
using System.ComponentModel;

namespace SmartDigitalPsico.Domain.DTO.Report.Enitty
{
    /// <summary>
    /// Classe responsável por PatientAdditionalInformationReportDto.
    /// Responsabilidade: geração de relatórios.
    /// Relação: integra as camadas Domain/Data/Service/WebAPI do SmartDigitalPsico.
    /// </summary>
    public class PatientAdditionalInformationReportDto
    {
        [SmartDigitalPsicoAPI.Core.SDK.Domain.Helpers.Order(0)]
        [Description("Psychiatric")]
        public string FollowUp_Psychiatric { get; set; } = string.Empty;

        [SmartDigitalPsicoAPI.Core.SDK.Domain.Helpers.Order(1)]
        [Description("Neurological")]
        public string FollowUp_Neurological { get; set; } = string.Empty;
    }
}
