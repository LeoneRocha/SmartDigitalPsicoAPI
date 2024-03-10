using SmartDigitalPsico.Domain.ModelEntity.Principals;

namespace SmartDigitalPsico.Domain.Contracts.Interface
{
    public interface IEntityBaseLogUser
    {

        User? CreatedUser { get; set; }

        User? ModifyUser { get; set; }

    }
}