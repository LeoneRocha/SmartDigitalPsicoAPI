using Azure.Storage.Blobs.Models;

namespace SmartDigitalPsico.Domain.Security
{
    /// <summary>
    /// Classe responsável por BlobFileDto.
    /// Responsabilidade: DTO de transferência de dados entre camadas da API.
    /// Relação: usado por Controllers, Services e Validators.
    /// </summary>
    public class BlobFileDto
    {
        public string FilePath { get; set; } = string.Empty;
        public string ContainerName { get; set; } = string.Empty;
        public BlobHttpHeaders? BlobHeaders { get; set; }
        public string? BlobName { get; set; }
    }
}
