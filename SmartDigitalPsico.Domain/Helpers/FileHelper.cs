using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;

namespace SmartDigitalPsico.Domain.Helpers
{
    /// <summary>
    /// Shim Obsolete — implementação canônica em SmartDigitalPsico.Core.SDK.
    /// </summary>
    // Movido para SmartDigitalPsico.Core.SDK
    [Obsolete("Movido para SmartDigitalPsico.Core.SDK. Use o tipo correspondente no pacote SmartDigitalPsico.Core.SDK.", error: false, DiagnosticId = "SDP_CORE_SDK_HELPER")]
    public static class FileHelper
    {
        public static string GetFileExtension(string contentType)
            => SmartDigitalPsico.Core.SDK.Domain.Helpers.FileHelper.GetFileExtension(contentType);

        public static Task<string> GetFileFormDataUpload(IFormFile file)
            => SmartDigitalPsico.Core.SDK.Domain.Helpers.FileHelper.GetFileFormDataUpload(file);

        public static string NormalizePath(string filePath)
            => SmartDigitalPsico.Core.SDK.Domain.Helpers.FileHelper.NormalizePath(filePath);

        public static Task<string> GetFileByRequest(HttpRequest request, string folderNameDestination)
            => SmartDigitalPsico.Core.SDK.Domain.Helpers.FileHelper.GetFileByRequest(request, folderNameDestination);

        public static string GetFileFromBase64String(string dataStringBase64)
            => SmartDigitalPsico.Core.SDK.Domain.Helpers.FileHelper.GetFileFromBase64String(dataStringBase64);

        public static Task GetFromByteSaveTemp(byte[] filedata, string fileName, IConfiguration configuration)
            => SmartDigitalPsico.Core.SDK.Domain.Helpers.FileHelper.GetFromByteSaveTemp(filedata, fileName, configuration);

        public static Task<byte[]> GetByteDataFromIFormFile(IFormFile fileData)
            => SmartDigitalPsico.Core.SDK.Domain.Helpers.FileHelper.GetByteDataFromIFormFile(fileData);

        public static void CreateDiretory(string diretorioTemp)
            => SmartDigitalPsico.Core.SDK.Domain.Helpers.FileHelper.CreateDiretory(diretorioTemp);

        public static string GetContentType(string filePath)
            => SmartDigitalPsico.Core.SDK.Domain.Helpers.FileHelper.GetContentType(filePath);

        public static string GetFilePath(string folderOrigin, string fileName)
            => SmartDigitalPsico.Core.SDK.Domain.Helpers.FileHelper.GetFilePath(folderOrigin, fileName);

        public static string GetSameName(string fileName)
            => SmartDigitalPsico.Core.SDK.Domain.Helpers.FileHelper.GetSameName(fileName);

        public static FileContentResult ProccessDownloadToBrowser(string folderOrigin, string fileName)
            => SmartDigitalPsico.Core.SDK.Domain.Helpers.FileHelper.ProccessDownloadToBrowser(folderOrigin, fileName);

        public static FileContentResult ProccessDownloadToBrowser(string filePath)
            => SmartDigitalPsico.Core.SDK.Domain.Helpers.FileHelper.ProccessDownloadToBrowser(filePath);

        public static Task CopyFile(string pathSource, string pathDestination)
            => SmartDigitalPsico.Core.SDK.Domain.Helpers.FileHelper.CopyFile(pathSource, pathDestination);

        public static Task Delete(string pathFile)
            => SmartDigitalPsico.Core.SDK.Domain.Helpers.FileHelper.Delete(pathFile);
    }
}
