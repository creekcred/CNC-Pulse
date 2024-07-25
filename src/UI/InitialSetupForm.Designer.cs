namespace CNCPulse.UI
{
    partial class InitialSetupForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.labelCompanyName = new System.Windows.Forms.Label();
            this.textBoxCompanyName = new System.Windows.Forms.TextBox();
            this.labelServerUrl = new System.Windows.Forms.Label();
            this.textBoxServerUrl = new System.Windows.Forms.TextBox();
            this.labelServerUsername = new System.Windows.Forms.Label();
            this.textBoxServerUsername = new System.Windows.Forms.TextBox();
            this.labelServerPassword = new System.Windows.Forms.Label();
            this.textBoxServerPassword = new System.Windows.Forms.TextBox();
            this.buttonSave = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelCompanyName
            // 
            this.labelCompanyName.AutoSize = true;
            this.labelCompanyName.Location = new System.Drawing.Point(12, 15);
            this.labelCompanyName.Name = "labelCompanyName";
            this.labelCompanyName.Size = new System.Drawing.Size(82, 13);
            this.labelCompanyName.TabIndex = 0;
            this.labelCompanyName.Text = "Company Name";
            // 
            // textBoxCompanyName
            // 
            this.textBoxCompanyName.Location = new System.Drawing.Point(120, 12);
            this.textBoxCompanyName.Name = "textBoxCompanyName";
            this.textBoxCompanyName.Size = new System.Drawing.Size(200, 20);
            this.textBoxCompanyName.TabIndex = 1;
            // 
            // labelServerUrl
            // 
            this.labelServerUrl.AutoSize = true;
            this.labelServerUrl.Location = new System.Drawing.Point(12, 41);
            this.labelServerUrl.Name = "labelServerUrl";
            this.labelServerUrl.Size = new System.Drawing.Size(60, 13);
            this.labelServerUrl.TabIndex = 2;
            this.labelServerUrl.Text = "Server URL";
            // 
            // textBoxServerUrl
            // 
            this.textBoxServerUrl.Location = new System.Drawing.Point(120, 38);
            this.textBoxServerUrl.Name = "textBoxServerUrl";
            this.textBoxServerUrl.Size = new System.Drawing.Size(200, 20);
            this.textBoxServerUrl.TabIndex = 3;
            // 
            // labelServerUsername
            // 
            this.labelServerUsername.AutoSize = true;
            this.labelServerUsername.Location = new System.Drawing.Point(12, 67);
            this.labelServerUsername.Name = "labelServerUsername";
            this.labelServerUsername.Size = new System.Drawing.Size(91, 13);
            this.labelServerUsername.TabIndex = 4;
            this.labelServerUsername.Text = "Server Username";
            // 
            // textBoxServerUsername
            // 
            this.textBoxServerUsername.Location = new System.Drawing.Point(120, 64);
            this.textBoxServerUsername.Name = "textBoxServerUsername";
            this.textBoxServerUsername.Size = new System.Drawing.Size(200, 20);
            this.textBoxServerUsername.TabIndex = 5;
            // 
            // labelServerPassword
            // 
            this.labelServerPassword.AutoSize = true;
            this.labelServerPassword.Location = new System.Drawing.Point(12, 93);
            this.labelServerPassword.Name = "labelServerPassword";
            this.labelServerPassword.Size = new System.Drawing.Size(89, 13);
            this.labelServerPassword.TabIndex = 6;
            this.labelServerPassword.Text = "Server Password";
            // 
            // textBoxServerPassword
            // 
            this.textBoxServerPassword.Location = new System.Drawing.Point(120, 90);
            this.textBoxServerPassword.Name = "textBoxServerPassword";
            this.textBoxServerPassword.PasswordChar = '*';
            this.textBoxServerPassword.Size = new System.Drawing.Size(200, 20);
            this.textBoxServerPassword.TabIndex = 7;
            // 
            // buttonSave
            // 
            this.buttonSave.Location = new System.Drawing.Point(120, 120);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(75, 23);
            this.buttonSave.TabIndex = 8;
            this.buttonSave.Text = "Save";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // buttonCancel
            // 
            this.buttonCancel.Location = new System.Drawing.Point(245, 120);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(75, 23);
            this.buttonCancel.TabIndex = 9;
            this.buttonCancel.Text = "Cancel";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // InitialSetupForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(334, 161);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.textBoxServerPassword);
            this.Controls.Add(this.labelServerPassword);
            this.Controls.Add(this.textBoxServerUsername);
            this.Controls.Add(this.labelServerUsername);
            this.Controls.Add(this.textBoxServerUrl);
            this.Controls.Add(this.labelServerUrl);
            this.Controls.Add(this.textBoxCompanyName);
            this.Controls.Add(this.labelCompanyName);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "InitialSetupForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Initial Setup";
            this.Load += new System.EventHandler(this.InitialSetupForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelCompanyName;
        private System.Windows.Forms.TextBox textBoxCompanyName;
        private System.Windows.Forms.Label labelServerUrl;
        private System.Windows.Forms.TextBox textBoxServerUrl;
        private System.Windows.Forms.Label labelServerUsername;
        private System.Windows.Forms.TextBox textBoxServerUsername;
        private System.Windows.Forms.Label labelServerPassword;
        private System.Windows.Forms.TextBox textBoxServerPassword;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.Button buttonCancel;
    }
}
