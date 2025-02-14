using FluentValidation;
using Microsoft.Extensions.Configuration;
using SmartDigitalPsico.Domain.Helpers;
using SmartDigitalPsico.Domain.ModelEntity.Contracts;

namespace SmartDigitalPsico.Domain.Validation.Base
{
    public class FileValidator : AbstractValidator<FileBase>
    {
        private readonly string[] _permittedExtensions;
        private readonly string[] _permittedContentTypes;
       
        public FileValidator(IConfiguration configuration)
        {
            _permittedExtensions = ConfigurationAppSettingsHelper.GetAllowedFileExtensions(configuration);
            _permittedContentTypes = ConfigurationAppSettingsHelper.GetAllowedContentTypes(configuration);
            long _maxFileSize = ConfigurationAppSettingsHelper.GetMaxFileSizeMegabytes(configuration);

            RuleFor(file => file.FileSizeKB)
                .NotNull()
                .LessThanOrEqualTo(_maxFileSize)
                .WithMessage($"FileSizeKB_Validator_MaxSize_Key|The file size cannot exceed {0} MB.|{ConvertBytesToMegabytes(_maxFileSize)}");

            RuleFor(file => file.FileExtension)
                .NotNull()
                .Must(HavePermittedExtension)
                .WithMessage("FileExtension_Validator_NotAllowed_Key|File type not permitted.");

            RuleFor(file => file.FileContentType)
                .NotNull()
                .Must(HavePermittedContentType)
                .WithMessage("FileContentType_Validator_NotAllowed_Key|File content type not permitted.");
        }
        private bool HavePermittedExtension(string extension)
        {
            return _permittedExtensions.Contains(extension);
        }

        private bool HavePermittedContentType(string contentType)
        {
            return _permittedContentTypes.Contains(contentType);
        }
        private static double ConvertBytesToMegabytes(long bytes)
        {
            return (double)bytes / (1024);
        }
    }
}
