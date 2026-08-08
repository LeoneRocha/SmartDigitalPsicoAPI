namespace SmartDigitalPsico.Domain.DTO.Application.UPDATE
{
    /// <summary>
    /// Classe responsável por UpdateApplicationConfigSettingDto.
    /// Responsabilidade: DTO de transferência de dados entre camadas da API.
    /// Relação: usado por Controllers, Services e Validators.
    /// </summary>
    public class UpdateApplicationConfigSettingDto : SmartDigitalPsico.Core.SDK.Domain.DTO.Contracts.EntityDtoBaseDomain
    {
        public string EndPointUrl_StorageFiles { get; set; } = string.Empty;
        public string EndPointUrl_Cache { get; set; } = string.Empty;

        public string UrlRootManager { get; set; } = string.Empty;
    }
}
