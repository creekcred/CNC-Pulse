using System;
using System.IO;
using System.Net;
using System.Threading.Tasks;

namespace CNCPulse.Integration
{
    public class ServerConnector
    {
        private readonly string serverUrl;
        private readonly NetworkCredential credentials;

        public ServerConnector(string url, string username, string password)
        {
            serverUrl = url;
            credentials = new NetworkCredential(username, password);
        }

        public async Task<bool> UploadFileAsync(string localFilePath, string remoteFilePath)
        {
            using (WebClient client = new WebClient())
            {
                client.Credentials = credentials;
                try
                {
                    await client.UploadFileTaskAsync(new Uri($"{serverUrl}/{remoteFilePath}"), localFilePath);
                    return true;
                }
                catch (Exception ex)
                {
                    Logger.Log($"Error uploading file: {ex.Message}");
                    return false;
                }
            }
        }

        public async Task<bool> DownloadFileAsync(string remoteFilePath, string localFilePath)
        {
            using (WebClient client = new WebClient())
            {
                client.Credentials = credentials;
                try
                {
                    await client.DownloadFileTaskAsync(new Uri($"{serverUrl}/{remoteFilePath}"), localFilePath);
                    return true;
                }
                catch (Exception ex)
                {
                    Logger.Log($"Error downloading file: {ex.Message}");
                    return false;
                }
            }
        }
    }
}
