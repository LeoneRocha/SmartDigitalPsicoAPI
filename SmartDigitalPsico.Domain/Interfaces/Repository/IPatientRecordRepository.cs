﻿using SmartDigitalPsico.Domain.ModelEntity;

namespace SmartDigitalPsico.Domain.Interfaces.Repository
{
    public interface IPatientRecordRepository : IEntityBaseSimpleRepository<PatientRecord>
    {
        Task<List<PatientRecord>> FindAllByPatient(long patientId);
    }
}
