using System;
using System.Collections.Generic;
using System.IO;

namespace CNCPulse.Utils
{
    public class FileComparer
    {
        public Dictionary<int, string> CompareFiles(string file1Path, string file2Path)
        {
            var differences = new Dictionary<int, string>();

            try
            {
                string[] file1Lines = File.ReadAllLines(file1Path);
                string[] file2Lines = File.ReadAllLines(file2Path);

                int maxLines = Math.Max(file1Lines.Length, file2Lines.Length);

                for (int i = 0; i < maxLines; i++)
                {
                    string line1 = i < file1Lines.Length ? file1Lines[i] : "";
                    string line2 = i < file2Lines.Length ? file2Lines[i] : "";

                    if (line1 != line2)
                    {
                        differences[i] = $"Line {i + 1}:\nOriginal: {line1}\nModified: {line2}";
                    }
                }
            }
            catch (Exception ex)
            {
                Logger.Log($"Error comparing files: {ex.Message}");
                throw;
            }

            return differences;
        }

        public string GenerateDiffReport(Dictionary<int, string> differences)
        {
            var report = new System.Text.StringBuilder();
            report.AppendLine("File Comparison Report:");
            report.AppendLine("=======================");

            foreach (var diff in differences)
            {
                report.AppendLine(diff.Value);
                report.AppendLine("----------------------");
            }

            return report.ToString();
        }
    }
}
