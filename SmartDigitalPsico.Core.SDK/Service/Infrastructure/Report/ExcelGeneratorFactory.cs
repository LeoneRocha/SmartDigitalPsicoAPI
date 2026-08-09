using SmartDigitalPsico.Core.SDK.Domain.Interfaces.Infrastructure.Report;
using SmartDigitalPsico.Core.SDK.Domain.Report;

namespace SmartDigitalPsico.Core.SDK.Service.Infrastructure.Report
{
    /// <summary>
    /// Classe responsável por ExcelGeneratorFactory.
    /// </summary>
    public class ExcelGeneratorFactory : IExcelGeneratorFactory
    {
        public IExcelGenerator Create()
        {
            return new ExcelGeneratorOpenXmlAdapter();
        }
    }
}
