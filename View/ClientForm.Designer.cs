
namespace Lab1OOP
{
    partial class ClientForm
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
            this.BankAccountsButton = new System.Windows.Forms.Button();
            this.CreditsInstallmentsButton = new System.Windows.Forms.Button();
            this.SalaryProjectButton = new System.Windows.Forms.Button();
            this.LogoutButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BankAccountsButton
            // 
            this.BankAccountsButton.Location = new System.Drawing.Point(78, 68);
            this.BankAccountsButton.Name = "BankAccountsButton";
            this.BankAccountsButton.Size = new System.Drawing.Size(176, 71);
            this.BankAccountsButton.TabIndex = 0;
            this.BankAccountsButton.Text = "Bank Accounts";
            this.BankAccountsButton.UseVisualStyleBackColor = true;
            this.BankAccountsButton.Click += new System.EventHandler(this.BankAccountsButton_Click);
            // 
            // CreditsInstallmentsButton
            // 
            this.CreditsInstallmentsButton.Location = new System.Drawing.Point(312, 68);
            this.CreditsInstallmentsButton.Name = "CreditsInstallmentsButton";
            this.CreditsInstallmentsButton.Size = new System.Drawing.Size(176, 71);
            this.CreditsInstallmentsButton.TabIndex = 1;
            this.CreditsInstallmentsButton.Text = "Credits and Installments";
            this.CreditsInstallmentsButton.UseVisualStyleBackColor = true;
            this.CreditsInstallmentsButton.Click += new System.EventHandler(this.CreditsInstallmentsButton_Click);
            // 
            // SalaryProjectButton
            // 
            this.SalaryProjectButton.Location = new System.Drawing.Point(531, 68);
            this.SalaryProjectButton.Name = "SalaryProjectButton";
            this.SalaryProjectButton.Size = new System.Drawing.Size(176, 71);
            this.SalaryProjectButton.TabIndex = 2;
            this.SalaryProjectButton.Text = "Salary Project";
            this.SalaryProjectButton.UseVisualStyleBackColor = true;
            this.SalaryProjectButton.Click += new System.EventHandler(this.SalaryProjectButton_Click);
            // 
            // LogoutButton
            // 
            this.LogoutButton.Location = new System.Drawing.Point(12, 12);
            this.LogoutButton.Name = "LogoutButton";
            this.LogoutButton.Size = new System.Drawing.Size(87, 33);
            this.LogoutButton.TabIndex = 3;
            this.LogoutButton.Text = "Logout";
            this.LogoutButton.UseVisualStyleBackColor = true;
            this.LogoutButton.Click += new System.EventHandler(this.LogoutButton_Click);
            // 
            // ClientForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 188);
            this.Controls.Add(this.LogoutButton);
            this.Controls.Add(this.SalaryProjectButton);
            this.Controls.Add(this.CreditsInstallmentsButton);
            this.Controls.Add(this.BankAccountsButton);
            this.Name = "ClientForm";
            this.Text = "FinancialSystemManagement";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BankAccountsButton;
        private System.Windows.Forms.Button CreditsInstallmentsButton;
        private System.Windows.Forms.Button SalaryProjectButton;
        private System.Windows.Forms.Button LogoutButton;
    }
}