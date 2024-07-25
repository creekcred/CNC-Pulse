using System;
using System.IO;
using System.Threading.Tasks;

namespace CNCPulse.Core
{
    public class FileManager
    {
        private readonly string baseDirectory;

        public FileManager(string baseDirectory)
        {
            this.baseDirectory = baseDirectory;
            Directory.CreateDirectory(baseDirectory);
        }

        public async Task<string> SaveFileAsync(string fileName, Stream fileStream)
        {
            string filePath = Path.Combine(baseDirectory, fileName);
            using (var fileStreamWriter = new FileStream(filePath, FileMode.Create))
            {
                await fileStream.CopyToAsync(fileStreamWriter);
            }
            return filePath;
        }

        public async Task<Stream> GetFileStreamAsync(string fileName)
        {
            string filePath = Path.Combine(baseDirectory, fileName);
            if (!File.Exists(filePath))
            {
                throw new FileNotFoundException($"File not found: {fileName}");
            }
            return new FileStream(filePath, FileMode.Open, FileAccess.Read);
        }

        public bool DeleteFile(string fileName)
        {
            string filePath = Path.Combine(baseDirectory, fileName);
            if (File.Exists(filePath))
            {
                File.Delete(filePath);
                return true;
            }
            return false;
        }
    }
}
