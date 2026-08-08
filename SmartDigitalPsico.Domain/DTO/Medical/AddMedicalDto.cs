using SmartDigitalPsico.Domain.Interfaces;

namespace SmartDigitalPsico.Domain.DTO.Medical
{
    /// <summary>
    /// Classe responsável por AddMedicalDto.
    /// Responsabilidade: DTO de transferência de dados entre camadas da API.
    /// Relação: usado por Controllers, Services e Validators.
    /// </summary>
    public class AddMedicalDto : ActionMedicalDtoBase, SmartDigitalPsicoAPI.Core.SDK.Domain.Interfaces.IEntityDtoAdd
    {
        #region Relationship   
        public long OfficeId { get; set; }
        public List<long> SpecialtiesIds { get; set; } = new List<long>(); 
        #endregion Relationship 
    }
}
