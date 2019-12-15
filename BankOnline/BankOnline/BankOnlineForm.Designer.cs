namespace BankOnline
{
    partial class BankOnlineForm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BankOnlineForm));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.passwordTextBox = new System.Windows.Forms.TextBox();
            this.userNameTextBox = new System.Windows.Forms.TextBox();
            this.btnLogIn = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.clearAllToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clearAllToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.createAnAccountToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.exitToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.createAnAccountToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.clearAllToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.exitBtn = new System.Windows.Forms.Button();
            this.createAccountBtn = new System.Windows.Forms.Button();
            this.errorLoginPictureBox2 = new System.Windows.Forms.PictureBox();
            this.errorLoginPictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.menuStrip.SuspendLayout();
            this.contextMenuStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorLoginPictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorLoginPictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(126, 51);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(219, 206);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 15;
            this.pictureBox1.TabStop = false;
            // 
            // passwordTextBox
            // 
            this.passwordTextBox.Location = new System.Drawing.Point(171, 335);
            this.passwordTextBox.Name = "passwordTextBox";
            this.passwordTextBox.Size = new System.Drawing.Size(213, 26);
            this.passwordTextBox.TabIndex = 14;
            // 
            // userNameTextBox
            // 
            this.userNameTextBox.Location = new System.Drawing.Point(171, 276);
            this.userNameTextBox.Name = "userNameTextBox";
            this.userNameTextBox.Size = new System.Drawing.Size(213, 26);
            this.userNameTextBox.TabIndex = 13;
            // 
            // btnLogIn
            // 
            this.btnLogIn.Location = new System.Drawing.Point(199, 367);
            this.btnLogIn.Name = "btnLogIn";
            this.btnLogIn.Size = new System.Drawing.Size(110, 33);
            this.btnLogIn.TabIndex = 11;
            this.btnLogIn.Text = "Log In";
            this.btnLogIn.UseVisualStyleBackColor = true;
            this.btnLogIn.Click += new System.EventHandler(this.btnLogIn_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(74, 335);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 20);
            this.label2.TabIndex = 10;
            this.label2.Text = "Password :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(74, 276);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 20);
            this.label1.TabIndex = 9;
            this.label1.Text = "Username :";
            // 
            // menuStrip
            // 
            this.menuStrip.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.clearAllToolStripMenuItem,
            this.aboutToolStripMenuItem});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(475, 33);
            this.menuStrip.TabIndex = 16;
            this.menuStrip.Text = "menuStrip1";
            // 
            // clearAllToolStripMenuItem
            // 
            this.clearAllToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem,
            this.clearAllToolStripMenuItem1,
            this.createAnAccountToolStripMenuItem});
            this.clearAllToolStripMenuItem.Name = "clearAllToolStripMenuItem";
            this.clearAllToolStripMenuItem.Size = new System.Drawing.Size(50, 29);
            this.clearAllToolStripMenuItem.Text = "File";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(240, 30);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // clearAllToolStripMenuItem1
            // 
            this.clearAllToolStripMenuItem1.Name = "clearAllToolStripMenuItem1";
            this.clearAllToolStripMenuItem1.Size = new System.Drawing.Size(240, 30);
            this.clearAllToolStripMenuItem1.Text = "Clear All";
            this.clearAllToolStripMenuItem1.Click += new System.EventHandler(this.clearAllToolStripMenuItem1_Click);
            // 
            // createAnAccountToolStripMenuItem
            // 
            this.createAnAccountToolStripMenuItem.Name = "createAnAccountToolStripMenuItem";
            this.createAnAccountToolStripMenuItem.Size = new System.Drawing.Size(240, 30);
            this.createAnAccountToolStripMenuItem.Text = "Create an Account";
            this.createAnAccountToolStripMenuItem.Click += new System.EventHandler(this.createAnAccountToolStripMenuItem_Click);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem1});
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(78, 29);
            this.aboutToolStripMenuItem.Text = "Project";
            // 
            // aboutToolStripMenuItem1
            // 
            this.aboutToolStripMenuItem1.Name = "aboutToolStripMenuItem1";
            this.aboutToolStripMenuItem1.Size = new System.Drawing.Size(146, 30);
            this.aboutToolStripMenuItem1.Text = "About";
            this.aboutToolStripMenuItem1.Click += new System.EventHandler(this.aboutToolStripMenuItem1_Click);
            // 
            // contextMenuStrip
            // 
            this.contextMenuStrip.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.contextMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem1,
            this.createAnAccountToolStripMenuItem1,
            this.clearAllToolStripMenuItem2});
            this.contextMenuStrip.Name = "contextMenuStrip";
            this.contextMenuStrip.Size = new System.Drawing.Size(229, 94);
            // 
            // exitToolStripMenuItem1
            // 
            this.exitToolStripMenuItem1.Name = "exitToolStripMenuItem1";
            this.exitToolStripMenuItem1.Size = new System.Drawing.Size(228, 30);
            this.exitToolStripMenuItem1.Text = "Exit";
            this.exitToolStripMenuItem1.Click += new System.EventHandler(this.exitToolStripMenuItem1_Click);
            // 
            // createAnAccountToolStripMenuItem1
            // 
            this.createAnAccountToolStripMenuItem1.Name = "createAnAccountToolStripMenuItem1";
            this.createAnAccountToolStripMenuItem1.Size = new System.Drawing.Size(228, 30);
            this.createAnAccountToolStripMenuItem1.Text = "Create an Account";
            this.createAnAccountToolStripMenuItem1.Click += new System.EventHandler(this.createAnAccountToolStripMenuItem1_Click);
            // 
            // clearAllToolStripMenuItem2
            // 
            this.clearAllToolStripMenuItem2.Name = "clearAllToolStripMenuItem2";
            this.clearAllToolStripMenuItem2.Size = new System.Drawing.Size(228, 30);
            this.clearAllToolStripMenuItem2.Text = "Clear All";
            this.clearAllToolStripMenuItem2.Click += new System.EventHandler(this.clearAllToolStripMenuItem2_Click);
            // 
            // exitBtn
            // 
            this.exitBtn.Location = new System.Drawing.Point(280, 458);
            this.exitBtn.Name = "exitBtn";
            this.exitBtn.Size = new System.Drawing.Size(104, 33);
            this.exitBtn.TabIndex = 18;
            this.exitBtn.Text = "Exit";
            this.exitBtn.UseVisualStyleBackColor = true;
            this.exitBtn.Click += new System.EventHandler(this.exitBtn_Click);
            // 
            // createAccountBtn
            // 
            this.createAccountBtn.Location = new System.Drawing.Point(78, 458);
            this.createAccountBtn.Name = "createAccountBtn";
            this.createAccountBtn.Size = new System.Drawing.Size(174, 33);
            this.createAccountBtn.TabIndex = 19;
            this.createAccountBtn.Text = "Create an account";
            this.createAccountBtn.UseVisualStyleBackColor = true;
            this.createAccountBtn.Click += new System.EventHandler(this.createAccountBtn_Click);
            // 
            // errorLoginPictureBox2
            // 
            this.errorLoginPictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("errorLoginPictureBox2.Image")));
            this.errorLoginPictureBox2.Location = new System.Drawing.Point(392, 276);
            this.errorLoginPictureBox2.Name = "errorLoginPictureBox2";
            this.errorLoginPictureBox2.Size = new System.Drawing.Size(33, 26);
            this.errorLoginPictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.errorLoginPictureBox2.TabIndex = 20;
            this.errorLoginPictureBox2.TabStop = false;
            this.errorLoginPictureBox2.Visible = false;
            // 
            // errorLoginPictureBox1
            // 
            this.errorLoginPictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("errorLoginPictureBox1.Image")));
            this.errorLoginPictureBox1.Location = new System.Drawing.Point(390, 335);
            this.errorLoginPictureBox1.Name = "errorLoginPictureBox1";
            this.errorLoginPictureBox1.Size = new System.Drawing.Size(33, 26);
            this.errorLoginPictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.errorLoginPictureBox1.TabIndex = 21;
            this.errorLoginPictureBox1.TabStop = false;
            this.errorLoginPictureBox1.Visible = false;
            // 
            // BankOnlineForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(475, 510);
            this.ContextMenuStrip = this.contextMenuStrip;
            this.Controls.Add(this.errorLoginPictureBox1);
            this.Controls.Add(this.errorLoginPictureBox2);
            this.Controls.Add(this.createAccountBtn);
            this.Controls.Add(this.exitBtn);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.passwordTextBox);
            this.Controls.Add(this.userNameTextBox);
            this.Controls.Add(this.btnLogIn);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip);
            this.MainMenuStrip = this.menuStrip;
            this.Name = "BankOnlineForm";
            this.Text = "Online Banking";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.contextMenuStrip.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.errorLoginPictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorLoginPictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox passwordTextBox;
        private System.Windows.Forms.TextBox userNameTextBox;
        private System.Windows.Forms.Button btnLogIn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem clearAllToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clearAllToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem createAnAccountToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem createAnAccountToolStripMenuItem1;
        private System.Windows.Forms.Button exitBtn;
        private System.Windows.Forms.Button createAccountBtn;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem clearAllToolStripMenuItem2;
        private System.Windows.Forms.PictureBox errorLoginPictureBox2;
        private System.Windows.Forms.PictureBox errorLoginPictureBox1;
    }
}

