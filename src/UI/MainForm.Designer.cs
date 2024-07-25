// src/UI/MainForm.Designer.cs
namespace CNCPulse.UI
{
    partial class MainForm
    {
        // ... (existing components)

        private System.Windows.Forms.TextBox textBoxAIPrompt;
        private System.Windows.Forms.Button buttonAskAI;
        private System.Windows.Forms.RichTextBox richTextBoxAIResponse;

        private void InitializeComponent()
        {
            // ... (existing component initializations)

            this.textBoxAIPrompt = new System.Windows.Forms.TextBox();
            this.buttonAskAI = new System.Windows.Forms.Button();
            this.richTextBoxAIResponse = new System.Windows.Forms.RichTextBox();

            // 
            // textBoxAIPrompt
            // 
            this.textBoxAIPrompt.Location = new System.Drawing.Point(12, 440);
            this.textBoxAIPrompt.Name = "textBoxAIPrompt";
            this.textBoxAIPrompt.Size = new System.Drawing.Size(200, 20);
            this.textBoxAIPrompt.TabIndex = 7;
            // 
            // buttonAskAI
            // 
            this.buttonAskAI.Location = new System.Drawing.Point(220, 438);
            this.buttonAskAI.Name = "buttonAskAI";
            this.buttonAskAI.Size = new System.Drawing.Size(100, 23);
            this.buttonAskAI.TabIndex = 8;
            this.buttonAskAI.Text = "Ask AI";
            this.buttonAskAI.UseVisualStyleBackColor = true;
            this.buttonAskAI.Click += new System.EventHandler(this.buttonAskAI_Click);
            // 
            // richTextBoxAIResponse
            // 
            this.richTextBoxAIResponse.Location = new System.Drawing.Point(12, 470);
            this.richTextBoxAIResponse.Name = "richTextBoxAIResponse";
            this.richTextBoxAIResponse.Size = new System.Drawing.Size(308, 100);
            this.richTextBoxAIResponse.TabIndex = 9;
            this.richTextBoxAIResponse.Text = "";

            // 
            // MainForm
            // 
            this.ClientSize = new System.Drawing.Size(332, 580);
            this.Controls.Add(this.richTextBoxAIResponse);
            this.Controls.Add(this.buttonAskAI);
            this.Controls.Add(this.textBoxAIPrompt);
            // ... (add other controls)
        }
    }
}
