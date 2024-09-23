using SmartDigitalPsico.Domain.ModelEntity;
using SmartDigitalPsico.Domain.DTO.Medical.MedicalFile;
using SmartDigitalPsico.Domain.VO;

namespace SmartDigitalPsico.Domain.Interfaces.Service
{
    public interface IMedicalFileService : IEntityBaseService<MedicalFile, AddMedicalFileDto, UpdateMedicalFileDto, GetMedicalFileDto>
    {
        Task<GetMedicalFileDto> DownloadFileById(long fileId);
        Task<ServiceResponse<GetMedicalFileDto>> PostFileAsync(AddMedicalFileDto entity);

        Task<ServiceResponse<List<GetMedicalFileDto>>> FindAllByMedical(long medicalId);
    }
}