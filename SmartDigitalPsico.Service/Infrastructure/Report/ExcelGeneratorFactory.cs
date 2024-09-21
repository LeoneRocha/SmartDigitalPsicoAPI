using SmartDigitalPsico.Domain.Interfaces.Infrastructure.Report;
using SmartDigitalPsico.Domain.Report;

namespace SmartDigitalPsico.Service.Infrastructure.Report
{
    public class ExcelGeneratorFactory : IExcelGeneratorFactory
    {
        public IExcelGenerator Create()
        {
            return new ExcelGeneratorOpenXmlAdapter();
        }
    }
}
