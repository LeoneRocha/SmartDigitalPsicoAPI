using SmartDigitalPsico.Domain.AppException;
using SmartDigitalPsico.Domain.Constants.I18nKeyConstants;
using SmartDigitalPsico.Domain.DTO.Schedule;
using SmartDigitalPsico.Domain.Interfaces;
using SmartDigitalPsico.Domain.Interfaces.Repository;
using SmartDigitalPsico.Domain.Interfaces.Service;
using SmartDigitalPsico.Domain.ModelEntity;
using MedicalEntity = SmartDigitalPsico.Domain.ModelEntity.Medical;

namespace SmartDigitalPsico.Service.Bussines.Schedule.Implementations.Medical
{
    /// <summary>
    /// Medical host: loads working profile from IMedicalRepository → ScheduleOwnerConstraints for Core.
    /// </summary>
    public class MedicalScheduleConstraintsProvider
    {
        private readonly IMedicalRepository _medicalRepository;
        private readonly IApplicationLanguageService _languageService;
        private readonly ICacheService _cacheService;

        public MedicalScheduleConstraintsProvider(
            IMedicalRepository medicalRepository,
            IApplicationLanguageService languageService,
            ICacheService cacheService)
        {
            _medicalRepository = medicalRepository;
            _languageService = languageService;
            _cacheService = cacheService;
        }

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

        public async Task<ScheduleOwnerConstraints> GetConstraintsAsync(long medicalId)
        {
            var medical = await GetMedicalAsync(medicalId);
            return ToConstraints(medical);
        }

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
