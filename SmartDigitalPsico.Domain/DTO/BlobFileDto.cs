using Azure.Storage.Blobs.Models;

namespace SmartDigitalPsico.Domain.Security
{
    public class BlobFileDto
    {
        public string FilePath { get; set; } = string.Empty;
        public string ContainerName { get; set; } = string.Empty;
        public BlobHttpHeaders? BlobHeaders { get; set; }
        public string? BlobName { get; set; }
    }
}