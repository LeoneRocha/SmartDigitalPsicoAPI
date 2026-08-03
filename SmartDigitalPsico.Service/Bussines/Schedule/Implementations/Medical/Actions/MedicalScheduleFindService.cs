using SmartDigitalPsico.Domain.Constants.I18nKeyConstants;
using SmartDigitalPsico.Domain.DTO.Medical.MedicalCalendar;
using SmartDigitalPsico.Domain.Interfaces.Service.Schedule;
using SmartDigitalPsico.Domain.VO;

namespace SmartDigitalPsico.Service.Bussines.Schedule.Implementations.Medical.Actions
{
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
