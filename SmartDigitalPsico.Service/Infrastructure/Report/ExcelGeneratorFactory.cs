using SmartDigitalPsico.Domain.Interfaces.Infrastructure.Report;
using SmartDigitalPsico.Domain.Report;

namespace SmartDigitalPsico.Service.Infrastructure.Report
{
    /// <summary>
    /// Classe responsável por ExcelGeneratorFactory.
    /// Responsabilidade: geração de relatórios.
    /// Relação: integra as camadas Domain/Data/Service/WebAPI do SmartDigitalPsico.
    /// </summary>
    public class ExcelGeneratorFactory : IExcelGeneratorFactory
    {
        /// <summary>
        /// Método Create: cria ou persiste um novo registro/recurso.
        /// </summary>
        public IExcelGenerator Create()
        {
            return new ExcelGeneratorOpenXmlAdapter();
        }
    }
}
