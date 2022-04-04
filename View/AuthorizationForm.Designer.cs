
namespace Lab1OOP
{
    partial class AuthorizationForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.LoginBox = new System.Windows.Forms.TextBox();
            this.PasswordBox = new System.Windows.Forms.TextBox();
            this.ConfirmAuthButton = new System.Windows.Forms.Button();
            this.BackButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(91, 73);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Login";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(91, 114);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Password";
            // 
            // LoginBox
            // 
            this.LoginBox.Location = new System.Drawing.Point(176, 70);
            this.LoginBox.Name = "LoginBox";
            this.LoginBox.Size = new System.Drawing.Size(212, 26);
            this.LoginBox.TabIndex = 2;
            // 
            // PasswordBox
            // 
            this.PasswordBox.Location = new System.Drawing.Point(176, 114);
            this.PasswordBox.Name = "PasswordBox";
            this.PasswordBox.Size = new System.Drawing.Size(212, 26);
            this.PasswordBox.TabIndex = 3;
            // 
            // ConfirmAuthButton
            // 
            this.ConfirmAuthButton.Location = new System.Drawing.Point(165, 174);
            this.ConfirmAuthButton.Name = "ConfirmAuthButton";
            this.ConfirmAuthButton.Size = new System.Drawing.Size(162, 54);
            this.ConfirmAuthButton.TabIndex = 4;
            this.ConfirmAuthButton.Text = "Confirm";
            this.ConfirmAuthButton.UseVisualStyleBackColor = true;
            this.ConfirmAuthButton.Click += new System.EventHandler(this.ConfirmAuthButton_Click);
            // 
            // BackButton
            // 
            this.BackButton.Location = new System.Drawing.Point(12, 12);
            this.BackButton.Name = "BackButton";
            this.BackButton.Size = new System.Drawing.Size(82, 29);
            this.BackButton.TabIndex = 5;
            this.BackButton.Text = "Back";
            this.BackButton.UseVisualStyleBackColor = true;
            this.BackButton.Click += new System.EventHandler(this.BackButton_Click);
            // 
            // AuthorizationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(460, 262);
            this.Controls.Add(this.BackButton);
            this.Controls.Add(this.ConfirmAuthButton);
            this.Controls.Add(this.PasswordBox);
            this.Controls.Add(this.LoginBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "AuthorizationForm";
            this.Text = "Authorization";
            this.Load += new System.EventHandler(this.AuthorizationForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox LoginBox;
        private System.Windows.Forms.TextBox PasswordBox;
        private System.Windows.Forms.Button ConfirmAuthButton;
        private System.Windows.Forms.Button BackButton;
    }
}