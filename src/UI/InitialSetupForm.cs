using System;
using System.Windows.Forms;
using CNCPulse.Utils;

namespace CNCPulse.UI
{
    public partial class InitialSetupForm : Form
    {
        public AppConfig UpdatedConfig { get; private set; }

        public InitialSetupForm(AppConfig config)
        {
            InitializeComponent();
            UpdatedConfig = config;
        }

        private void InitialSetupForm_Load(object sender, EventArgs e)
        {
            textBoxCompanyName.Text = UpdatedConfig.Branding.CompanyName;
            textBoxServerUrl.Text = UpdatedConfig.ServerSettings.Url;
            textBoxServerUsername.Text = UpdatedConfig.ServerSettings.Username;
            textBoxServerPassword.Text = UpdatedConfig.ServerSettings.Password;
            // Add more fields as needed
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            UpdatedConfig.Branding.CompanyName = textBoxCompanyName.Text;
            UpdatedConfig.ServerSettings.Url = textBoxServerUrl.Text;
            UpdatedConfig.ServerSettings.Username = textBoxServerUsername.Text;
            UpdatedConfig.ServerSettings.Password = textBoxServerPassword.Text;
            // Update more fields as needed

            DialogResult = DialogResult.OK;
            Close();
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }
    }
}
