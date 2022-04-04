
namespace Lab1OOP
{
    partial class WelcomeForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.AuthorizationButton = new System.Windows.Forms.Button();
            this.RegistrationButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // AuthorizationButton
            // 
            this.AuthorizationButton.Location = new System.Drawing.Point(98, 48);
            this.AuthorizationButton.Name = "AuthorizationButton";
            this.AuthorizationButton.Size = new System.Drawing.Size(242, 46);
            this.AuthorizationButton.TabIndex = 0;
            this.AuthorizationButton.Text = "Authorization";
            this.AuthorizationButton.UseVisualStyleBackColor = true;
            this.AuthorizationButton.Click += new System.EventHandler(this.AuthorizationButton_Click);
            // 
            // RegistrationButton
            // 
            this.RegistrationButton.Location = new System.Drawing.Point(98, 135);
            this.RegistrationButton.Name = "RegistrationButton";
            this.RegistrationButton.Size = new System.Drawing.Size(242, 46);
            this.RegistrationButton.TabIndex = 1;
            this.RegistrationButton.Text = "Registration";
            this.RegistrationButton.UseVisualStyleBackColor = true;
            this.RegistrationButton.Click += new System.EventHandler(this.RegistrationButton_Click);
            // 
            // WelcomeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(432, 243);
            this.Controls.Add(this.RegistrationButton);
            this.Controls.Add(this.AuthorizationButton);
            this.Name = "WelcomeForm";
            this.Text = "FinancialSystemManagement";
            this.Load += new System.EventHandler(this.WelcomeForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button AuthorizationButton;
        private System.Windows.Forms.Button RegistrationButton;
    }
}

