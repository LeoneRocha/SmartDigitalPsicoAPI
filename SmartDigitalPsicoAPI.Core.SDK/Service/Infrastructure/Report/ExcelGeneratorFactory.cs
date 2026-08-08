using SmartDigitalPsicoAPI.Core.SDK.Domain.Interfaces.Infrastructure.Report;
using SmartDigitalPsicoAPI.Core.SDK.Domain.Report;

namespace SmartDigitalPsicoAPI.Core.SDK.Service.Infrastructure.Report
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
