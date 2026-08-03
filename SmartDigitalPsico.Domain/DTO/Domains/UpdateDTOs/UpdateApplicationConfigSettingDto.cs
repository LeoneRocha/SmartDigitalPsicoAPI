using SmartDigitalPsico.Domain.DTO.Contracts;

namespace SmartDigitalPsico.Domain.DTO.Domains.UpdateDTOs
{
    /// <summary>
    /// Classe responsável por UpdateApplicationConfigSettingDto.
    /// Responsabilidade: DTO de transferência de dados entre camadas da API.
    /// Relação: usado por Controllers, Services e Validators.
    /// </summary>
    public class UpdateApplicationConfigSettingDto : EntityDtoBaseDomain
    {
        public string EndPointUrl_StorageFiles { get; set; } = string.Empty;
        public string EndPointUrl_Cache { get; set; } = string.Empty;

        public string UrlRootManager { get; set; } = string.Empty;
    }
}
