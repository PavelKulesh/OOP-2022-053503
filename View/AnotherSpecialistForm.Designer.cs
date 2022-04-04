
namespace Lab1OOP
{
    partial class AnotherSpecialistForm
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
            this.SumBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.TakeSalaryProjectButton = new System.Windows.Forms.Button();
            this.FromBox = new System.Windows.Forms.ComboBox();
            this.ToBox = new System.Windows.Forms.ComboBox();
            this.SumBox1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.TransferButton = new System.Windows.Forms.Button();
            this.InfoRichBox = new System.Windows.Forms.RichTextBox();
            this.ClearButton = new System.Windows.Forms.Button();
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
            // SumBox
            // 
            this.SumBox.Location = new System.Drawing.Point(81, 80);
            this.SumBox.Name = "SumBox";
            this.SumBox.Size = new System.Drawing.Size(154, 26);
            this.SumBox.TabIndex = 5;
            this.SumBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.SumBox_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 80);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 20);
            this.label1.TabIndex = 6;
            this.label1.Text = "Sum";
            // 
            // TakeSalaryProjectButton
            // 
            this.TakeSalaryProjectButton.Location = new System.Drawing.Point(36, 128);
            this.TakeSalaryProjectButton.Name = "TakeSalaryProjectButton";
            this.TakeSalaryProjectButton.Size = new System.Drawing.Size(191, 40);
            this.TakeSalaryProjectButton.TabIndex = 7;
            this.TakeSalaryProjectButton.Text = "TakeSalaryProject";
            this.TakeSalaryProjectButton.UseVisualStyleBackColor = true;
            this.TakeSalaryProjectButton.Click += new System.EventHandler(this.TakeSalaryProjectButton_Click);
            // 
            // FromBox
            // 
            this.FromBox.FormattingEnabled = true;
            this.FromBox.Location = new System.Drawing.Point(81, 207);
            this.FromBox.Name = "FromBox";
            this.FromBox.Size = new System.Drawing.Size(177, 28);
            this.FromBox.TabIndex = 8;
            this.FromBox.SelectedIndexChanged += new System.EventHandler(this.FromBox_SelectedIndexChanged_1);
            // 
            // ToBox
            // 
            this.ToBox.FormattingEnabled = true;
            this.ToBox.Location = new System.Drawing.Point(81, 257);
            this.ToBox.Name = "ToBox";
            this.ToBox.Size = new System.Drawing.Size(177, 28);
            this.ToBox.TabIndex = 9;
            this.ToBox.SelectedIndexChanged += new System.EventHandler(this.ToBox_SelectedIndexChanged_1);
            // 
            // SumBox1
            // 
            this.SumBox1.Location = new System.Drawing.Point(81, 309);
            this.SumBox1.Name = "SumBox1";
            this.SumBox1.Size = new System.Drawing.Size(177, 26);
            this.SumBox1.TabIndex = 10;
            this.SumBox1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.SumBox1_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 207);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 20);
            this.label2.TabIndex = 11;
            this.label2.Text = "From";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 260);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(27, 20);
            this.label3.TabIndex = 12;
            this.label3.Text = "To";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 309);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(42, 20);
            this.label4.TabIndex = 13;
            this.label4.Text = "Sum";
            // 
            // TransferButton
            // 
            this.TransferButton.Location = new System.Drawing.Point(81, 353);
            this.TransferButton.Name = "TransferButton";
            this.TransferButton.Size = new System.Drawing.Size(134, 45);
            this.TransferButton.TabIndex = 14;
            this.TransferButton.Text = "Transfer";
            this.TransferButton.UseVisualStyleBackColor = true;
            this.TransferButton.Click += new System.EventHandler(this.TransferButton_Click);
            // 
            // InfoRichBox
            // 
            this.InfoRichBox.Location = new System.Drawing.Point(295, 30);
            this.InfoRichBox.Name = "InfoRichBox";
            this.InfoRichBox.Size = new System.Drawing.Size(321, 305);
            this.InfoRichBox.TabIndex = 15;
            this.InfoRichBox.Text = "";
            // 
            // ClearButton
            // 
            this.ClearButton.Location = new System.Drawing.Point(409, 341);
            this.ClearButton.Name = "ClearButton";
            this.ClearButton.Size = new System.Drawing.Size(99, 33);
            this.ClearButton.TabIndex = 16;
            this.ClearButton.Text = "Clear";
            this.ClearButton.UseVisualStyleBackColor = true;
            this.ClearButton.Click += new System.EventHandler(this.ClearButton_Click);
            // 
            // AnotherSpecialistForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(637, 423);
            this.Controls.Add(this.ClearButton);
            this.Controls.Add(this.InfoRichBox);
            this.Controls.Add(this.TransferButton);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.SumBox1);
            this.Controls.Add(this.ToBox);
            this.Controls.Add(this.FromBox);
            this.Controls.Add(this.TakeSalaryProjectButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.SumBox);
            this.Controls.Add(this.LogoutButton);
            this.Name = "AnotherSpecialistForm";
            this.Text = "AnotherSpecialistForm";
            this.Load += new System.EventHandler(this.AnotherSpecialistForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button LogoutButton;
        private System.Windows.Forms.TextBox SumBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button TakeSalaryProjectButton;
        private System.Windows.Forms.ComboBox FromBox;
        private System.Windows.Forms.ComboBox ToBox;
        private System.Windows.Forms.TextBox SumBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button TransferButton;
        private System.Windows.Forms.RichTextBox InfoRichBox;
        private System.Windows.Forms.Button ClearButton;
    }
}