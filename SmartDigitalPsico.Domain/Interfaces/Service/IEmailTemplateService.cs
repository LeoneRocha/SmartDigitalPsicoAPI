using SmartDigitalPsico.Domain.ModelEntity;
using SmartDigitalPsico.Domain.DTO.Domains.AddDTOs;
using SmartDigitalPsico.Domain.DTO.Domains.GetDTOs;
using SmartDigitalPsico.Domain.DTO.Domains.UpdateDTOs;
using SmartDigitalPsico.Domain.VO;

namespace SmartDigitalPsico.Domain.Interfaces.Service
{
    public interface IEmailTemplateService : IEntityBaseService<EmailTemplate, AddEmailTemplateDto, UpdateEmailTemplateDto, GetEmailTemplateDto>
    {
        Task<ServiceResponse<GetEmailTemplateDto>> GetEmailTemplateAsync(string tagApi);
    }
}
