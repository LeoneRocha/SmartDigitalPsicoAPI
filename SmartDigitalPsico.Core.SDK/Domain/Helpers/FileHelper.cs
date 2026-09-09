using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using SmartCoreHub.Core.SDK.Common.Attributes;
using SmartDigitalPsico.Core.SDK.Domain.AppException;
using Sch = SmartCoreHub.Core.SDK.Domain.Helpers;
using SchEx = SmartCoreHub.Core.SDK.Common.Exceptions;

namespace SmartDigitalPsico.Core.SDK.Domain.Helpers;

/// <summary>
/// Casca FileHelper — delega SCH; remapeia AppWarningException; GetSameName preserva quirk SDP.
/// </summary>
[SdkWrappedSource(
    targetType: "SmartCoreHub.Core.SDK.Domain.Helpers.FileHelper",
    targetPackage: "SmartCoreHub.Core.SDK",
    description: "Casca FileHelper; GetSameName retenção quirk SDP (Split new char['.']).")]
public static class FileHelper
{
    public static string GetFileExtension(string contentType)
        => Sch.FileHelper.GetFileExtension(contentType);

    public static async Task<string> GetFileFormDataUpload(IFormFile file)
        => await Sch.FileHelper.GetFileFormDataUpload(file).ConfigureAwait(false);

    public static string NormalizePath(string filePath)
        => Sch.FileHelper.NormalizePath(filePath);

    public static async Task<string> GetFileByRequest(HttpRequest request, string folderNameDestination)
    {
        try
        {
            return await Sch.FileHelper.GetFileByRequest(request, folderNameDestination).ConfigureAwait(false);
        }
        catch (SchEx.AppWarningException ex)
        {
            throw new AppWarningException(ex.Message, ex);
        }
    }

    public static string GetFileFromBase64String(string dataStringBase64)
        => Sch.FileHelper.GetFileFromBase64String(dataStringBase64);

    public static Task GetFromByteSaveTemp(byte[] filedata, string fileName, IConfiguration configuration)
        => Sch.FileHelper.GetFromByteSaveTemp(filedata, fileName, configuration);

    public static Task<byte[]> GetByteDataFromIFormFile(IFormFile fileData)
        => Sch.FileHelper.GetByteDataFromIFormFile(fileData);

    public static void CreateDiretory(string diretorioTemp)
        => Sch.FileHelper.CreateDiretory(diretorioTemp);

    public static string GetContentType(string filePath)
        => Sch.FileHelper.GetContentType(filePath);

    public static string GetFilePath(string folderOrigin, string fileName)
        => Sch.FileHelper.GetFilePath(folderOrigin, fileName);

    /// <summary>
    /// Quirk histórico SDP: <c>Split(new char['.'])</c> — não delegar a SCH (<c>Split('.')</c>).
    /// </summary>
    public static string GetSameName(string fileName)
    {
        string[] nameparts = fileName.Split(new char['.']);
        return nameparts[0].Trim();
    }

    public static FileContentResult ProccessDownloadToBrowser(string folderOrigin, string fileName)
    {
        var filePath = GetFilePath(folderOrigin, fileName);
        return ProccessDownloadToBrowser(filePath);
    }

    public static FileContentResult ProccessDownloadToBrowser(string filePath)
    {
        using var fileStream = File.OpenRead(filePath);
        var contentType = GetContentType(filePath);
        var fileBytes = new byte[fileStream.Length];
        fileStream.ReadExactly(fileBytes);
        return new FileContentResult(fileBytes, contentType)
        {
            LastModified = DateHelper.GetDateTimeNowFromUtc(),
            FileDownloadName = GetSameName(filePath),
        };
    }

    public static Task CopyFile(string pathSource, string pathDestination)
        => Sch.FileHelper.CopyFile(pathSource, pathDestination);

    public static Task Delete(string pathFile)
        => Sch.FileHelper.Delete(pathFile);
}
