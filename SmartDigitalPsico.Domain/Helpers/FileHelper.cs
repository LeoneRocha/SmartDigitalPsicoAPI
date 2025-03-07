﻿using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.StaticFiles;
using Microsoft.Extensions.Configuration;
using SmartDigitalPsico.Domain.AppException;
using SmartDigitalPsico.Domain.ModelEntity.Contracts;
using System.Net.Http.Headers;
using System.Text;

namespace SmartDigitalPsico.Domain.Helpers
{
    public static class FileHelper
    {
        public static string GetFileExtension(string contentType)
        {
            var splitExtension = contentType.Split('/').ToList();
            string extensionFile = splitExtension[splitExtension.Count - 1];
            return extensionFile.Substring(0, 3);
        }

        public static async Task<string> GetFileFormDataUpload(IFormFile file)
        {
            using (var sr = new StreamReader(file.OpenReadStream()))
            {
                var content = await sr.ReadToEndAsync();
                return content;
            }
        }
        public static string NormalizePath(string filePath)
        {
            if (string.IsNullOrWhiteSpace(filePath))
            {
                throw new ArgumentException("The file path cannot be null or empty.", nameof(filePath));
            }

            // Obtém o caminho completo e normalizado
            string fullPath = Path.GetFullPath(filePath);

            // Normaliza os separadores de diretório para o formato do sistema operacional atual
            string normalizedPath = fullPath.Replace(Path.AltDirectorySeparatorChar, Path.DirectorySeparatorChar);

            return normalizedPath;
        }

        public static async Task<string> GetFileByRequest(HttpRequest request, string folderNameDestination)
        {
            var file = request.Form.Files[0];
            var pathToSave = Path.Combine(Directory.GetCurrentDirectory(), folderNameDestination);
            if (file.Length > 0)
            {
                var contentDisposition = ContentDispositionHeaderValue.Parse(file.ContentDisposition);
                var fileName = contentDisposition.FileName;
                if (fileName == null)
                {
                    throw new AppWarningException("GetFileByRequest FileName cannot be null.");
                }
                fileName = fileName.Trim('"');
                var fullPath = Path.Combine(pathToSave, fileName);
                var dbPath = Path.Combine(folderNameDestination, fileName);

                using (var stream = new FileStream(fullPath, FileMode.Create))
                {
                    await file.CopyToAsync(stream);
                }
                return dbPath;
            }

            return string.Empty;
        }


        public static string GetFileFromBase64String(string dataStringBase64)
        {
            if (!string.IsNullOrEmpty(dataStringBase64) && dataStringBase64.Length > 0)
            {
                var bytes = Convert.FromBase64String(dataStringBase64);
                var decodedString = Encoding.UTF8.GetString(bytes);

                return decodedString;
            }
            return string.Empty;
        }

        public static async Task GetFromByteSaveTemp(byte[] filedata, string fileName, IConfiguration configuration)
        {
            if (filedata != null)
            {
                var content = new System.IO.MemoryStream(filedata);

                var path = Path.Combine(DirectoryHelper.GetDiretoryTemp(configuration), fileName);

                await copyStream(content, path);
            }
        }

        private static async Task copyStream(MemoryStream stream, string downloadPath)
        {
            using (var fileStream = new FileStream(downloadPath, FileMode.Create, FileAccess.Write))
            {
                await stream.CopyToAsync(fileStream);
            }
        }
        public static async Task<byte[]> GetByteDataFromIFormFile(IFormFile fileData)
        {
            byte[] fileDataResult;

            using (var stream = new MemoryStream())
            {
                await fileData.CopyToAsync(stream);
                fileDataResult = stream.ToArray();
            }
            return fileDataResult;
        }

        public static void CreateDiretory(string diretorioTemp)
        {
            if (!Directory.Exists(diretorioTemp))
            {
                Directory.CreateDirectory(diretorioTemp);
            }
        }

        public static string GetContentType(string filePath)
        {
            var provider = new FileExtensionContentTypeProvider();
            string? contentType;
            if (!provider.TryGetContentType(filePath, out contentType))
            {
                contentType = "application/octet-stream";
            }
            return contentType;
        }

        public static string GetFilePath(string folderOrigin, string fileName)
        {
            if (Path.IsPathFullyQualified(folderOrigin))
            {
                return Path.Combine(folderOrigin, fileName);
            }
            else
            {
                return Path.Combine(Directory.GetCurrentDirectory(), folderOrigin, fileName);
            }
        }

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
            using (var fileStream = File.OpenRead(filePath))
            {
                var contentType = GetContentType(filePath);
                var fileBytes = new byte[fileStream.Length];
                int bytesRead = fileStream.Read(fileBytes, 0, (int)fileStream.Length);

                if (bytesRead != fileStream.Length)
                {
                    throw new IOException("Could not read the entire file.");
                }
                var response = new FileContentResult(fileBytes, contentType)
                {
                    LastModified = DateHelper.GetDateTimeNowFromUtc(),
                    FileDownloadName = GetSameName(filePath),
                };
                return response;
            }
        }

        public static async Task CopyFile(string pathSource, string pathDestination)
        {
            if (!File.Exists(pathSource))
            {
                throw new FileNotFoundException("The source file was not found.", pathSource);
            }
            using (FileStream sourceStream = new FileStream(pathSource, FileMode.Open, FileAccess.Read))
            using (FileStream destinationStream = new FileStream(pathDestination, FileMode.Create, FileAccess.Write))
            {
                await sourceStream.CopyToAsync(destinationStream);
            }
        }

        public static async Task Delete(string pathFile)
        {
            if (File.Exists(pathFile))
            {
                await Task.Run(() => File.Delete(pathFile));
            }
            else
            {
                throw new FileNotFoundException("File was not found", pathFile);
            }
        }
    }
}
