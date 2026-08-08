using SmartDigitalPsico.Domain.ModelEntity;

using UserEntity = SmartDigitalPsico.Domain.ModelEntity.User;

namespace SmartDigitalPsico.Domain.Interfaces.Common
{
    /// <summary>
    /// Interface (contrato) responsável por IEntityBaseLogUser.
    /// Responsabilidade: contrato de abstração do domínio.
    /// Relação: implementado nas camadas Data/Service.
    /// </summary>
    public interface IEntityBaseLogUser
    {

        UserEntity? CreatedUser { get; set; }

        UserEntity? ModifyUser { get; set; }

    }
}
