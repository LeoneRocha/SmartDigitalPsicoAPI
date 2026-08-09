namespace SmartDigitalPsico.Domain.DTO.Application.ADD
{
    /// <summary>
    /// Classe responsável por AddApplicationConfigSettingDto.
    /// Responsabilidade: DTO de transferência de dados entre camadas da API.
    /// Relação: usado por Controllers, Services e Validators.
    /// </summary>
    public class AddApplicationConfigSettingDto : SmartDigitalPsico.Core.SDK.Domain.DTO.Contracts.EntityDtoBaseDomainAdd
    {
        public string EndPointUrl_StorageFiles { get; set; } = string.Empty;
        public string EndPointUrl_Cache { get; set; } = string.Empty;

        public string UrlRootManager { get; set; } = string.Empty;
    }
}
