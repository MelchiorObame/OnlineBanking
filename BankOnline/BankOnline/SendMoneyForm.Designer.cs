namespace BankOnline
{
    partial class SendMoneyForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SendMoneyForm));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.sendMoneyBtn = new System.Windows.Forms.Button();
            this.cancelBtn = new System.Windows.Forms.Button();
            this.passwordTextBox = new System.Windows.Forms.TextBox();
            this.amountTextBox = new System.Windows.Forms.TextBox();
            this.sendToComboBox = new System.Windows.Forms.ComboBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.robotCheckBox = new System.Windows.Forms.CheckBox();
            this.succesPictureBox = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.succesPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(51, 219);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Send to :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(51, 266);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Password :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(51, 166);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Amount :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(270, 169);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(18, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "$";
            // 
            // sendMoneyBtn
            // 
            this.sendMoneyBtn.BackColor = System.Drawing.Color.LightSkyBlue;
            this.sendMoneyBtn.Location = new System.Drawing.Point(70, 382);
            this.sendMoneyBtn.Name = "sendMoneyBtn";
            this.sendMoneyBtn.Size = new System.Drawing.Size(156, 37);
            this.sendMoneyBtn.TabIndex = 11;
            this.sendMoneyBtn.Text = "Send Money";
            this.sendMoneyBtn.UseVisualStyleBackColor = false;
            this.sendMoneyBtn.Click += new System.EventHandler(this.SendMoneyBtn_Click);
            // 
            // cancelBtn
            // 
            this.cancelBtn.BackColor = System.Drawing.Color.LightSkyBlue;
            this.cancelBtn.Location = new System.Drawing.Point(264, 382);
            this.cancelBtn.Name = "cancelBtn";
            this.cancelBtn.Size = new System.Drawing.Size(97, 37);
            this.cancelBtn.TabIndex = 12;
            this.cancelBtn.Text = "Exit";
            this.cancelBtn.UseVisualStyleBackColor = false;
            this.cancelBtn.Click += new System.EventHandler(this.ExitBtn_Click);
            // 
            // passwordTextBox
            // 
            this.passwordTextBox.Location = new System.Drawing.Point(143, 266);
            this.passwordTextBox.Name = "passwordTextBox";
            this.passwordTextBox.Size = new System.Drawing.Size(121, 26);
            this.passwordTextBox.TabIndex = 13;
            // 
            // amountTextBox
            // 
            this.amountTextBox.Location = new System.Drawing.Point(143, 166);
            this.amountTextBox.Name = "amountTextBox";
            this.amountTextBox.Size = new System.Drawing.Size(121, 26);
            this.amountTextBox.TabIndex = 14;
            // 
            // sendToComboBox
            // 
            this.sendToComboBox.FormattingEnabled = true;
            this.sendToComboBox.Location = new System.Drawing.Point(143, 211);
            this.sendToComboBox.Name = "sendToComboBox";
            this.sendToComboBox.Size = new System.Drawing.Size(218, 28);
            this.sendToComboBox.TabIndex = 15;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(143, 27);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(145, 133);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 16;
            this.pictureBox1.TabStop = false;
            // 
            // robotCheckBox
            // 
            this.robotCheckBox.AutoSize = true;
            this.robotCheckBox.Location = new System.Drawing.Point(143, 314);
            this.robotCheckBox.Name = "robotCheckBox";
            this.robotCheckBox.Size = new System.Drawing.Size(137, 24);
            this.robotCheckBox.TabIndex = 17;
            this.robotCheckBox.Text = "I\'m not a robot";
            this.robotCheckBox.UseVisualStyleBackColor = true;
            // 
            // succesPictureBox
            // 
            this.succesPictureBox.Image = ((System.Drawing.Image)(resources.GetObject("succesPictureBox.Image")));
            this.succesPictureBox.Location = new System.Drawing.Point(330, 277);
            this.succesPictureBox.Name = "succesPictureBox";
            this.succesPictureBox.Size = new System.Drawing.Size(79, 78);
            this.succesPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.succesPictureBox.TabIndex = 18;
            this.succesPictureBox.TabStop = false;
            this.succesPictureBox.Visible = false;
            // 
            // SendMoneyForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(438, 454);
            this.Controls.Add(this.succesPictureBox);
            this.Controls.Add(this.robotCheckBox);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.sendToComboBox);
            this.Controls.Add(this.amountTextBox);
            this.Controls.Add(this.passwordTextBox);
            this.Controls.Add(this.cancelBtn);
            this.Controls.Add(this.sendMoneyBtn);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "SendMoneyForm";
            this.Text = "Send Money";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.succesPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button sendMoneyBtn;
        private System.Windows.Forms.Button cancelBtn;
        private System.Windows.Forms.TextBox passwordTextBox;
        private System.Windows.Forms.TextBox amountTextBox;
        private System.Windows.Forms.ComboBox sendToComboBox;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.CheckBox robotCheckBox;
        private System.Windows.Forms.PictureBox succesPictureBox;
    }
}