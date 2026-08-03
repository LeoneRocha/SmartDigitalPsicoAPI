using SmartDigitalPsico.Domain.Enuns;

namespace SmartDigitalPsico.Domain.DTO.Domains
{
    /// <summary>
    /// Classe responsável por DataBaseConfigurationDto.
    /// Responsabilidade: DTO de transferência de dados entre camadas da API.
    /// Relação: usado por Controllers, Services e Validators.
    /// </summary>
    public class DataBaseConfigurationDto
    {
        public ETypeDataBase TypeDataBase { get; set; }
    }
}
