﻿using SmartDigitalPsico.Domain.Enuns;
using SmartDigitalPsico.Domain.Interfaces.Infrastructure.Report;
using SmartDigitalPsico.Domain.Report;

namespace SmartDigitalPsico.Service.Infrastructure.Report
{
    public class PdfReportAdapterFactory : IPdfReportAdapterFactory
    {
        public IPdfReportAdapter Create(EPdfReportComponentType ePdfReportComponentType)
        {
            switch (ePdfReportComponentType)
            {
                case EPdfReportComponentType.QuestPDF:
                    return new QuestPdfReportAdapter();
                case EPdfReportComponentType.PDFsharp:
                    return new PDFsharpMigraDocReportAdapter();
                default:
                    throw new ArgumentException("Invalid Pdf Component Type");
            }
        }
    }
}