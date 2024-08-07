using FluentValidation;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Configuration;
using SmartDigitalPsico.Domain.ModelEntity.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartDigitalPsico.Domain.Validation.Base
{
    public class FileValidator : AbstractValidator<FileBase>
    {
        private readonly string[] _permittedExtensions;
        private readonly string[] _permittedContentTypes;

        public FileValidator(IConfiguration configuration)
        {
            _permittedExtensions = configuration.GetSection("AllowedFileExtensions").Get<string[]>() ?? [];
            _permittedContentTypes = configuration.GetSection("AllowedContentTypes").Get<string[]>() ?? [];
            long _maxFileSize = configuration.GetValue<long>("MaxFileSizeMegabytes");

            RuleFor(file => file.FileSizeKB)
                .NotNull()
            .LessThanOrEqualTo(_maxFileSize)
            .WithMessage($"O tamanho do arquivo não pode exceder {convertBytesToMegabytes(_maxFileSize)} MB.");


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
        private static double convertBytesToMegabytes(long bytes)
        {
            return (double)bytes / (1024);
        }
    }
}
