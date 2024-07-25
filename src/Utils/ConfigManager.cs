using System.IO;
using Newtonsoft.Json;

namespace CNCPulse.Utils
{
    public static class ConfigManager
    {
        private const string ConfigFilePath = "AppSettings.json";

        public static AppConfig LoadConfig()
        {
            if (File.Exists(ConfigFilePath))
            {
                string json = File.ReadAllText(ConfigFilePath);
                return JsonConvert.DeserializeObject<AppConfig>(json);
            }
            return CreateDefaultConfig();
        }

        public static void SaveConfig(AppConfig config)
        {
            string json = JsonConvert.SerializeObject(config, Formatting.Indented);
            File.WriteAllText(ConfigFilePath, json);
        }

        private static AppConfig CreateDefaultConfig()
        {
            return new AppConfig
            {
                IsInitialized = false,
                DefaultCompany = "CNC Pulse",
                LogFilePath = "log.txt",
                MachineConfigs = new List<MachineConfig>(),
                ServerSettings = new ServerSettings(),
                QuarantineFolder = "QuarantineFolder",
                OpenAISettings = new OpenAISettings(),
                PerplexitySettings = new PerplexitySettings(),
                Branding = new BrandingSettings
                {
                    CompanyName = "CNC Pulse",
                    LogoPath = "path/to/default_logo.png"
                },
                MESSettings = new MESSettings(),
                ERPSettings = new ERPSettings()
            };
        }
    }

    public class AppConfig
    {
        public bool IsInitialized { get; set; }
        public string DefaultCompany { get; set; }
        public string LogFilePath { get; set; }
        public List<MachineConfig> MachineConfigs { get; set; }
        public ServerSettings ServerSettings { get; set; }
        public string QuarantineFolder { get; set; }
        public OpenAISettings OpenAISettings { get; set; }
        public PerplexitySettings PerplexitySettings { get; set; }
        public BrandingSettings Branding { get; set; }
        public MESSettings MESSettings { get; set; }
        public ERPSettings ERPSettings { get; set; }
    }

    // ... (other classes remain the same)
}
