using SmartDigitalPsico.Core.SDK.Domain.AppException;
using SmartDigitalPsico.Domain.Constants;
using SmartDigitalPsico.Domain.DTO.Schedule.Common;
using MedicalEntity = SmartDigitalPsico.Domain.EntityModels.Medical;

using SmartDigitalPsico.Domain.Interfaces.Application;
using SmartDigitalPsico.Domain.Interfaces.Common;
using SmartDigitalPsico.Domain.Interfaces.Medical;
namespace SmartDigitalPsico.Service.Bussines.Schedule.Implementations.Medical
{
    /// <summary>
    /// Medical host: loads working profile from IMedicalRepository → ScheduleOwnerConstraints for Core.
    /// </summary>
    public class MedicalScheduleConstraintsProvider
    {
        private readonly IMedicalRepository _medicalRepository;
        private readonly IApplicationLanguageService _languageService;
        private readonly SmartDigitalPsico.Core.SDK.Domain.Interfaces.Service.ICacheService _cacheService;

        /// <summary>
        /// Método MedicalScheduleConstraintsProvider: executa a operação MedicalScheduleConstraintsProvider.
        /// </summary>
        public MedicalScheduleConstraintsProvider(
            IMedicalRepository medicalRepository,
            IApplicationLanguageService languageService,
            SmartDigitalPsico.Core.SDK.Domain.Interfaces.Service.ICacheService cacheService)
        {
            _medicalRepository = medicalRepository;
            _languageService = languageService;
            _cacheService = cacheService;
        }

        /// <summary>
        /// Método GetMedicalAsync: consulta e retorna dados.
        /// </summary>
        public async Task<MedicalEntity> GetMedicalAsync(long medicalId)
        {
            var medical = await _medicalRepository.FindByID(medicalId);
            if (medical == null)
            {
                var message = await _languageService.GetLocalization<ISharedResource>(
                    MedicalKeyConstants.Medical_Not_Found,
                    MedicalMenssageConstants.Medical_Not_Found,
                    _cacheService);
                throw new AppWarningException(message);
            }
            return medical;
        }

        /// <summary>
        /// Método GetConstraintsAsync: consulta e retorna dados.
        /// </summary>
        public async Task<ScheduleOwnerConstraints> GetConstraintsAsync(long medicalId)
        {
            var medical = await GetMedicalAsync(medicalId);
            return ToConstraints(medical);
        }

        /// <summary>
        /// Método ToConstraints: mapeia ou transforma dados entre modelos.
        /// </summary>
        public static ScheduleOwnerConstraints ToConstraints(MedicalEntity medical)
            => new()
            {
                WorkingDays = medical.WorkingDays ?? [],
                StartWorkingTime = medical.StartWorkingTime,
                EndWorkingTime = medical.EndWorkingTime,
                IntervalMinutes = medical.PatientIntervalTimeMinutes,
                DisplayName = medical.Name
            };
    }
}
