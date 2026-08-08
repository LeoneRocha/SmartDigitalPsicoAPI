namespace SmartDigitalPsico.Domain.Report
{
    /// <summary>
    /// Shim Obsolete — implementação canônica em SmartDigitalPsico.Core.SDK.
    /// </summary>
    // Movido para SmartDigitalPsico.Core.SDK
    [Obsolete("Movido para SmartDigitalPsico.Core.SDK. Use o tipo correspondente no pacote SmartDigitalPsico.Core.SDK.", error: false, DiagnosticId = "SDP_CORE_SDK_HELPER")]
    public class ExcelGeneratorOpenXmlAdapter : SmartDigitalPsico.Core.SDK.Domain.Report.ExcelGeneratorOpenXmlAdapter
    {
        public static new DocumentFormat.OpenXml.Spreadsheet.Stylesheet GetStylesheet()
            => SmartDigitalPsico.Core.SDK.Domain.Report.ExcelGeneratorOpenXmlAdapter.GetStylesheet();
    }
}
