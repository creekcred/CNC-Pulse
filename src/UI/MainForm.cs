using System;
using System.Windows.Forms;
using CNCPulse.Core;
using CNCPulse.Integration;
using CNCPulse.Utils;

namespace CNCPulse.UI
{
    public partial class MainForm : Form
    {
        private readonly BrandingManager brandingManager;
        private readonly DataCollector dataCollector;
        private readonly DashboardManager dashboardManager;
        private readonly ServerConnector serverConnector;
        private readonly QuarantineManager quarantineManager;
        private readonly ChatGPTConnector chatGPTConnector;
        private readonly PerplexityConnector perplexityConnector;
        private AppConfig config;

        public MainForm()
        {
            InitializeComponent();
            config = ConfigManager.LoadConfig();

            if (!config.IsInitialized)
            {
                PerformInitialSetup();
            }

            InitializeComponents();
        }

        private void PerformInitialSetup()
        {
            using (var setupForm = new InitialSetupForm(config))
            {
                if (setupForm.ShowDialog() == DialogResult.OK)
                {
                    config = setupForm.UpdatedConfig;
                    config.IsInitialized = true;
                    ConfigManager.SaveConfig(config);
                }
                else
                {
                    MessageBox.Show("Initial setup is required to use the application.", "Setup Required", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    Application.Exit();
                }
            }
        }

        private void InitializeComponents()
        {
            brandingManager = new BrandingManager();
            dataCollector = new DataCollector();
            dashboardManager = new DashboardManager(brandingManager);
            serverConnector = new ServerConnector(config.ServerSettings.Url, config.ServerSettings.Username, config.ServerSettings.Password);
            quarantineManager = new QuarantineManager(config.QuarantineFolder);
            chatGPTConnector = new ChatGPTConnector(config.OpenAISettings.ApiKey);
            perplexityConnector = new PerplexityConnector(config.PerplexitySettings.ApiKey);
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            brandingManager.ApplyBranding(config.Branding.CompanyName);
        }

        // ... (other methods remain the same)
    }
}
