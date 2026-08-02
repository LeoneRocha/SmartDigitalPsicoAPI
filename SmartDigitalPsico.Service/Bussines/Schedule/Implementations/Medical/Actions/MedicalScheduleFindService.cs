using SmartDigitalPsico.Domain.Constants.I18nKeyConstants;
using SmartDigitalPsico.Domain.DTO.Medical.MedicalCalendar;
using SmartDigitalPsico.Domain.Interfaces.Service.Schedule;
using SmartDigitalPsico.Domain.VO;

namespace SmartDigitalPsico.Service.Bussines.Schedule.Implementations.Medical.Actions
{
    public class MedicalScheduleFindService : IScheduleCalendarFindService
    {
        private readonly MedicalScheduleHostSupport _support;
        private readonly IScheduleQueryService _query;

        public MedicalScheduleFindService(MedicalScheduleHostSupport support, IScheduleQueryService query)
        {
            _support = support;
            _query = query;
        }

        public void SetUserId(long userId) => _support.SetUserId(userId);

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
