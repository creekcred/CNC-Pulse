using System;
using System.Collections.Generic;
using System.Windows.Forms;
using CNCPulse.Core;

namespace CNCPulse.UI
{
    public partial class QuarantineReviewForm : Form
    {
        private readonly QuarantineManager quarantineManager;
        private readonly string originalFilePath;
        private readonly string quarantinedFilePath;

        public QuarantineReviewForm(QuarantineManager quarantineManager, string originalFilePath, string quarantinedFilePath)
        {
            InitializeComponent();
            this.quarantineManager = quarantineManager;
            this.originalFilePath = originalFilePath;
            this.quarantinedFilePath = quarantinedFilePath;
            LoadDifferences();
        }

        private void LoadDifferences()
        {
            Dictionary<int, string> differences = quarantineManager.CompareFiles(originalFilePath, quarantinedFilePath);
            foreach (var diff in differences)
            {
                listBoxDifferences.Items.Add(diff.Value);
            }
        }

        private void buttonApprove_Click(object sender, EventArgs e)
        {
            quarantineManager.ApproveFile(quarantinedFilePath, originalFilePath);
            Close();
        }

        private void buttonReject_Click(object sender, EventArgs e)
        {
            quarantineManager.RejectFile(quarantinedFilePath);
            Close();
        }
    }
}
