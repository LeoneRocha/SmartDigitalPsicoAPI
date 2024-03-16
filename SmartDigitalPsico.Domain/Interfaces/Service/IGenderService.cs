using SmartDigitalPsico.Domain.ModelEntity;
using SmartDigitalPsico.Domain.VO.Domains.AddVOs;
using SmartDigitalPsico.Domain.VO.Domains.GetVOs;
using SmartDigitalPsico.Domain.VO.Domains.UpdateVOs;

namespace SmartDigitalPsico.Domain.Interfaces.Service
{
    public interface IGenderService 
        : IEntityBaseSimpleService<Gender, AddGenderVO, UpdateGenderVO, GetGenderVO>
    {

    }
}