namespace SmartDigitalPsico.Domain.DTO.Leaves.Common
{
    /// <summary>
    /// Classe responsável por LeavesBaseDto.
    /// Responsabilidade: DTO de transferência de dados entre camadas da API.
    /// Relação: usado por Controllers, Services e Validators.
    /// </summary>
    public abstract class LeavesBaseDto : SmartDigitalPsico.Core.SDK.Domain.DTO.Contracts.EntityDtoBaseDomain
    {
        public DateTime StartDate { get; set; }
        public DateTime? EndDate { get; set; }
        public bool IsRecurring { get; set; }
    }
}
