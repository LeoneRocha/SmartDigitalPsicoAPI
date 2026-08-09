using Microsoft.EntityFrameworkCore;
using SmartDigitalPsico.Core.SDK.Data.Context.Interface;

using SmartDigitalPsico.Domain.Interfaces.Medical;
using SmartDigitalPsico.Domain.EntityModels;

namespace SmartDigitalPsico.Data.Repository.Principals
{
    /// <summary>
    /// Classe responsável por MedicalFileRepository.
    /// Responsabilidade: repositório de persistência.
    /// Relação: implementa interfaces do Domain e usa o EF Core Context.
    /// </summary>
    public class MedicalFileRepository : SmartDigitalPsico.Core.SDK.Data.Repository.Generic.GenericRepositoryEntityBase<MedicalFile>, IMedicalFileRepository
    {
        /// <summary>
        /// Método MedicalFileRepository: executa a operação MedicalFileRepository.
        /// </summary>
        public MedicalFileRepository(IEntityDataContext context) : base(context) { }

        /// <summary>
        /// Método FindAll: consulta e retorna dados.
        /// </summary>
        public async override Task<List<MedicalFile>> FindAll()
        {
            return await _dataset
                .AsNoTracking()
                .Include(e => e.CreatedUser)//validation required
                .Include(e => e.Medical).ToListAsync();
        }

        /// <summary>
        /// Método FindAllByMedical: consulta e retorna dados.
        /// </summary>
        public async Task<List<MedicalFile>> FindAllByMedical(long medicalId)
        {
            return await _dataset
                .AsNoTracking()
                .Where(e => e.MedicalId == medicalId)
                .Include(e => e.Medical)
                .Include(e => e.CreatedUser)//validation required
                .ToListAsync();
        }
    }
}
