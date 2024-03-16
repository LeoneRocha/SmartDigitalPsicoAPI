using SmartDigitalPsico.Domain.ModelEntity;

namespace SmartDigitalPsico.Domain.Interfaces
{
    public interface IEntityBaseLogUser
    {

        User? CreatedUser { get; set; }

        User? ModifyUser { get; set; }

    }
}