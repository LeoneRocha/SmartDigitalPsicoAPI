﻿using SmartDigitalPsico.Domain.ModelEntity;

namespace SmartDigitalPsico.Domain.Interfaces.Repository
{
    public interface IPatientFileRepository : IEntityBaseRepository<PatientFile>
    {
        Task<List<PatientFile>> FindAllByPatient(long patientId);
    }
}
