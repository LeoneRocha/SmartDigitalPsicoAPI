using SmartDigitalPsico.Domain.Enuns;

namespace SmartDigitalPsico.Domain.Interfaces.Infrastructure.Report
{
    public interface IPdfReportAdapterFactory
    {
        IPdfReportAdapter Create(EPdfReportComponentType ePdfReportComponentType);
    }
}