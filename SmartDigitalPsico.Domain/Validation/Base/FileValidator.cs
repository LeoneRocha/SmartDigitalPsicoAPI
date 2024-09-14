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
            _permittedExtensions = ConfigurationAppSettingsHelper.GetAllowedContentTypes(configuration);
            _permittedContentTypes = ConfigurationAppSettingsHelper.GetAllowedFileExtensions(configuration);
            long _maxFileSize = ConfigurationAppSettingsHelper.GetMaxFileSizeMegabytes(configuration);

            RuleFor(file => file.FileSizeKB)
                .NotNull()
            .LessThanOrEqualTo(_maxFileSize)
            .WithMessage($"O tamanho do arquivo não pode exceder {ConvertBytesToMegabytes(_maxFileSize)} MB.");


            RuleFor(file => file.FileExtension)
                .NotNull()
                .Must(HavePermittedExtension)
                .WithMessage("Tipo de arquivo não permitido.");

            RuleFor(file => file.FileContentType)
                .NotNull()
                .Must(HavePermittedContentType)
                .WithMessage("Tipo de conteúdo do arquivo não permitido.");
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
