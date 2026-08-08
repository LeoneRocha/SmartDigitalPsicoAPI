using Azure.Storage.Blobs.Models;

namespace SmartDigitalPsico.Domain.Security
{
    /// <summary>
    /// Classe responsável por BlobFileDto.
    /// Responsabilidade: DTO de transferência de dados entre camadas da API.
    /// Relação: usado por Controllers, Services e Validators.
    /// </summary>
        // Movido para SmartDigitalPsicoAPI.Core.SDK.
    [Obsolete("Movido para SmartDigitalPsicoAPI.Core.SDK. Use o tipo correspondente no pacote SmartDigitalPsicoAPI.Core.SDK.", error: false, DiagnosticId = "SDP_CORE_SDK_HELPER")]
    public class BlobFileDto : SmartDigitalPsicoAPI.Core.SDK.Domain.DTO.BlobFileDto
    {
    }
}
