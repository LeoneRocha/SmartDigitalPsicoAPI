using SmartDigitalPsico.Domain.ModelEntity;

namespace SmartDigitalPsico.Data.Context.Configure.Mock
{
    /// <summary>
    /// Classe responsável por PatientInfoTagMockData.
    /// Responsabilidade: configuração de startup/DI da aplicação.
    /// Relação: integra as camadas Domain/Data/Service/WebAPI do SmartDigitalPsico.
    /// </summary>
    public static class PatientInfoTagMockData
    {
        /// <summary>
        /// Método GetMock: consulta e retorna dados.
        /// </summary>
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
