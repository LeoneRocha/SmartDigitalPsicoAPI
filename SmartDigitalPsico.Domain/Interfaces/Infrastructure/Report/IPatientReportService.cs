﻿using SmartDigitalPsico.Domain.Hypermedia.Utils;
using SmartDigitalPsico.Domain.VO.Report.Patient;

namespace SmartDigitalPsico.Domain.Interfaces.Infrastructure.Report
{
    public interface IPatientReportService
    {
        void SetUserId(long id);
        Task<ServiceResponse<PatientDetailReportVO>> GetPatientDetailsByIdAsync(long id);
    }
}