using SmartDigitalPsico.Domain.Interfaces;

namespace SmartDigitalPsico.Domain.DTO.Domains.UpdateDTOs
{
    public class UpdateEmailTemplateDto : EmailTemplateBaseDto, IEntityDto
    {
        public long Id { get; set; }    
    }
}