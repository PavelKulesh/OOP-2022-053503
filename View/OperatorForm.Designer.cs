﻿
namespace Lab1OOP
{
    partial class OperatorForm
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
            this.InfoRichBox = new System.Windows.Forms.RichTextBox();
            this.ShowProjectsButton = new System.Windows.Forms.Button();
            this.ShowLogsButton = new System.Windows.Forms.Button();
            this.SalaryProjectsBox = new System.Windows.Forms.ComboBox();
            this.ConfirmButton = new System.Windows.Forms.Button();
            this.DeclineButton = new System.Windows.Forms.Button();
            this.ShowButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.LogoutButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // InfoRichBox
            // 
            this.InfoRichBox.Location = new System.Drawing.Point(361, 9);
            this.InfoRichBox.Name = "InfoRichBox";
            this.InfoRichBox.Size = new System.Drawing.Size(271, 178);
            this.InfoRichBox.TabIndex = 0;
            this.InfoRichBox.Text = "";
            // 
            // ShowProjectsButton
            // 
            this.ShowProjectsButton.Location = new System.Drawing.Point(649, 12);
            this.ShowProjectsButton.Name = "ShowProjectsButton";
            this.ShowProjectsButton.Size = new System.Drawing.Size(140, 39);
            this.ShowProjectsButton.TabIndex = 1;
            this.ShowProjectsButton.Text = "ShowProjects";
            this.ShowProjectsButton.UseVisualStyleBackColor = true;
            this.ShowProjectsButton.Click += new System.EventHandler(this.ShowProjectsButton_Click);
            // 
            // ShowLogsButton
            // 
            this.ShowLogsButton.Location = new System.Drawing.Point(649, 148);
            this.ShowLogsButton.Name = "ShowLogsButton";
            this.ShowLogsButton.Size = new System.Drawing.Size(140, 39);
            this.ShowLogsButton.TabIndex = 2;
            this.ShowLogsButton.Text = "ShowLogs";
            this.ShowLogsButton.UseVisualStyleBackColor = true;
            this.ShowLogsButton.Click += new System.EventHandler(this.ShowLogsButton_Click);
            // 
            // SalaryProjectsBox
            // 
            this.SalaryProjectsBox.FormattingEnabled = true;
            this.SalaryProjectsBox.Location = new System.Drawing.Point(16, 103);
            this.SalaryProjectsBox.Name = "SalaryProjectsBox";
            this.SalaryProjectsBox.Size = new System.Drawing.Size(179, 28);
            this.SalaryProjectsBox.TabIndex = 3;
            // 
            // ConfirmButton
            // 
            this.ConfirmButton.Location = new System.Drawing.Point(16, 151);
            this.ConfirmButton.Name = "ConfirmButton";
            this.ConfirmButton.Size = new System.Drawing.Size(105, 36);
            this.ConfirmButton.TabIndex = 4;
            this.ConfirmButton.Text = "Confirm";
            this.ConfirmButton.UseVisualStyleBackColor = true;
            this.ConfirmButton.Click += new System.EventHandler(this.ConfirmButton_Click);
            // 
            // DeclineButton
            // 
            this.DeclineButton.Location = new System.Drawing.Point(127, 151);
            this.DeclineButton.Name = "DeclineButton";
            this.DeclineButton.Size = new System.Drawing.Size(105, 36);
            this.DeclineButton.TabIndex = 5;
            this.DeclineButton.Text = "Decline";
            this.DeclineButton.UseVisualStyleBackColor = true;
            this.DeclineButton.Click += new System.EventHandler(this.DeclineButton_Click);
            // 
            // ShowButton
            // 
            this.ShowButton.Location = new System.Drawing.Point(238, 151);
            this.ShowButton.Name = "ShowButton";
            this.ShowButton.Size = new System.Drawing.Size(105, 36);
            this.ShowButton.TabIndex = 6;
            this.ShowButton.Text = "Show";
            this.ShowButton.UseVisualStyleBackColor = true;
            this.ShowButton.Click += new System.EventHandler(this.ShowButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 70);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 20);
            this.label1.TabIndex = 7;
            this.label1.Text = "SalaryProjects";
            // 
            // LogoutButton
            // 
            this.LogoutButton.Location = new System.Drawing.Point(12, 9);
            this.LogoutButton.Name = "LogoutButton";
            this.LogoutButton.Size = new System.Drawing.Size(87, 33);
            this.LogoutButton.TabIndex = 9;
            this.LogoutButton.Text = "Logout";
            this.LogoutButton.UseVisualStyleBackColor = true;
            this.LogoutButton.Click += new System.EventHandler(this.LogoutButton_Click);
            // 
            // OperatorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(814, 214);
            this.Controls.Add(this.LogoutButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ShowButton);
            this.Controls.Add(this.DeclineButton);
            this.Controls.Add(this.ConfirmButton);
            this.Controls.Add(this.SalaryProjectsBox);
            this.Controls.Add(this.ShowLogsButton);
            this.Controls.Add(this.ShowProjectsButton);
            this.Controls.Add(this.InfoRichBox);
            this.Name = "OperatorForm";
            this.Text = "FinancialSystemManagement(Operator)";
            this.Load += new System.EventHandler(this.OperatorForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox InfoRichBox;
        private System.Windows.Forms.Button ShowProjectsButton;
        private System.Windows.Forms.Button ShowLogsButton;
        private System.Windows.Forms.ComboBox SalaryProjectsBox;
        private System.Windows.Forms.Button ConfirmButton;
        private System.Windows.Forms.Button DeclineButton;
        private System.Windows.Forms.Button ShowButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button LogoutButton;
    }
}