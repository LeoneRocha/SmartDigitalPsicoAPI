using SmartDigitalPsico.Domain.ModelEntity;
using SmartDigitalPsico.Domain.DTO.Medical;

namespace SmartDigitalPsico.Domain.Interfaces.Service
{
    public interface IMedicalService
        : IEntityBaseService<Medical, AddMedicalDto, UpdateMedicalDto, GetMedicalDto>
    {

    }
}