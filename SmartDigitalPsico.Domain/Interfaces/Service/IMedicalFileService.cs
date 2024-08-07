using SmartDigitalPsico.Domain.Hypermedia.Utils;
using SmartDigitalPsico.Domain.ModelEntity;
using SmartDigitalPsico.Domain.VO.Medical.MedicalFile;

namespace SmartDigitalPsico.Domain.Interfaces.Service
{
    public interface IMedicalFileService : IEntityBaseService<MedicalFile, AddMedicalFileVO, UpdateMedicalFileVO, GetMedicalFileVO>
    {
        Task<GetMedicalFileVO> DownloadFileById(long fileId);
        Task<ServiceResponse<GetMedicalFileVO>> PostFileAsync(AddMedicalFileVO entity);

        Task<ServiceResponse<List<GetMedicalFileVO>>> FindAllByMedical(long medicalId);
    }
}