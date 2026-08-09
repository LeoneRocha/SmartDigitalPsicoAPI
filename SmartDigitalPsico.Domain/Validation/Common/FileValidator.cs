using FluentValidation;
using Microsoft.Extensions.Configuration;
using SmartDigitalPsico.Core.SDK.Domain.EntityModels.Contracts;
using SmartDigitalPsico.Domain.Helpers;

namespace SmartDigitalPsico.Domain.Validation
{
    /// <summary>
    /// Classe responsável por FileValidator.
    /// Responsabilidade: validador FluentValidation de regras de negócio.
    /// Relação: invocado pelos Services antes da persistência.
    /// </summary>
    public class FileValidator : AbstractValidator<FileBase>
    {
        private readonly string[] _permittedExtensions;
        private readonly string[] _permittedContentTypes;

        /// <summary>
        /// Método FileValidator: executa a operação FileValidator.
        /// </summary>
        public FileValidator(IConfiguration configuration)
        {
            _permittedExtensions = ConfigurationAppSettingsHelper.GetAllowedFileExtensions(configuration);
            _permittedContentTypes = ConfigurationAppSettingsHelper.GetAllowedContentTypes(configuration);
            long _maxFileSize = ConfigurationAppSettingsHelper.GetMaxFileSizeMegabytes(configuration);

            RuleFor(file => file.FileSizeKB)
                .NotNull()
                .WithErrorCode("SmartDigitalPsico.FileValidator.FileBase.FileSizeKB.NotNull")
                .WithMessage("FileSizeKB_Validator_IsRequired_Key|File size is required.")
                .LessThanOrEqualTo(_maxFileSize)
                .WithErrorCode("SmartDigitalPsico.FileValidator.FileBase.FileSizeKB.LessThanOrEqualTo")
                .WithMessage($"FileSizeKB_Validator_MaxSize_Key|The file size cannot exceed {0} MB.|{ConvertBytesToMegabytes(_maxFileSize)}");

            RuleFor(file => file.FileExtension)
                .NotNull()
                .WithErrorCode("SmartDigitalPsico.FileValidator.FileBase.FileExtension.NotNull")
                .WithMessage("FileExtension_Validator_IsRequired_Key|File extension is required.")
                .Must(HavePermittedExtension)
                .WithErrorCode("SmartDigitalPsico.FileValidator.FileBase.FileExtension.Must")
                .WithMessage("FileExtension_Validator_NotAllowed_Key|File type not permitted.");

            RuleFor(file => file.FileContentType)
                .NotNull()
                .WithErrorCode("SmartDigitalPsico.FileValidator.FileBase.FileContentType.NotNull")
                .WithMessage("FileContentType_Validator_IsRequired_Key|File content type is required.")
                .Must(HavePermittedContentType)
                .WithErrorCode("SmartDigitalPsico.FileValidator.FileBase.FileContentType.Must")
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
