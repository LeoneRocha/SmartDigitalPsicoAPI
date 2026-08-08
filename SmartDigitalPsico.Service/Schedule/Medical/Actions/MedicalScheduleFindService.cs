using SmartDigitalPsico.Core.SDK.Domain.Constants.I18nKeyConstants;
using SmartDigitalPsico.Domain.DTO.Medical.MedicalCalendar.ADD;
using SmartDigitalPsico.Domain.DTO.Medical.MedicalCalendar.GET;
using SmartDigitalPsico.Domain.DTO.Medical.MedicalCalendar.UPDATE;
using SmartDigitalPsico.Domain.DTO.Medical.MedicalCalendar.Common;
using SmartDigitalPsico.Core.SDK.Domain.VO;

using SmartDigitalPsico.Domain.Interfaces.Schedule;
namespace SmartDigitalPsico.Service.Schedule.Medical.Actions
{
    using User = SmartDigitalPsico.Domain.EntityModels.User;
    using Patient = SmartDigitalPsico.Domain.EntityModels.Patient;
    using Medical = SmartDigitalPsico.Domain.EntityModels.Medical;
    using RoleGroup = SmartDigitalPsico.Domain.EntityModels.RoleGroup;
    using Gender = SmartDigitalPsico.Domain.EntityModels.Gender;
    using Leaves = SmartDigitalPsico.Domain.EntityModels.Leaves;
    using Office = SmartDigitalPsico.Domain.EntityModels.Office;
    using Specialty = SmartDigitalPsico.Domain.EntityModels.Specialty;
    /// <summary>
    /// Classe responsável por MedicalScheduleFindService.
    /// Responsabilidade: módulo de agendamento (Schedule).
    /// Relação: orquestra Core Schedule e contratos Medical do Domain.
    /// </summary>
    public class MedicalScheduleFindService : IScheduleCalendarFindService
    {
        private readonly MedicalScheduleHostSupport _support;
        private readonly IScheduleQueryService _query;

        /// <summary>
        /// Método MedicalScheduleFindService: executa a operação MedicalScheduleFindService.
        /// </summary>
        public MedicalScheduleFindService(MedicalScheduleHostSupport support, IScheduleQueryService query)
        {
            _support = support;
            _query = query;
        }

        /// <summary>
        /// Método SetUserId: configura estado ou dependencias.
        /// </summary>
        public void SetUserId(long userId) => _support.SetUserId(userId);

        /// <summary>
        /// Método FindByID: consulta e retorna dados.
        /// </summary>
        public async Task<ServiceResponse<GetMedicalCalendarDto>> FindByID(long id)
        {
            var result = await _query.GetByIdAsync(id);
            if (!result.Success || result.Data == null)
                return MedicalScheduleHostSupport.FailDto(
                    await _support.Loc(GeneralLanguageKeyConstants.RegisterIsNotFound, GeneralLanguageMenssageConstants.RegisterIsNotFound));

            return MedicalScheduleHostSupport.OkDto(
                MedicalScheduleMapper.ToGetDto(result.Data),
                await _support.Loc(GeneralLanguageKeyConstants.RegisterFind, GeneralLanguageMenssageConstants.RegisterFind));
        }
    }
}
