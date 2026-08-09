using AutoMapper;

namespace SmartDigitalPsico.Domain.Mapper
{
    /// <summary>
    /// Classe responsável por AutoMapperProfile.
    /// Responsabilidade: marcador do assembly de perfis AutoMapper do Domain.
    /// Relação: os perfis específicos (GenderProfile, PatientProfile, etc.) são escaneados automaticamente via AddMaps/AddCoreMapper.
    /// </summary>
    public class AutoMapperProfile : Profile
    {
        public AutoMapperProfile()
        {
        }
    }
}
