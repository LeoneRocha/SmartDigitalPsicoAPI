using SmartDigitalPsico.Domain.ModelEntity.Schedule;

using SmartDigitalPsico.Domain.ModelEntity;

namespace SmartDigitalPsico.Data.Context.Configure.Mock
{
    /// <summary>
    /// Classe responsável por RoleGroupUserMockData.
    /// Responsabilidade: configuração de startup/DI da aplicação.
    /// Relação: integra as camadas Domain/Data/Service/WebAPI do SmartDigitalPsico.
    /// </summary>
    public static class RoleGroupUserMockData  
    { 
        /// <summary>
        /// Método GetMock: consulta e retorna dados.
        /// </summary>
        public static RoleGroupUser[] GetMock()
        {
            var userAdmin = new RoleGroupUser
            {
                RoleGroupId = 1,
                UserId = 1,
            };

            var userMedical = new RoleGroupUser
            {
                RoleGroupId = 2,
                UserId = 2,
            };

            return [
                userAdmin,
                userMedical
            ];
        }

        /// <summary>
        /// Método GetMockUnitTest: consulta e retorna dados.
        /// </summary>
        public static RoleGroupUser[] GetMockUnitTest() => GetMock();
    }
}
