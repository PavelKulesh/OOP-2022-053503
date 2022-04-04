
namespace Lab1OOP
{
    partial class AccountForm
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
            this.BanksBox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.BackButton = new System.Windows.Forms.Button();
            this.AmountBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.OpenButton = new System.Windows.Forms.Button();
            this.AccountBox = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.InteractionButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BanksBox
            // 
            this.BanksBox.FormattingEnabled = true;
            this.BanksBox.Location = new System.Drawing.Point(94, 63);
            this.BanksBox.Name = "BanksBox";
            this.BanksBox.Size = new System.Drawing.Size(200, 28);
            this.BanksBox.TabIndex = 1;
            this.BanksBox.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 66);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Bank";
            // 
            // BackButton
            // 
            this.BackButton.Location = new System.Drawing.Point(12, 12);
            this.BackButton.Name = "BackButton";
            this.BackButton.Size = new System.Drawing.Size(81, 31);
            this.BackButton.TabIndex = 20;
            this.BackButton.Text = "Back";
            this.BackButton.UseVisualStyleBackColor = true;
            this.BackButton.Click += new System.EventHandler(this.BackButton_Click);
            // 
            // AmountBox
            // 
            this.AmountBox.Location = new System.Drawing.Point(94, 114);
            this.AmountBox.Name = "AmountBox";
            this.AmountBox.Size = new System.Drawing.Size(200, 26);
            this.AmountBox.TabIndex = 21;
            this.AmountBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.AmountBox_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 117);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 20);
            this.label2.TabIndex = 22;
            this.label2.Text = "Amount";
            // 
            // OpenButton
            // 
            this.OpenButton.Location = new System.Drawing.Point(16, 163);
            this.OpenButton.Name = "OpenButton";
            this.OpenButton.Size = new System.Drawing.Size(267, 35);
            this.OpenButton.TabIndex = 23;
            this.OpenButton.Text = "Open";
            this.OpenButton.UseVisualStyleBackColor = true;
            this.OpenButton.Click += new System.EventHandler(this.OpenButton_Click);
            // 
            // AccountBox
            // 
            this.AccountBox.FormattingEnabled = true;
            this.AccountBox.Location = new System.Drawing.Point(486, 60);
            this.AccountBox.Name = "AccountBox";
            this.AccountBox.Size = new System.Drawing.Size(200, 28);
            this.AccountBox.TabIndex = 24;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(404, 63);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 20);
            this.label3.TabIndex = 25;
            this.label3.Text = "Account";
            // 
            // InteractionButton
            // 
            this.InteractionButton.Location = new System.Drawing.Point(408, 109);
            this.InteractionButton.Name = "InteractionButton";
            this.InteractionButton.Size = new System.Drawing.Size(282, 37);
            this.InteractionButton.TabIndex = 26;
            this.InteractionButton.Text = "Interaction";
            this.InteractionButton.UseVisualStyleBackColor = true;
            this.InteractionButton.Click += new System.EventHandler(this.InteractionButton_Click);
            // 
            // AccountForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 209);
            this.Controls.Add(this.InteractionButton);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.AccountBox);
            this.Controls.Add(this.OpenButton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.AmountBox);
            this.Controls.Add(this.BackButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BanksBox);
            this.Name = "AccountForm";
            this.Text = "BankAccounts";
            this.Load += new System.EventHandler(this.Account_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ComboBox BanksBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BackButton;
        private System.Windows.Forms.TextBox AmountBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button OpenButton;
        private System.Windows.Forms.ComboBox AccountBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button InteractionButton;
    }
}