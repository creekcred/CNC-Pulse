using System.IO;
using Newtonsoft.Json;

namespace CNCPulse.Utils
{
    public static class ConfigManager
    {
        private const string ConfigFilePath = "config.json";

        public static AppConfig LoadConfig()
        {
            if (File.Exists(ConfigFilePath))
            {
                string json = File.ReadAllText(ConfigFilePath);
                return JsonConvert.DeserializeObject<AppConfig>(json);
            }
            return new AppConfig();
        }

        public static void SaveConfig(AppConfig config)
        {
            string json = JsonConvert.SerializeObject(config, Formatting.Indented);
            File.WriteAllText(ConfigFilePath, json);
        }
    }

    public class AppConfig
    {
        public string DefaultCompany { get; set; }
        public string Log
