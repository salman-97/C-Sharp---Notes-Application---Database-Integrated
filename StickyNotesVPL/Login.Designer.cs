namespace StickyNotesVPL
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.header2 = new System.Windows.Forms.Label();
            this.header1 = new System.Windows.Forms.Label();
            this.logo = new System.Windows.Forms.Panel();
            this.usernameLabel = new System.Windows.Forms.Label();
            this.unametxt = new System.Windows.Forms.TextBox();
            this.upasstxt = new System.Windows.Forms.TextBox();
            this.passwordlabel = new System.Windows.Forms.Label();
            this.loginBTN = new System.Windows.Forms.Button();
            this.closeBTN = new System.Windows.Forms.Button();
            this.footer = new System.Windows.Forms.Label();
            this.getusername = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // header2
            // 
            this.header2.AutoSize = true;
            this.header2.Font = new System.Drawing.Font("Segoe Script", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.header2.ForeColor = System.Drawing.Color.SaddleBrown;
            this.header2.Location = new System.Drawing.Point(198, 116);
            this.header2.Name = "header2";
            this.header2.Size = new System.Drawing.Size(297, 33);
            this.header2.TabIndex = 5;
            this.header2.Text = "LOGIN into your account";
            // 
            // header1
            // 
            this.header1.AutoSize = true;
            this.header1.Font = new System.Drawing.Font("Segoe Script", 36F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.header1.ForeColor = System.Drawing.Color.SaddleBrown;
            this.header1.Location = new System.Drawing.Point(168, 51);
            this.header1.Name = "header1";
            this.header1.Size = new System.Drawing.Size(340, 76);
            this.header1.TabIndex = 4;
            this.header1.Text = "Sticky Notes";
            // 
            // logo
            // 
            this.logo.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("logo.BackgroundImage")));
            this.logo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.logo.Location = new System.Drawing.Point(12, 12);
            this.logo.Name = "logo";
            this.logo.Size = new System.Drawing.Size(150, 144);
            this.logo.TabIndex = 3;
            // 
            // usernameLabel
            // 
            this.usernameLabel.AutoSize = true;
            this.usernameLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.usernameLabel.ForeColor = System.Drawing.Color.SaddleBrown;
            this.usernameLabel.Location = new System.Drawing.Point(168, 207);
            this.usernameLabel.Name = "usernameLabel";
            this.usernameLabel.Size = new System.Drawing.Size(109, 30);
            this.usernameLabel.TabIndex = 6;
            this.usernameLabel.Text = "Username";
            // 
            // unametxt
            // 
            this.unametxt.BackColor = System.Drawing.Color.Linen;
            this.unametxt.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.unametxt.ForeColor = System.Drawing.Color.SaddleBrown;
            this.unametxt.Location = new System.Drawing.Point(283, 204);
            this.unametxt.Name = "unametxt";
            this.unametxt.Size = new System.Drawing.Size(224, 35);
            this.unametxt.TabIndex = 7;
            // 
            // upasstxt
            // 
            this.upasstxt.BackColor = System.Drawing.Color.Linen;
            this.upasstxt.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.upasstxt.ForeColor = System.Drawing.Color.SaddleBrown;
            this.upasstxt.Location = new System.Drawing.Point(284, 270);
            this.upasstxt.Name = "upasstxt";
            this.upasstxt.Size = new System.Drawing.Size(224, 35);
            this.upasstxt.TabIndex = 9;
            this.upasstxt.UseSystemPasswordChar = true;
            // 
            // passwordlabel
            // 
            this.passwordlabel.AutoSize = true;
            this.passwordlabel.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.passwordlabel.ForeColor = System.Drawing.Color.SaddleBrown;
            this.passwordlabel.Location = new System.Drawing.Point(174, 273);
            this.passwordlabel.Name = "passwordlabel";
            this.passwordlabel.Size = new System.Drawing.Size(103, 30);
            this.passwordlabel.TabIndex = 8;
            this.passwordlabel.Text = "Password";
            // 
            // loginBTN
            // 
            this.loginBTN.BackColor = System.Drawing.Color.OldLace;
            this.loginBTN.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.loginBTN.ForeColor = System.Drawing.Color.SaddleBrown;
            this.loginBTN.Location = new System.Drawing.Point(283, 328);
            this.loginBTN.Name = "loginBTN";
            this.loginBTN.Size = new System.Drawing.Size(224, 40);
            this.loginBTN.TabIndex = 10;
            this.loginBTN.Text = "L O G I N";
            this.loginBTN.UseVisualStyleBackColor = false;
            this.loginBTN.Click += new System.EventHandler(this.loginBTN_Click);
            // 
            // closeBTN
            // 
            this.closeBTN.BackColor = System.Drawing.Color.FloralWhite;
            this.closeBTN.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.closeBTN.ForeColor = System.Drawing.Color.SaddleBrown;
            this.closeBTN.Location = new System.Drawing.Point(12, 402);
            this.closeBTN.Name = "closeBTN";
            this.closeBTN.Size = new System.Drawing.Size(101, 36);
            this.closeBTN.TabIndex = 11;
            this.closeBTN.Text = "C L O S E";
            this.closeBTN.UseVisualStyleBackColor = false;
            this.closeBTN.Click += new System.EventHandler(this.closeBTN_Click);
            // 
            // footer
            // 
            this.footer.AutoSize = true;
            this.footer.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.footer.ForeColor = System.Drawing.Color.SaddleBrown;
            this.footer.Location = new System.Drawing.Point(222, 424);
            this.footer.Name = "footer";
            this.footer.Size = new System.Drawing.Size(262, 17);
            this.footer.TabIndex = 12;
            this.footer.Text = "Muhammad Salman VPL Semester Project";
            // 
            // getusername
            // 
            this.getusername.AutoSize = true;
            this.getusername.Location = new System.Drawing.Point(283, 397);
            this.getusername.Name = "getusername";
            this.getusername.Size = new System.Drawing.Size(0, 15);
            this.getusername.TabIndex = 13;
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SeaShell;
            this.ClientSize = new System.Drawing.Size(625, 450);
            this.Controls.Add(this.getusername);
            this.Controls.Add(this.footer);
            this.Controls.Add(this.closeBTN);
            this.Controls.Add(this.loginBTN);
            this.Controls.Add(this.upasstxt);
            this.Controls.Add(this.passwordlabel);
            this.Controls.Add(this.unametxt);
            this.Controls.Add(this.usernameLabel);
            this.Controls.Add(this.header2);
            this.Controls.Add(this.header1);
            this.Controls.Add(this.logo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login (Sticky Notes)";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label header2;
        private Label header1;
        private Panel logo;
        private Label usernameLabel;
        private TextBox upasstxt;
        private Label passwordlabel;
        private Button loginBTN;
        private Button closeBTN;
        private Label footer;
        private Label getusername;
        public TextBox unametxt;
    }
}