namespace SmartDigitalPsico.Core.SDK.Domain.DTO
{
    /// <summary>
    /// Classe responsável por RepositoryInfo.
    /// Responsabilidade: DTO de transferência de dados entre camadas da API.
    /// Relação: usado por Controllers, Services e Validators.
    /// </summary>
    public class RepositoryInfo
    {
        public Type? InterfaceType { get; set; }
        public Type? ImplementationType { get; set; }
    }
}
