using SmartDigitalPsico.Domain.ModelEntity;

namespace SmartDigitalPsico.Data.Context.Configure.Mock
{
    public static class PatientInfoTagMockData
    {
        public static PatientInfoTag[] GetMock()
        {
            var patients = PatientMockData.GetMock();
            var tags = InfoTagMockData.GetMock();
            var list = new List<PatientInfoTag>(patients.Length * tags.Length);

            foreach (var patient in patients)
            {
                foreach (var tag in tags)
                {
                    list.Add(new PatientInfoTag
                    {
                        InfoTagId = tag.Id,
                        PatientId = patient.Id
                    });
                }
            }

            return [.. list];
        }
    }
}
