namespace StickyNotesVPL
{
    partial class StartScreen
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StartScreen));
            this.logo = new System.Windows.Forms.Panel();
            this.header1 = new System.Windows.Forms.Label();
            this.header2 = new System.Windows.Forms.Label();
            this.img1 = new System.Windows.Forms.Panel();
            this.loginlabel = new System.Windows.Forms.Label();
            this.loginBTN = new System.Windows.Forms.Button();
            this.img2 = new System.Windows.Forms.Panel();
            this.signuplabel = new System.Windows.Forms.Label();
            this.signupBTN = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // logo
            // 
            this.logo.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("logo.BackgroundImage")));
            this.logo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.logo.Location = new System.Drawing.Point(12, 12);
            this.logo.Name = "logo";
            this.logo.Size = new System.Drawing.Size(150, 144);
            this.logo.TabIndex = 0;
            // 
            // header1
            // 
            this.header1.AutoSize = true;
            this.header1.Font = new System.Drawing.Font("Segoe Script", 36F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.header1.ForeColor = System.Drawing.Color.SaddleBrown;
            this.header1.Location = new System.Drawing.Point(155, 48);
            this.header1.Name = "header1";
            this.header1.Size = new System.Drawing.Size(458, 76);
            this.header1.TabIndex = 1;
            this.header1.Text = "Write Your Notes";
            // 
            // header2
            // 
            this.header2.AutoSize = true;
            this.header2.Font = new System.Drawing.Font("Segoe Script", 18F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.header2.ForeColor = System.Drawing.Color.SaddleBrown;
            this.header2.Location = new System.Drawing.Point(242, 100);
            this.header2.Name = "header2";
            this.header2.Size = new System.Drawing.Size(280, 38);
            this.header2.TabIndex = 2;
            this.header2.Text = "make things happen";
            // 
            // img1
            // 
            this.img1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("img1.BackgroundImage")));
            this.img1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.img1.Location = new System.Drawing.Point(170, 200);
            this.img1.Name = "img1";
            this.img1.Size = new System.Drawing.Size(67, 68);
            this.img1.TabIndex = 3;
            // 
            // loginlabel
            // 
            this.loginlabel.AutoSize = true;
            this.loginlabel.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.loginlabel.ForeColor = System.Drawing.Color.SaddleBrown;
            this.loginlabel.Location = new System.Drawing.Point(243, 200);
            this.loginlabel.Name = "loginlabel";
            this.loginlabel.Size = new System.Drawing.Size(223, 30);
            this.loginlabel.TabIndex = 4;
            this.loginlabel.Text = "Start writing your notes";
            // 
            // loginBTN
            // 
            this.loginBTN.BackColor = System.Drawing.Color.OldLace;
            this.loginBTN.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.loginBTN.ForeColor = System.Drawing.Color.SaddleBrown;
            this.loginBTN.Location = new System.Drawing.Point(243, 233);
            this.loginBTN.Name = "loginBTN";
            this.loginBTN.Size = new System.Drawing.Size(218, 35);
            this.loginBTN.TabIndex = 5;
            this.loginBTN.Text = "L O G I N";
            this.loginBTN.UseVisualStyleBackColor = false;
            this.loginBTN.Click += new System.EventHandler(this.loginBTN_Click);
            // 
            // img2
            // 
            this.img2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("img2.BackgroundImage")));
            this.img2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.img2.Location = new System.Drawing.Point(170, 292);
            this.img2.Name = "img2";
            this.img2.Size = new System.Drawing.Size(67, 68);
            this.img2.TabIndex = 4;
            // 
            // signuplabel
            // 
            this.signuplabel.AutoSize = true;
            this.signuplabel.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.signuplabel.ForeColor = System.Drawing.Color.SaddleBrown;
            this.signuplabel.Location = new System.Drawing.Point(243, 292);
            this.signuplabel.Name = "signuplabel";
            this.signuplabel.Size = new System.Drawing.Size(253, 30);
            this.signuplabel.TabIndex = 6;
            this.signuplabel.Text = "Create hassle free account ";
            // 
            // signupBTN
            // 
            this.signupBTN.BackColor = System.Drawing.Color.OldLace;
            this.signupBTN.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.signupBTN.ForeColor = System.Drawing.Color.SaddleBrown;
            this.signupBTN.Location = new System.Drawing.Point(243, 325);
            this.signupBTN.Name = "signupBTN";
            this.signupBTN.Size = new System.Drawing.Size(218, 35);
            this.signupBTN.TabIndex = 7;
            this.signupBTN.Text = "S I G N U P";
            this.signupBTN.UseVisualStyleBackColor = false;
            this.signupBTN.Click += new System.EventHandler(this.signupBTN_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.SaddleBrown;
            this.label2.Location = new System.Drawing.Point(199, 424);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(262, 17);
            this.label2.TabIndex = 8;
            this.label2.Text = "Muhammad Salman VPL Semester Project";
            // 
            // StartScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SeaShell;
            this.ClientSize = new System.Drawing.Size(625, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.signupBTN);
            this.Controls.Add(this.signuplabel);
            this.Controls.Add(this.img2);
            this.Controls.Add(this.loginBTN);
            this.Controls.Add(this.loginlabel);
            this.Controls.Add(this.img1);
            this.Controls.Add(this.header2);
            this.Controls.Add(this.header1);
            this.Controls.Add(this.logo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "StartScreen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Welcome Screen (Sticky Notes)";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Panel logo;
        private Label header1;
        private Label header2;
        private Panel img1;
        private Label loginlabel;
        private Button loginBTN;
        private Panel img2;
        private Label signuplabel;
        private Button signupBTN;
        private Label label2;
    }
}