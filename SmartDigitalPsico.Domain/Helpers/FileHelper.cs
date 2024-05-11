using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.StaticFiles;
using Microsoft.Extensions.Configuration;
using System.Net.Http.Headers;
using System.Text;

namespace SmartDigitalPsico.Domain.Helpers
{
    public class FileHelper
    {

        public static async Task<string> GetFileFormDataUpload(IFormFile file)
        {
            using (var sr = new StreamReader(file.OpenReadStream()))
            {
                var content = await sr.ReadToEndAsync();
                return content;
            }
        }


        public static async Task<string> GetFileByRequest(HttpRequest request, string folderNameDestination)
        {
            var file = request.Form.Files[0];
            var pathToSave = Path.Combine(Directory.GetCurrentDirectory(), folderNameDestination);
            if (file.Length > 0)
            {
                var fileName = ContentDispositionHeaderValue.Parse(file.ContentDisposition).FileName.Trim('"');
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


        private static async Task<string> GetFileFromBase64String(string dataStringBase64)
        {
            if (!string.IsNullOrEmpty(dataStringBase64) && dataStringBase64?.Length > 0)
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
            string contentType;
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
            string[] nameparts = fileName.Split(new char[] { '.' });
            return nameparts.First().Trim();
        }

        public static FileContentResult ProccessDownloadToBrowser(string folderOrigin, string fileName)
        {
            var filePath = FileHelper.GetFilePath(folderOrigin, fileName);
            var fileStream = System.IO.File.OpenRead(filePath);
            var contentType = FileHelper.GetContentType(filePath);
            var fileBytes = new byte[fileStream.Length];
            fileStream.Read(fileBytes, 0, (int)fileStream.Length);
            fileStream.Close();
            var response = new FileContentResult(fileBytes, contentType)
            {
                LastModified = DataHelper.GetDateTimeNow(),
                FileDownloadName = FileHelper.GetSameName(fileName),
            };
            return response;
        }
    }
}
