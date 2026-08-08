using SmartDigitalPsico.Domain.DTO.Medical.Common;
namespace SmartDigitalPsico.Domain.DTO.Medical.UPDATE
{
    /// <summary>
    /// Classe responsável por UpdateMedicalDto.
    /// Responsabilidade: DTO de transferência de dados entre camadas da API.
    /// Relação: usado por Controllers, Services e Validators.
    /// </summary>
    public class UpdateMedicalDto : ActionMedicalDtoBase, SmartDigitalPsico.Core.SDK.Domain.Interfaces.IEntityDto
    {
        #region Relationship        
        public long OfficeId { get; set; }
        public List<long> SpecialtiesIds { get; set; } = new List<long>();

        #endregion Relationship 
    }
}
