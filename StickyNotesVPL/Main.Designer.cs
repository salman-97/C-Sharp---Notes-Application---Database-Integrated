namespace StickyNotesVPL
{
    partial class MainScreen
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainScreen));
            this.logo1 = new System.Windows.Forms.Panel();
            this.header2 = new System.Windows.Forms.Label();
            this.header1 = new System.Windows.Forms.Label();
            this.logo2 = new System.Windows.Forms.Panel();
            this.fetchusername = new System.Windows.Forms.Label();
            this.img2 = new System.Windows.Forms.Panel();
            this.line = new System.Windows.Forms.Panel();
            this.logoutlabel = new System.Windows.Forms.Label();
            this.notetype = new System.Windows.Forms.Label();
            this.noteTypetxt = new System.Windows.Forms.ComboBox();
            this.notetitle = new System.Windows.Forms.Label();
            this.noteTitletxt = new System.Windows.Forms.TextBox();
            this.notedesc = new System.Windows.Forms.Label();
            this.notesTxT = new System.Windows.Forms.RichTextBox();
            this.footer = new System.Windows.Forms.Label();
            this.saveNoteBTN = new System.Windows.Forms.Button();
            this.viewNotesBTN = new System.Windows.Forms.Button();
            this.clearTxTBTB = new System.Windows.Forms.Button();
            this.writeimage = new System.Windows.Forms.Panel();
            this.logoutBtn = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // logo1
            // 
            this.logo1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("logo1.BackgroundImage")));
            this.logo1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.logo1.Location = new System.Drawing.Point(12, 12);
            this.logo1.Name = "logo1";
            this.logo1.Size = new System.Drawing.Size(150, 144);
            this.logo1.TabIndex = 5;
            // 
            // header2
            // 
            this.header2.AutoSize = true;
            this.header2.Font = new System.Drawing.Font("Segoe Script", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.header2.ForeColor = System.Drawing.Color.SaddleBrown;
            this.header2.Location = new System.Drawing.Point(330, 123);
            this.header2.Name = "header2";
            this.header2.Size = new System.Drawing.Size(215, 33);
            this.header2.TabIndex = 9;
            this.header2.Text = "WRITE your notes";
            // 
            // header1
            // 
            this.header1.AutoSize = true;
            this.header1.Font = new System.Drawing.Font("Segoe Script", 36F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.header1.ForeColor = System.Drawing.Color.SaddleBrown;
            this.header1.Location = new System.Drawing.Point(221, 60);
            this.header1.Name = "header1";
            this.header1.Size = new System.Drawing.Size(340, 76);
            this.header1.TabIndex = 8;
            this.header1.Text = "Sticky Notes";
            // 
            // logo2
            // 
            this.logo2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("logo2.BackgroundImage")));
            this.logo2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.logo2.Location = new System.Drawing.Point(644, 12);
            this.logo2.Name = "logo2";
            this.logo2.Size = new System.Drawing.Size(150, 144);
            this.logo2.TabIndex = 6;
            // 
            // fetchusername
            // 
            this.fetchusername.AutoSize = true;
            this.fetchusername.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.fetchusername.ForeColor = System.Drawing.Color.SaddleBrown;
            this.fetchusername.Location = new System.Drawing.Point(55, 186);
            this.fetchusername.Name = "fetchusername";
            this.fetchusername.Size = new System.Drawing.Size(0, 30);
            this.fetchusername.TabIndex = 10;
            // 
            // img2
            // 
            this.img2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("img2.BackgroundImage")));
            this.img2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.img2.Location = new System.Drawing.Point(12, 178);
            this.img2.Name = "img2";
            this.img2.Size = new System.Drawing.Size(37, 38);
            this.img2.TabIndex = 12;
            // 
            // line
            // 
            this.line.BackColor = System.Drawing.Color.SaddleBrown;
            this.line.Location = new System.Drawing.Point(0, 222);
            this.line.Name = "line";
            this.line.Size = new System.Drawing.Size(816, 5);
            this.line.TabIndex = 13;
            // 
            // logoutlabel
            // 
            this.logoutlabel.AutoSize = true;
            this.logoutlabel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.logoutlabel.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.logoutlabel.ForeColor = System.Drawing.Color.SaddleBrown;
            this.logoutlabel.Location = new System.Drawing.Point(690, 180);
            this.logoutlabel.Name = "logoutlabel";
            this.logoutlabel.Size = new System.Drawing.Size(78, 30);
            this.logoutlabel.TabIndex = 14;
            this.logoutlabel.Text = "Logout";
            // 
            // notetype
            // 
            this.notetype.AutoSize = true;
            this.notetype.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.notetype.ForeColor = System.Drawing.Color.SaddleBrown;
            this.notetype.Location = new System.Drawing.Point(12, 253);
            this.notetype.Name = "notetype";
            this.notetype.Size = new System.Drawing.Size(113, 30);
            this.notetype.TabIndex = 16;
            this.notetype.Text = "Note Type";
            // 
            // noteTypetxt
            // 
            this.noteTypetxt.BackColor = System.Drawing.Color.Linen;
            this.noteTypetxt.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.noteTypetxt.ForeColor = System.Drawing.Color.SaddleBrown;
            this.noteTypetxt.FormattingEnabled = true;
            this.noteTypetxt.Items.AddRange(new object[] {
            "Notes",
            "Reminder",
            "To-do"});
            this.noteTypetxt.Location = new System.Drawing.Point(131, 250);
            this.noteTypetxt.Name = "noteTypetxt";
            this.noteTypetxt.Size = new System.Drawing.Size(227, 38);
            this.noteTypetxt.TabIndex = 17;
            // 
            // notetitle
            // 
            this.notetitle.AutoSize = true;
            this.notetitle.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.notetitle.ForeColor = System.Drawing.Color.SaddleBrown;
            this.notetitle.Location = new System.Drawing.Point(12, 315);
            this.notetitle.Name = "notetitle";
            this.notetitle.Size = new System.Drawing.Size(108, 30);
            this.notetitle.TabIndex = 18;
            this.notetitle.Text = "Note Title";
            // 
            // noteTitletxt
            // 
            this.noteTitletxt.BackColor = System.Drawing.Color.Linen;
            this.noteTitletxt.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.noteTitletxt.ForeColor = System.Drawing.Color.SaddleBrown;
            this.noteTitletxt.Location = new System.Drawing.Point(131, 312);
            this.noteTitletxt.Name = "noteTitletxt";
            this.noteTitletxt.PlaceholderText = "salman\'s birthday or VPL Lecture";
            this.noteTitletxt.Size = new System.Drawing.Size(319, 35);
            this.noteTitletxt.TabIndex = 19;
            // 
            // notedesc
            // 
            this.notedesc.AutoSize = true;
            this.notedesc.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.notedesc.ForeColor = System.Drawing.Color.SaddleBrown;
            this.notedesc.Location = new System.Drawing.Point(12, 377);
            this.notedesc.Name = "notedesc";
            this.notedesc.Size = new System.Drawing.Size(70, 30);
            this.notedesc.TabIndex = 20;
            this.notedesc.Text = "Notes";
            // 
            // notesTxT
            // 
            this.notesTxT.BackColor = System.Drawing.Color.Linen;
            this.notesTxT.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.notesTxT.ForeColor = System.Drawing.Color.SaddleBrown;
            this.notesTxT.Location = new System.Drawing.Point(131, 374);
            this.notesTxT.Name = "notesTxT";
            this.notesTxT.Size = new System.Drawing.Size(477, 189);
            this.notesTxT.TabIndex = 21;
            this.notesTxT.Text = "";
            // 
            // footer
            // 
            this.footer.AutoSize = true;
            this.footer.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.footer.ForeColor = System.Drawing.Color.SaddleBrown;
            this.footer.Location = new System.Drawing.Point(265, 583);
            this.footer.Name = "footer";
            this.footer.Size = new System.Drawing.Size(296, 20);
            this.footer.TabIndex = 28;
            this.footer.Text = "Muhammad Salman VPL Semester Project";
            // 
            // saveNoteBTN
            // 
            this.saveNoteBTN.BackColor = System.Drawing.Color.OldLace;
            this.saveNoteBTN.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.saveNoteBTN.ForeColor = System.Drawing.Color.SaddleBrown;
            this.saveNoteBTN.Location = new System.Drawing.Point(624, 385);
            this.saveNoteBTN.Name = "saveNoteBTN";
            this.saveNoteBTN.Size = new System.Drawing.Size(155, 39);
            this.saveNoteBTN.TabIndex = 29;
            this.saveNoteBTN.Text = "SAVE NOTE";
            this.saveNoteBTN.UseVisualStyleBackColor = false;
            this.saveNoteBTN.Click += new System.EventHandler(this.saveNoteBTN_Click);
            // 
            // viewNotesBTN
            // 
            this.viewNotesBTN.BackColor = System.Drawing.Color.OldLace;
            this.viewNotesBTN.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.viewNotesBTN.ForeColor = System.Drawing.Color.SaddleBrown;
            this.viewNotesBTN.Location = new System.Drawing.Point(624, 524);
            this.viewNotesBTN.Name = "viewNotesBTN";
            this.viewNotesBTN.Size = new System.Drawing.Size(155, 39);
            this.viewNotesBTN.TabIndex = 30;
            this.viewNotesBTN.Text = "VIEW NOTES";
            this.viewNotesBTN.UseVisualStyleBackColor = false;
            this.viewNotesBTN.Click += new System.EventHandler(this.viewNotesBTN_Click);
            // 
            // clearTxTBTB
            // 
            this.clearTxTBTB.BackColor = System.Drawing.Color.OldLace;
            this.clearTxTBTB.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.clearTxTBTB.ForeColor = System.Drawing.Color.SaddleBrown;
            this.clearTxTBTB.Location = new System.Drawing.Point(624, 436);
            this.clearTxTBTB.Name = "clearTxTBTB";
            this.clearTxTBTB.Size = new System.Drawing.Size(155, 39);
            this.clearTxTBTB.TabIndex = 31;
            this.clearTxTBTB.Text = "CLEAR";
            this.clearTxTBTB.UseVisualStyleBackColor = false;
            this.clearTxTBTB.Click += new System.EventHandler(this.clearTxTBTB_Click);
            // 
            // writeimage
            // 
            this.writeimage.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("writeimage.BackgroundImage")));
            this.writeimage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.writeimage.Location = new System.Drawing.Point(624, 233);
            this.writeimage.Name = "writeimage";
            this.writeimage.Size = new System.Drawing.Size(155, 138);
            this.writeimage.TabIndex = 32;
            // 
            // logoutBtn
            // 
            this.logoutBtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("logoutBtn.BackgroundImage")));
            this.logoutBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.logoutBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.logoutBtn.Location = new System.Drawing.Point(648, 178);
            this.logoutBtn.Name = "logoutBtn";
            this.logoutBtn.Size = new System.Drawing.Size(36, 35);
            this.logoutBtn.TabIndex = 13;
            this.logoutBtn.MouseClick += new System.Windows.Forms.MouseEventHandler(this.logoutBtn_MouseClick);
            // 
            // MainScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SeaShell;
            this.ClientSize = new System.Drawing.Size(816, 612);
            this.Controls.Add(this.logoutBtn);
            this.Controls.Add(this.writeimage);
            this.Controls.Add(this.clearTxTBTB);
            this.Controls.Add(this.viewNotesBTN);
            this.Controls.Add(this.saveNoteBTN);
            this.Controls.Add(this.footer);
            this.Controls.Add(this.notesTxT);
            this.Controls.Add(this.notedesc);
            this.Controls.Add(this.noteTitletxt);
            this.Controls.Add(this.notetitle);
            this.Controls.Add(this.noteTypetxt);
            this.Controls.Add(this.notetype);
            this.Controls.Add(this.logoutlabel);
            this.Controls.Add(this.line);
            this.Controls.Add(this.img2);
            this.Controls.Add(this.fetchusername);
            this.Controls.Add(this.logo2);
            this.Controls.Add(this.header2);
            this.Controls.Add(this.header1);
            this.Controls.Add(this.logo1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "MainScreen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dashboard (Sticky Notes)";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Panel logo1;
        private Label header2;
        private Label header1;
        private Panel logo2;
        private Label fetchusername;
        private Panel img2;
        private Panel line;
        private Label logoutlabel;
        private Label notetype;
        private ComboBox noteTypetxt;
        private Label notetitle;
        private TextBox noteTitletxt;
        private Label notedesc;
        private RichTextBox notesTxT;
        private Label footer;
        private Button saveNoteBTN;
        private Button viewNotesBTN;
        private Button clearTxTBTB;
        private Panel writeimage;
        private Panel logoutBtn;
    }
}