using SmartDigitalPsico.Domain.ModelEntity.Schedule;

using SmartDigitalPsico.Domain.ModelEntity;

namespace SmartDigitalPsico.Data.Context.Configure.Mock
{
    /// <summary>
    /// Classe responsável por MedicalSpecialtyMockData.
    /// Responsabilidade: configuração de startup/DI da aplicação.
    /// Relação: integra as camadas Domain/Data/Service/WebAPI do SmartDigitalPsico.
    /// </summary>
    public static class MedicalSpecialtyMockData  
    { 
        /// <summary>
        /// Método GetMock: consulta e retorna dados.
        /// </summary>
        public static MedicalSpecialty[] GetMock()
        {
            var medical1 = new MedicalSpecialty
            {
                MedicalId = 1,
                SpecialtyId = 1,
            };

            return [
                medical1
            ];
        }
    }
}
