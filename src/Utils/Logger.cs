using System;
using System.IO;

namespace CNCPulse.Utils
{
    public static class Logger
    {
        private static readonly string LogFilePath = "log.txt";

        public static void Log(string message)
        {
            string logMessage = $"{DateTime.Now}: {message}";
            File.AppendAllText(LogFilePath, logMessage + Environment.NewLine);
        }
    }
}
