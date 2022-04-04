
namespace Lab1OOP
{
    partial class CreditandInstallmentForm
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
            this.MyCreditsButton = new System.Windows.Forms.Button();
            this.MyInstallmentsButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.BankBox1 = new System.Windows.Forms.ComboBox();
            this.AmountBox1 = new System.Windows.Forms.TextBox();
            this.BackButton = new System.Windows.Forms.Button();
            this.MonthsBox1 = new System.Windows.Forms.ComboBox();
            this.BankBox2 = new System.Windows.Forms.ComboBox();
            this.MonthsBox2 = new System.Windows.Forms.ComboBox();
            this.AmountBox2 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.ConfirmButton1 = new System.Windows.Forms.Button();
            this.ConfirmButton2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // InfoRichBox
            // 
            this.InfoRichBox.Location = new System.Drawing.Point(105, 68);
            this.InfoRichBox.Name = "InfoRichBox";
            this.InfoRichBox.Size = new System.Drawing.Size(320, 265);
            this.InfoRichBox.TabIndex = 0;
            this.InfoRichBox.Text = "";
            // 
            // MyCreditsButton
            // 
            this.MyCreditsButton.Location = new System.Drawing.Point(105, 339);
            this.MyCreditsButton.Name = "MyCreditsButton";
            this.MyCreditsButton.Size = new System.Drawing.Size(157, 53);
            this.MyCreditsButton.TabIndex = 1;
            this.MyCreditsButton.Text = "MyCredits";
            this.MyCreditsButton.UseVisualStyleBackColor = true;
            this.MyCreditsButton.Click += new System.EventHandler(this.MyCreditsButton_Click);
            // 
            // MyInstallmentsButton
            // 
            this.MyInstallmentsButton.Location = new System.Drawing.Point(268, 339);
            this.MyInstallmentsButton.Name = "MyInstallmentsButton";
            this.MyInstallmentsButton.Size = new System.Drawing.Size(157, 53);
            this.MyInstallmentsButton.TabIndex = 2;
            this.MyInstallmentsButton.Text = "MyInstallments";
            this.MyInstallmentsButton.UseVisualStyleBackColor = true;
            this.MyInstallmentsButton.Click += new System.EventHandler(this.MyInstallmentsButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(523, 68);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "TakeCredit";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(735, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(122, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "TakeInstallment";
            // 
            // BankBox1
            // 
            this.BankBox1.FormattingEnabled = true;
            this.BankBox1.Location = new System.Drawing.Point(471, 147);
            this.BankBox1.Name = "BankBox1";
            this.BankBox1.Size = new System.Drawing.Size(199, 28);
            this.BankBox1.TabIndex = 5;
            // 
            // AmountBox1
            // 
            this.AmountBox1.Location = new System.Drawing.Point(471, 280);
            this.AmountBox1.Name = "AmountBox1";
            this.AmountBox1.Size = new System.Drawing.Size(199, 26);
            this.AmountBox1.TabIndex = 9;
            this.AmountBox1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.AmountBox1_KeyPress);
            // 
            // BackButton
            // 
            this.BackButton.Location = new System.Drawing.Point(12, 12);
            this.BackButton.Name = "BackButton";
            this.BackButton.Size = new System.Drawing.Size(81, 31);
            this.BackButton.TabIndex = 21;
            this.BackButton.Text = "Back";
            this.BackButton.UseVisualStyleBackColor = true;
            this.BackButton.Click += new System.EventHandler(this.BackButton_Click);
            // 
            // MonthsBox1
            // 
            this.MonthsBox1.FormattingEnabled = true;
            this.MonthsBox1.Location = new System.Drawing.Point(471, 215);
            this.MonthsBox1.Name = "MonthsBox1";
            this.MonthsBox1.Size = new System.Drawing.Size(199, 28);
            this.MonthsBox1.TabIndex = 22;
            // 
            // BankBox2
            // 
            this.BankBox2.FormattingEnabled = true;
            this.BankBox2.Location = new System.Drawing.Point(697, 147);
            this.BankBox2.Name = "BankBox2";
            this.BankBox2.Size = new System.Drawing.Size(199, 28);
            this.BankBox2.TabIndex = 23;
            // 
            // MonthsBox2
            // 
            this.MonthsBox2.FormattingEnabled = true;
            this.MonthsBox2.Location = new System.Drawing.Point(697, 215);
            this.MonthsBox2.Name = "MonthsBox2";
            this.MonthsBox2.Size = new System.Drawing.Size(199, 28);
            this.MonthsBox2.TabIndex = 24;
            // 
            // AmountBox2
            // 
            this.AmountBox2.Location = new System.Drawing.Point(697, 280);
            this.AmountBox2.Name = "AmountBox2";
            this.AmountBox2.Size = new System.Drawing.Size(199, 26);
            this.AmountBox2.TabIndex = 25;
            this.AmountBox2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.AmountBox2_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(536, 124);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 20);
            this.label3.TabIndex = 26;
            this.label3.Text = "Bank";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(774, 124);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 20);
            this.label4.TabIndex = 27;
            this.label4.Text = "Bank";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(536, 189);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(62, 20);
            this.label5.TabIndex = 28;
            this.label5.Text = "Months";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(774, 189);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(62, 20);
            this.label6.TabIndex = 29;
            this.label6.Text = "Months";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(533, 257);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(65, 20);
            this.label7.TabIndex = 30;
            this.label7.Text = "Amount";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(774, 257);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(65, 20);
            this.label8.TabIndex = 31;
            this.label8.Text = "Amount";
            // 
            // ConfirmButton1
            // 
            this.ConfirmButton1.Location = new System.Drawing.Point(509, 339);
            this.ConfirmButton1.Name = "ConfirmButton1";
            this.ConfirmButton1.Size = new System.Drawing.Size(118, 39);
            this.ConfirmButton1.TabIndex = 32;
            this.ConfirmButton1.Text = "Confirm";
            this.ConfirmButton1.UseVisualStyleBackColor = true;
            this.ConfirmButton1.Click += new System.EventHandler(this.ConfirmButton1_Click);
            // 
            // ConfirmButton2
            // 
            this.ConfirmButton2.Location = new System.Drawing.Point(739, 339);
            this.ConfirmButton2.Name = "ConfirmButton2";
            this.ConfirmButton2.Size = new System.Drawing.Size(118, 39);
            this.ConfirmButton2.TabIndex = 33;
            this.ConfirmButton2.Text = "Confirm";
            this.ConfirmButton2.UseVisualStyleBackColor = true;
            this.ConfirmButton2.Click += new System.EventHandler(this.ConfirmButton2_Click);
            // 
            // CreditandInstallmentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(970, 422);
            this.Controls.Add(this.ConfirmButton2);
            this.Controls.Add(this.ConfirmButton1);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.AmountBox2);
            this.Controls.Add(this.MonthsBox2);
            this.Controls.Add(this.BankBox2);
            this.Controls.Add(this.MonthsBox1);
            this.Controls.Add(this.BackButton);
            this.Controls.Add(this.AmountBox1);
            this.Controls.Add(this.BankBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.MyInstallmentsButton);
            this.Controls.Add(this.MyCreditsButton);
            this.Controls.Add(this.InfoRichBox);
            this.Name = "CreditandInstallmentForm";
            this.Text = "CreditandInstallment";
            this.Load += new System.EventHandler(this.CreditandInstallmentForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox InfoRichBox;
        private System.Windows.Forms.Button MyCreditsButton;
        private System.Windows.Forms.Button MyInstallmentsButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox BankBox1;
        private System.Windows.Forms.TextBox AmountBox1;
        private System.Windows.Forms.Button BackButton;
        private System.Windows.Forms.ComboBox MonthsBox1;
        private System.Windows.Forms.ComboBox BankBox2;
        private System.Windows.Forms.ComboBox MonthsBox2;
        private System.Windows.Forms.TextBox AmountBox2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button ConfirmButton1;
        private System.Windows.Forms.Button ConfirmButton2;
    }
}