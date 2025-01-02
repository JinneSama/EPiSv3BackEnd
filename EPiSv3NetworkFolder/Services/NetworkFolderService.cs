using System.Net;
using EPiSv3NetworkFolder.Helpers;
using EPiSv3NetworkFolder.Models;

namespace EPiSv3NetworkFolder.Services
{
    public class NetworkFolderService
    {
        private const string NetworkPath = @"\\172.17.16.244\ICTv2_Repositories\ICTv3Documents";
        //private const string NetworkPath = @"\\172.17.32.1\myfiles";
        private const string Username = "pitd.jsilao";
        private const string Password = "WcZLRX";

        public NetworkFolderService()
        {
            ConnectToNetworkFolder();
        }

        private void ConnectToNetworkFolder()
        {
            var credentials = new NetworkCredential(Username, Password);
            using (var networkConnection = new NetworkConnection(NetworkPath, credentials))
            {
                // Connection established
            }
        }

        public string[] GetFileList()
        {
            try
            {
                return Directory.GetFiles(NetworkPath);
            }
            catch (Exception ex)
            {
                throw new Exception($"Failed to list files: {ex.Message}");
            }
        }

        public FileOperationResult GetFile(string fileName)
        {
            try
            {
                string filePath = Path.Combine(NetworkPath, fileName);
                if (!File.Exists(filePath)) return null;

                var fileBytes = File.ReadAllBytes(filePath);
                return new FileOperationResult { FileName = fileName, FileBytes = fileBytes };
            }
            catch (Exception ex)
            {
                throw new Exception($"Failed to get file: {ex.Message}");
            }
        }

        public void UploadFile(IFormFile file)
        {
            try
            {
                string filePath = Path.Combine(NetworkPath, file.FileName);
                using (var stream = new FileStream(filePath, FileMode.Create))
                {
                    file.CopyTo(stream);
                }
            }
            catch (Exception ex)
            {
                throw new Exception($"Failed to upload file: {ex.Message}");
            }
        }
        public string GetNetworkFolderPath()
        {
            return NetworkPath;
        }
    }
}
