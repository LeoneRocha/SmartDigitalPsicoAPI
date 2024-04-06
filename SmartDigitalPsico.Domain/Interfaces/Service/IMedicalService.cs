using SmartDigitalPsico.Domain.ModelEntity;
using SmartDigitalPsico.Domain.VO.Medical;

namespace SmartDigitalPsico.Domain.Interfaces.Service
{
    public interface IMedicalService
        : IEntityBaseService<Medical, AddMedicalVO, UpdateMedicalVO, GetMedicalVO>
    {

    }
}