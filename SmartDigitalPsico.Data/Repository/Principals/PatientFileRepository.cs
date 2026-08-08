using Microsoft.EntityFrameworkCore;
using SmartDigitalPsico.Core.SDK.Data.Context.Interface;
using SmartDigitalPsico.Domain.ModelEntity;

using SmartDigitalPsico.Domain.Interfaces.Patient;
namespace SmartDigitalPsico.Data.Repository.Principals
{
    /// <summary>
    /// Classe responsável por PatientFileRepository.
    /// Responsabilidade: repositório de persistência.
    /// Relação: implementa interfaces do Domain e usa o EF Core Context.
    /// </summary>
    public class PatientFileRepository : SmartDigitalPsico.Core.SDK.Data.Repository.Generic.GenericRepositoryEntityBase<PatientFile>, IPatientFileRepository
    {
        /// <summary>
        /// Método PatientFileRepository: executa a operação PatientFileRepository.
        /// </summary>
        public PatientFileRepository(IEntityDataContext context) : base(context) { }

        /// <summary>
        /// Método FindByID: consulta e retorna dados.
        /// </summary>
        public async override Task<PatientFile> FindByID(long id)
        {
#pragma warning disable CS8602
            return await _dataset 
                .Include(e => e.Patient)
                .ThenInclude(e => e.Medical)
                .ThenInclude(e => e.User)
                .Include(e => e.CreatedUser)
                .FirstAsync(p => p.Id.Equals(id));
#pragma warning restore CS8602
        }

        /// <summary>
        /// Método FindAllByPatient: consulta e retorna dados.
        /// </summary>
        public async Task<List<PatientFile>> FindAllByPatient(long patientId)
        {
            return await _dataset
                .AsNoTracking()
                .Where(e => e.PatientId == patientId)
                .Include(e => e.CreatedUser)//validation required
                .Include(e => e.Patient)
                .ToListAsync();
        }
    }
} 
