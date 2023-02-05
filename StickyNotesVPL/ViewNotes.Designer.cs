namespace StickyNotesVPL
{
    partial class ViewNotes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ViewNotes));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.footer = new System.Windows.Forms.Label();
            this.logo1 = new System.Windows.Forms.Panel();
            this.header2 = new System.Windows.Forms.Label();
            this.header1 = new System.Windows.Forms.Label();
            this.line = new System.Windows.Forms.Panel();
            this.notesDGV = new System.Windows.Forms.DataGridView();
            this.closeBtn = new System.Windows.Forms.Button();
            this.viewNotesLabel = new System.Windows.Forms.Label();
            this.viewImg = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.updatelabel = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.deleteBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.notesDGV)).BeginInit();
            this.SuspendLayout();
            // 
            // footer
            // 
            this.footer.AutoSize = true;
            this.footer.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.footer.ForeColor = System.Drawing.Color.SaddleBrown;
            this.footer.Location = new System.Drawing.Point(169, 510);
            this.footer.Name = "footer";
            this.footer.Size = new System.Drawing.Size(296, 20);
            this.footer.TabIndex = 29;
            this.footer.Text = "Muhammad Salman VPL Semester Project";
            // 
            // logo1
            // 
            this.logo1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("logo1.BackgroundImage")));
            this.logo1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.logo1.Location = new System.Drawing.Point(12, 12);
            this.logo1.Name = "logo1";
            this.logo1.Size = new System.Drawing.Size(150, 144);
            this.logo1.TabIndex = 30;
            // 
            // header2
            // 
            this.header2.AutoSize = true;
            this.header2.Font = new System.Drawing.Font("Segoe Script", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.header2.ForeColor = System.Drawing.Color.SaddleBrown;
            this.header2.Location = new System.Drawing.Point(298, 123);
            this.header2.Name = "header2";
            this.header2.Size = new System.Drawing.Size(196, 33);
            this.header2.TabIndex = 32;
            this.header2.Text = "VIEW your notes";
            // 
            // header1
            // 
            this.header1.AutoSize = true;
            this.header1.Font = new System.Drawing.Font("Segoe Script", 36F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.header1.ForeColor = System.Drawing.Color.SaddleBrown;
            this.header1.Location = new System.Drawing.Point(169, 60);
            this.header1.Name = "header1";
            this.header1.Size = new System.Drawing.Size(340, 76);
            this.header1.TabIndex = 31;
            this.header1.Text = "Sticky Notes";
            // 
            // line
            // 
            this.line.BackColor = System.Drawing.Color.SaddleBrown;
            this.line.Location = new System.Drawing.Point(0, 164);
            this.line.Name = "line";
            this.line.Size = new System.Drawing.Size(626, 5);
            this.line.TabIndex = 33;
            // 
            // notesDGV
            // 
            this.notesDGV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.notesDGV.BackgroundColor = System.Drawing.Color.Linen;
            this.notesDGV.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleVertical;
            this.notesDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Linen;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.SaddleBrown;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Sienna;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FloralWhite;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.notesDGV.DefaultCellStyle = dataGridViewCellStyle1;
            this.notesDGV.GridColor = System.Drawing.Color.Linen;
            this.notesDGV.Location = new System.Drawing.Point(12, 258);
            this.notesDGV.Name = "notesDGV";
            this.notesDGV.RowTemplate.Height = 25;
            this.notesDGV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.notesDGV.Size = new System.Drawing.Size(601, 194);
            this.notesDGV.TabIndex = 34;
            this.notesDGV.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.notesDGV_CellDoubleClick);
            // 
            // closeBtn
            // 
            this.closeBtn.BackColor = System.Drawing.Color.FloralWhite;
            this.closeBtn.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.closeBtn.ForeColor = System.Drawing.Color.SaddleBrown;
            this.closeBtn.Location = new System.Drawing.Point(510, 465);
            this.closeBtn.Name = "closeBtn";
            this.closeBtn.Size = new System.Drawing.Size(103, 33);
            this.closeBtn.TabIndex = 35;
            this.closeBtn.Text = "CLOSE";
            this.closeBtn.UseVisualStyleBackColor = false;
            this.closeBtn.Click += new System.EventHandler(this.closeBtn_Click);
            // 
            // viewNotesLabel
            // 
            this.viewNotesLabel.AutoSize = true;
            this.viewNotesLabel.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.viewNotesLabel.ForeColor = System.Drawing.Color.SaddleBrown;
            this.viewNotesLabel.Location = new System.Drawing.Point(41, 180);
            this.viewNotesLabel.Name = "viewNotesLabel";
            this.viewNotesLabel.Size = new System.Drawing.Size(356, 25);
            this.viewNotesLabel.TabIndex = 36;
            this.viewNotesLabel.Text = "Double Click Cell/Row to UPDATE a NOTE";
            // 
            // viewImg
            // 
            this.viewImg.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("viewImg.BackgroundImage")));
            this.viewImg.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.viewImg.Location = new System.Drawing.Point(515, 44);
            this.viewImg.Name = "viewImg";
            this.viewImg.Size = new System.Drawing.Size(98, 92);
            this.viewImg.TabIndex = 37;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.SaddleBrown;
            this.label1.Location = new System.Drawing.Point(41, 222);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(303, 25);
            this.label1.TabIndex = 38;
            this.label1.Text = "* Select Cell/Row to DELETE a NOTE";
            // 
            // updatelabel
            // 
            this.updatelabel.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("updatelabel.BackgroundImage")));
            this.updatelabel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.updatelabel.Location = new System.Drawing.Point(12, 180);
            this.updatelabel.Name = "updatelabel";
            this.updatelabel.Size = new System.Drawing.Size(23, 24);
            this.updatelabel.TabIndex = 47;
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Location = new System.Drawing.Point(12, 222);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(23, 24);
            this.panel1.TabIndex = 48;
            // 
            // deleteBtn
            // 
            this.deleteBtn.BackColor = System.Drawing.Color.FloralWhite;
            this.deleteBtn.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.deleteBtn.ForeColor = System.Drawing.Color.SaddleBrown;
            this.deleteBtn.Location = new System.Drawing.Point(12, 465);
            this.deleteBtn.Name = "deleteBtn";
            this.deleteBtn.Size = new System.Drawing.Size(103, 33);
            this.deleteBtn.TabIndex = 49;
            this.deleteBtn.Text = "DELETE";
            this.deleteBtn.UseVisualStyleBackColor = false;
            this.deleteBtn.Click += new System.EventHandler(this.deleteBtn_Click);
            // 
            // ViewNotes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SeaShell;
            this.ClientSize = new System.Drawing.Size(625, 539);
            this.Controls.Add(this.deleteBtn);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.updatelabel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.viewImg);
            this.Controls.Add(this.viewNotesLabel);
            this.Controls.Add(this.closeBtn);
            this.Controls.Add(this.notesDGV);
            this.Controls.Add(this.line);
            this.Controls.Add(this.header2);
            this.Controls.Add(this.header1);
            this.Controls.Add(this.logo1);
            this.Controls.Add(this.footer);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "ViewNotes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "View Notes (Sticky Notes)";
            ((System.ComponentModel.ISupportInitialize)(this.notesDGV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label footer;
        private Panel logo1;
        private Label header2;
        private Label header1;
        private Panel line;
        private Button closeBtn;
        private Label viewNotesLabel;
        private Panel viewImg;
        private Label label1;
        private Panel updatelabel;
        private Panel panel1;
        private Button deleteBtn;
        private DataGridView notesDGV;
    }
}