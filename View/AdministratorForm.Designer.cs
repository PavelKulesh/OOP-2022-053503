
namespace Lab1OOP
{
    partial class AdministratorForm
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
            this.LogoutButton = new System.Windows.Forms.Button();
            this.LogsBox = new System.Windows.Forms.RichTextBox();
            this.ShowLogsButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // LogoutButton
            // 
            this.LogoutButton.Location = new System.Drawing.Point(12, 12);
            this.LogoutButton.Name = "LogoutButton";
            this.LogoutButton.Size = new System.Drawing.Size(87, 33);
            this.LogoutButton.TabIndex = 4;
            this.LogoutButton.Text = "Logout";
            this.LogoutButton.UseVisualStyleBackColor = true;
            this.LogoutButton.Click += new System.EventHandler(this.LogoutButton_Click);
            // 
            // LogsBox
            // 
            this.LogsBox.Location = new System.Drawing.Point(137, 15);
            this.LogsBox.Name = "LogsBox";
            this.LogsBox.Size = new System.Drawing.Size(349, 336);
            this.LogsBox.TabIndex = 5;
            this.LogsBox.Text = "";
            // 
            // ShowLogsButton
            // 
            this.ShowLogsButton.Location = new System.Drawing.Point(228, 382);
            this.ShowLogsButton.Name = "ShowLogsButton";
            this.ShowLogsButton.Size = new System.Drawing.Size(196, 56);
            this.ShowLogsButton.TabIndex = 6;
            this.ShowLogsButton.Text = "ShowLogs";
            this.ShowLogsButton.UseVisualStyleBackColor = true;
            this.ShowLogsButton.Click += new System.EventHandler(this.ShowLogsButton_Click);
            // 
            // AdministratorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(611, 451);
            this.Controls.Add(this.ShowLogsButton);
            this.Controls.Add(this.LogsBox);
            this.Controls.Add(this.LogoutButton);
            this.Name = "AdministratorForm";
            this.Text = "AdministratorForm";
            this.Load += new System.EventHandler(this.AdministratorForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button LogoutButton;
        private System.Windows.Forms.RichTextBox LogsBox;
        private System.Windows.Forms.Button ShowLogsButton;
    }
}