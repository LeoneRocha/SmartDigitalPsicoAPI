using SmartDigitalPsico.Domain.Enuns;
using SmartDigitalPsico.Domain.Helpers;
using SmartDigitalPsico.Domain.ModelEntity;

namespace SmartDigitalPsico.Data.Context.Configure.Mock
{
    public static class MedicalMockData  
    { 
        public static Medical[] GetMock()
        {
            var newAddMedical = new Medical
            {
                Id = 1,
                Name = "Dr. Gabriel Monteiro",
                Email = "medical@sistemas.com",
                CreatedDate = DateHelper.GetDateTimeNowFromUtc(),
                Enable = true,
                LastAccessDate = DateHelper.GetDateTimeNowFromUtc(),
                ModifyDate = DateHelper.GetDateTimeNowFromUtc(),
                Accreditation = "123456",
                TypeAccreditation = ETypeAccreditation.CRM,
                OfficeId = 1,
                CreatedUserId = 1,
                StartWorkingTime = new TimeSpan(6, 0, 0),
                EndWorkingTime = new TimeSpan(20, 0, 0),   
                PatientIntervalTimeMinutes = 60,
                WorkingDays = [
                    DayOfWeek.Monday,
                    DayOfWeek.Tuesday,
                    DayOfWeek.Wednesday,
                    DayOfWeek.Thursday,
                    DayOfWeek.Friday,
                    DayOfWeek.Saturday]
            };
            return [
                 newAddMedical
            ];
        }
    }
}