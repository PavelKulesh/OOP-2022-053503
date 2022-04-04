
namespace Lab1OOP
{
    partial class SalaryProjectForm
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
            this.BackButton = new System.Windows.Forms.Button();
            this.SalaryProjectSumBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.ConfirmButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BackButton
            // 
            this.BackButton.Location = new System.Drawing.Point(12, 12);
            this.BackButton.Name = "BackButton";
            this.BackButton.Size = new System.Drawing.Size(81, 31);
            this.BackButton.TabIndex = 22;
            this.BackButton.Text = "Back";
            this.BackButton.UseVisualStyleBackColor = true;
            this.BackButton.Click += new System.EventHandler(this.BackButton_Click);
            // 
            // SalaryProjectSumBox
            // 
            this.SalaryProjectSumBox.Location = new System.Drawing.Point(248, 62);
            this.SalaryProjectSumBox.Name = "SalaryProjectSumBox";
            this.SalaryProjectSumBox.Size = new System.Drawing.Size(166, 26);
            this.SalaryProjectSumBox.TabIndex = 23;
            this.SalaryProjectSumBox.TextChanged += new System.EventHandler(this.SalaryProjectSumBox_TextChanged);
            this.SalaryProjectSumBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.SalaryProjectSumBox_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(94, 65);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(135, 20);
            this.label1.TabIndex = 24;
            this.label1.Text = "SalaryProjectSum";
            // 
            // ConfirmButton
            // 
            this.ConfirmButton.Location = new System.Drawing.Point(123, 112);
            this.ConfirmButton.Name = "ConfirmButton";
            this.ConfirmButton.Size = new System.Drawing.Size(261, 38);
            this.ConfirmButton.TabIndex = 25;
            this.ConfirmButton.Text = "Confirm";
            this.ConfirmButton.UseVisualStyleBackColor = true;
            this.ConfirmButton.Click += new System.EventHandler(this.ConfirmButton_Click);
            // 
            // SalaryProjectForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(502, 162);
            this.Controls.Add(this.ConfirmButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.SalaryProjectSumBox);
            this.Controls.Add(this.BackButton);
            this.Name = "SalaryProjectForm";
            this.Text = "SalaryProjectForm";
            this.Load += new System.EventHandler(this.SalaryProjectForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BackButton;
        private System.Windows.Forms.TextBox SalaryProjectSumBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button ConfirmButton;
    }
}