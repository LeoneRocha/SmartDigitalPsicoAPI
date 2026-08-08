using Microsoft.EntityFrameworkCore;
using SmartDigitalPsico.Core.SDK.Data.Context.Interface;
using SmartDigitalPsico.Core.SDK.Data.Repository.Generic;
using SmartDigitalPsico.Domain.Interfaces.Repository;
using SmartDigitalPsico.Core.SDK.Domain.Interfaces.Repository;
using SmartDigitalPsico.Domain.ModelEntity;

namespace SmartDigitalPsico.Data.Repository.Principals
{
    /// <summary>
    /// Classe responsável por MedicalRepository.
    /// Responsabilidade: repositório de persistência.
    /// Relação: implementa interfaces do Domain e usa o EF Core Context.
    /// </summary>
    public class MedicalRepository : SmartDigitalPsico.Core.SDK.Data.Repository.Generic.GenericRepositoryEntityBase<Medical>, IMedicalRepository
    {
        /// <summary>
        /// Método MedicalRepository: executa a operação MedicalRepository.
        /// </summary>
        public MedicalRepository(IEntityDataContext context) : base(context) { }

        /// <summary>
        /// Método Exists: valida regras ou verifica existência.
        /// </summary>
        public async Task<bool> Exists(string accreditation)
        {
            return await _dataset
                .AsNoTracking()
                .AnyAsync(x => x.Accreditation.ToLower().Equals(accreditation.ToLower()));
        }
        /// <summary>
        /// Método FindByID: consulta e retorna dados.
        /// </summary>
        public async override Task<Medical> FindByID(long id)
        {
            return await _dataset
                .Include(e => e.User)
                .Include(e => e.Office)
                .Include(e => e.MedicalSpecialties)
                .ThenInclude(ms => ms.Specialty)
                .Include(e => e.CreatedUser)
                .FirstAsync(p => p.Id.Equals(id));
        }
        /// <summary>
        /// Método FindAll: consulta e retorna dados.
        /// </summary>
        public async override Task<List<Medical>> FindAll()
        {
            return await _dataset
                .AsNoTracking()
                .Include(e => e.User)
                .Include(e => e.Office)
                .Include(e => e.MedicalSpecialties)
                .ThenInclude(ms => ms.Specialty)
                .Include(e => e.CreatedUser)
                .ToListAsync();
        }

        /// <summary>
        /// Método FindByEmail: consulta e retorna dados.
        /// </summary>
        public async Task<Medical?> FindByEmail(string email)
        {
            var normalizedEmail = email.ToLower();

            Medical? entityResult = (await _dataset
                .AsNoTracking()
                .Where(p => p.Email == normalizedEmail).ToListAsync())
                .Find(p => p.Email.Equals(email, StringComparison.OrdinalIgnoreCase));

            return entityResult;
        }
        /// <summary>
        /// Método FindByAccreditation: consulta e retorna dados.
        /// </summary>
        public async Task<Medical?> FindByAccreditation(string accreditation)
        {
            var normalizedAccreditation = accreditation.ToLower();

            Medical? entityResult = (await _dataset
                .AsNoTracking()
                .Include(e => e.User)
                .Include(e => e.Office)
                .Include(e => e.MedicalSpecialties)
                .ThenInclude(ms => ms.Specialty)
                .Include(e => e.CreatedUser)
                .Where(p => p.Accreditation == normalizedAccreditation).ToListAsync())                
                .Find(p => p.Accreditation.Equals(normalizedAccreditation, StringComparison.OrdinalIgnoreCase));

            return entityResult;
        }
    }
}
