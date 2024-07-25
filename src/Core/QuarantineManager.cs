using System;
using System.Collections.Generic;
using System.IO;
using CNCPulse.Utils;

namespace CNCPulse.Core
{
    public class QuarantineManager
    {
        private readonly string quarantineFolder;
        private readonly FileComparer fileComparer;

        public QuarantineManager(string quarantineFolder)
        {
            this.quarantineFolder = quarantineFolder;
            this.fileComparer = new FileComparer();
            Directory.CreateDirectory(quarantineFolder);
        }

        public string QuarantineFile(string originalFilePath, string uploadedFilePath)
        {
            string fileName = Path.GetFileName(uploadedFilePath);
            string quarantineFilePath = Path.Combine(quarantineFolder, fileName);
            File.Copy(uploadedFilePath, quarantineFilePath, true);
            return quarantineFilePath;
        }

        public List<string> GetQuarantinedFiles()
        {
            return new List<string>(Directory.GetFiles(quarantineFolder));
        }

        public Dictionary<int, string> CompareFiles(string originalFilePath, string quarantinedFilePath)
        {
            return fileComparer.CompareFiles(originalFilePath, quarantinedFilePath);
        }

        public void ApproveFile(string quarantinedFilePath, string destinationPath)
        {
            File.Move(quarantinedFilePath, destinationPath, true);
        }

        public void RejectFile(string quarantinedFilePath)
        {
            File.Delete(quarantinedFilePath);
        }
    }
}
