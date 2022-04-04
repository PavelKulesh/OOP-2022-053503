
namespace Lab1OOP
{
    partial class AccountInteractionForm
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
            this.label3 = new System.Windows.Forms.Label();
            this.BackButton = new System.Windows.Forms.Button();
            this.SaveButton = new System.Windows.Forms.Button();
            this.SaveBox = new System.Windows.Forms.TextBox();
            this.CashOutBox = new System.Windows.Forms.TextBox();
            this.CashOutButton = new System.Windows.Forms.Button();
            this.TransferSumBox = new System.Windows.Forms.TextBox();
            this.RecipientBox = new System.Windows.Forms.ComboBox();
            this.TransferButton = new System.Windows.Forms.Button();
            this.AccumulateButton = new System.Windows.Forms.Button();
            this.AccumulationSumBox = new System.Windows.Forms.TextBox();
            this.PercentBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.BlockButton = new System.Windows.Forms.Button();
            this.FreezeButton = new System.Windows.Forms.Button();
            this.AmountBox = new System.Windows.Forms.RichTextBox();
            this.AccumulationBox = new System.Windows.Forms.RichTextBox();
            this.SavingBox = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(107, 69);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Amount";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(298, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Saving";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(457, 69);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(105, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Accumulation";
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
            // SaveButton
            // 
            this.SaveButton.Location = new System.Drawing.Point(166, 201);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(87, 28);
            this.SaveButton.TabIndex = 25;
            this.SaveButton.Text = "Save";
            this.SaveButton.UseVisualStyleBackColor = true;
            this.SaveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // SaveBox
            // 
            this.SaveBox.Location = new System.Drawing.Point(139, 169);
            this.SaveBox.Name = "SaveBox";
            this.SaveBox.Size = new System.Drawing.Size(149, 26);
            this.SaveBox.TabIndex = 26;
            this.SaveBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.SaveBox_KeyPress_1);
            // 
            // CashOutBox
            // 
            this.CashOutBox.Location = new System.Drawing.Point(350, 169);
            this.CashOutBox.Name = "CashOutBox";
            this.CashOutBox.Size = new System.Drawing.Size(149, 26);
            this.CashOutBox.TabIndex = 27;
            this.CashOutBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.CashOutBox_KeyPress);
            // 
            // CashOutButton
            // 
            this.CashOutButton.Location = new System.Drawing.Point(379, 201);
            this.CashOutButton.Name = "CashOutButton";
            this.CashOutButton.Size = new System.Drawing.Size(87, 28);
            this.CashOutButton.TabIndex = 28;
            this.CashOutButton.Text = "CashOut";
            this.CashOutButton.UseVisualStyleBackColor = true;
            this.CashOutButton.Click += new System.EventHandler(this.CashOutButton_Click);
            // 
            // TransferSumBox
            // 
            this.TransferSumBox.Location = new System.Drawing.Point(142, 268);
            this.TransferSumBox.Name = "TransferSumBox";
            this.TransferSumBox.Size = new System.Drawing.Size(121, 26);
            this.TransferSumBox.TabIndex = 29;
            this.TransferSumBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TransferSumBox_KeyPress);
            // 
            // RecipientBox
            // 
            this.RecipientBox.FormattingEnabled = true;
            this.RecipientBox.Location = new System.Drawing.Point(142, 316);
            this.RecipientBox.Name = "RecipientBox";
            this.RecipientBox.Size = new System.Drawing.Size(121, 28);
            this.RecipientBox.TabIndex = 30;
            // 
            // TransferButton
            // 
            this.TransferButton.Location = new System.Drawing.Point(141, 357);
            this.TransferButton.Name = "TransferButton";
            this.TransferButton.Size = new System.Drawing.Size(121, 28);
            this.TransferButton.TabIndex = 33;
            this.TransferButton.Text = "Transfer";
            this.TransferButton.UseVisualStyleBackColor = true;
            this.TransferButton.Click += new System.EventHandler(this.TransferButton_Click);
            // 
            // AccumulateButton
            // 
            this.AccumulateButton.Location = new System.Drawing.Point(446, 357);
            this.AccumulateButton.Name = "AccumulateButton";
            this.AccumulateButton.Size = new System.Drawing.Size(121, 28);
            this.AccumulateButton.TabIndex = 34;
            this.AccumulateButton.Text = "Accumulate";
            this.AccumulateButton.UseVisualStyleBackColor = true;
            this.AccumulateButton.Click += new System.EventHandler(this.AccumulateButton_Click);
            // 
            // AccumulationSumBox
            // 
            this.AccumulationSumBox.Location = new System.Drawing.Point(446, 270);
            this.AccumulationSumBox.Name = "AccumulationSumBox";
            this.AccumulationSumBox.Size = new System.Drawing.Size(121, 26);
            this.AccumulationSumBox.TabIndex = 35;
            this.AccumulationSumBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.AccumulationSumBox_KeyPress);
            // 
            // PercentBox
            // 
            this.PercentBox.Location = new System.Drawing.Point(446, 313);
            this.PercentBox.Name = "PercentBox";
            this.PercentBox.Size = new System.Drawing.Size(121, 26);
            this.PercentBox.TabIndex = 36;
            this.PercentBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.PercentBox_KeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(35, 268);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(101, 20);
            this.label4.TabIndex = 37;
            this.label4.Text = "TransferSum";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(35, 319);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(76, 20);
            this.label5.TabIndex = 38;
            this.label5.Text = "Recipient";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(302, 273);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(138, 20);
            this.label6.TabIndex = 39;
            this.label6.Text = "AccumulationSum";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(302, 319);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(64, 20);
            this.label7.TabIndex = 40;
            this.label7.Text = "Percent";
            // 
            // BlockButton
            // 
            this.BlockButton.Location = new System.Drawing.Point(446, 12);
            this.BlockButton.Name = "BlockButton";
            this.BlockButton.Size = new System.Drawing.Size(81, 31);
            this.BlockButton.TabIndex = 41;
            this.BlockButton.Text = "Block";
            this.BlockButton.UseVisualStyleBackColor = true;
            this.BlockButton.Click += new System.EventHandler(this.BlockButton_Click);
            // 
            // FreezeButton
            // 
            this.FreezeButton.Location = new System.Drawing.Point(556, 12);
            this.FreezeButton.Name = "FreezeButton";
            this.FreezeButton.Size = new System.Drawing.Size(81, 31);
            this.FreezeButton.TabIndex = 42;
            this.FreezeButton.Text = "Freeze";
            this.FreezeButton.UseVisualStyleBackColor = true;
            this.FreezeButton.Click += new System.EventHandler(this.FreezeButton_Click);
            // 
            // AmountBox
            // 
            this.AmountBox.Location = new System.Drawing.Point(69, 92);
            this.AmountBox.Name = "AmountBox";
            this.AmountBox.Size = new System.Drawing.Size(146, 28);
            this.AmountBox.TabIndex = 43;
            this.AmountBox.Text = "";
            // 
            // AccumulationBox
            // 
            this.AccumulationBox.Location = new System.Drawing.Point(433, 92);
            this.AccumulationBox.Name = "AccumulationBox";
            this.AccumulationBox.Size = new System.Drawing.Size(146, 28);
            this.AccumulationBox.TabIndex = 44;
            this.AccumulationBox.Text = "";
            // 
            // SavingBox
            // 
            this.SavingBox.Location = new System.Drawing.Point(258, 92);
            this.SavingBox.Name = "SavingBox";
            this.SavingBox.Size = new System.Drawing.Size(146, 28);
            this.SavingBox.TabIndex = 45;
            this.SavingBox.Text = "";
            // 
            // AccountInteractionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(649, 419);
            this.Controls.Add(this.SavingBox);
            this.Controls.Add(this.AccumulationBox);
            this.Controls.Add(this.AmountBox);
            this.Controls.Add(this.FreezeButton);
            this.Controls.Add(this.BlockButton);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.PercentBox);
            this.Controls.Add(this.AccumulationSumBox);
            this.Controls.Add(this.AccumulateButton);
            this.Controls.Add(this.TransferButton);
            this.Controls.Add(this.RecipientBox);
            this.Controls.Add(this.TransferSumBox);
            this.Controls.Add(this.CashOutButton);
            this.Controls.Add(this.CashOutBox);
            this.Controls.Add(this.SaveBox);
            this.Controls.Add(this.SaveButton);
            this.Controls.Add(this.BackButton);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "AccountInteractionForm";
            this.Text = "AccountInteraction";
            this.Load += new System.EventHandler(this.AccountInteractionForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button BackButton;
        private System.Windows.Forms.Button SaveButton;
        private System.Windows.Forms.TextBox SaveBox;
        private System.Windows.Forms.TextBox CashOutBox;
        private System.Windows.Forms.Button CashOutButton;
        private System.Windows.Forms.TextBox TransferSumBox;
        private System.Windows.Forms.ComboBox RecipientBox;
        private System.Windows.Forms.Button TransferButton;
        private System.Windows.Forms.Button AccumulateButton;
        private System.Windows.Forms.TextBox AccumulationSumBox;
        private System.Windows.Forms.TextBox PercentBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button BlockButton;
        private System.Windows.Forms.Button FreezeButton;
        private System.Windows.Forms.RichTextBox AmountBox;
        private System.Windows.Forms.RichTextBox AccumulationBox;
        private System.Windows.Forms.RichTextBox SavingBox;
    }
}