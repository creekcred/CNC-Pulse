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

        public MainForm()
        {
            InitializeComponent();
            var config = ConfigManager.LoadConfig();
            
            brandingManager = new BrandingManager();
            dataCollector = new DataCollector();
            dashboardManager = new DashboardManager(brandingManager);
            serverConnector = new ServerConnector(config.ServerUrl, config.ServerUsername, config.ServerPassword);
            quarantineManager = new QuarantineManager(config.QuarantineFolder);
            chatGPTConnector = new ChatGPTConnector(config.OpenAIApiKey);
            perplexityConnector = new PerplexityConnector(config.PerplexityApiKey);
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            brandingManager.ApplyBranding("DefaultCompany");
        }

        private async void buttonUploadFile_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    string localFilePath = openFileDialog.FileName;
                    string remoteFilePath = "uploaded/" + System.IO.Path.GetFileName(localFilePath);
                    string quarantinedFilePath = quarantineManager.QuarantineFile(remoteFilePath, localFilePath);
                    
                    if (await serverConnector.UploadFileAsync(quarantinedFilePath, remoteFilePath))
                    {
                        MessageBox.Show("File uploaded and quarantined successfully.");
                    }
                    else
                    {
                        MessageBox.Show("Error uploading file.");
                    }
                }
            }
        }

        private void buttonReviewQuarantined_Click(object sender, EventArgs e)
        {
            var quarantinedFiles = quarantineManager.GetQuarantinedFiles();
            if (quarantinedFiles.Count > 0)
            {
                string selectedFile = quarantinedFiles[0]; // For simplicity, we're just taking the first file
                string originalFilePath = "path/to/original/file"; // You need to implement a way to get the original file path
                var reviewForm = new QuarantineReviewForm(quarantineManager, originalFilePath, selectedFile);
                reviewForm.ShowDialog();
            }
            else
            {
                MessageBox.Show("No files in quarantine.");
            }
        }

        private async void buttonAskAI_Click(object sender, EventArgs e)
        {
            string prompt = textBoxAIPrompt.Text;
            try
            {
                string chatGPTResponse = await chatGPTConnector.GetChatResponse(prompt);
                string perplexityResponse = await perplexityConnector.GetChatResponse(prompt);

                richTextBoxAIResponse.Text = $"ChatGPT: {chatGPTResponse}\n\nPerplexity: {perplexityResponse}";
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error querying AI: {ex.Message}");
            }
        }
    }
}
