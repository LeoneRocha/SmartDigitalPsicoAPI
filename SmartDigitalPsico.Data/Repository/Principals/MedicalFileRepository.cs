using Microsoft.EntityFrameworkCore;
using SmartDigitalPsico.Data.Context.Interface;
using SmartDigitalPsicoAPI.Core.SDK.Data.Repository.Generic;
using SmartDigitalPsico.Domain.Interfaces.Repository;
using SmartDigitalPsicoAPI.Core.SDK.Domain.Interfaces.Repository;
using SmartDigitalPsico.Domain.ModelEntity;

namespace SmartDigitalPsico.Data.Repository.Principals
{
    /// <summary>
    /// Classe responsável por MedicalFileRepository.
    /// Responsabilidade: repositório de persistência.
    /// Relação: implementa interfaces do Domain e usa o EF Core Context.
    /// </summary>
    public class MedicalFileRepository : SmartDigitalPsicoAPI.Core.SDK.Data.Repository.Generic.GenericRepositoryEntityBase<MedicalFile>, IMedicalFileRepository
    {
        /// <summary>
        /// Método MedicalFileRepository: executa a operação MedicalFileRepository.
        /// </summary>
        public MedicalFileRepository(IEntityDataContext context) : base((Microsoft.EntityFrameworkCore.DbContext)context) { }

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
