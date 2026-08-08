namespace SmartDigitalPsico.Domain.VO
{
    /// <summary>
    /// Classe responsável por DataNotificationTemplateVO.
    /// Responsabilidade: value object / objeto de valor de resposta.
    /// Relação: retornado pelos Services para Controllers.
    /// </summary>
        // Movido para SmartDigitalPsicoAPI.Core.SDK.
    [Obsolete("Movido para SmartDigitalPsicoAPI.Core.SDK. Use o tipo correspondente no pacote SmartDigitalPsicoAPI.Core.SDK.", error: false, DiagnosticId = "SDP_CORE_SDK_HELPER")]
    public class DataNotificationTemplateVO
    {
        public string Subject { get; set; } = string.Empty;
        public string Body { get; set; } = string.Empty;
        public List<string> ToEmails { get; set; }
        public List<string> ToPhoneNumbers { get; set; }

        /// <summary>
        /// Método DataNotificationTemplateVO: executa a operação DataNotificationTemplateVO.
        /// </summary>
        public DataNotificationTemplateVO(string subject, string body)
        {
            Subject = subject;
            Body = body;            
            ToEmails = new List<string>();
            ToPhoneNumbers = new List<string>();
        }

        /// <summary>
        /// Método DataNotificationTemplateVO: executa a operação DataNotificationTemplateVO.
        /// </summary>
        public DataNotificationTemplateVO( )
        {
            ToEmails = new List<string>();
            ToPhoneNumbers = new List<string>();
        }
    }

}
