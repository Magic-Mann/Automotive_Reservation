namespace AutomotiveReservation
{
    partial class Reservation
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
            this.LblID = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.TbxName = new System.Windows.Forms.TextBox();
            this.CbxLocation = new System.Windows.Forms.ComboBox();
            this.DTPDate = new System.Windows.Forms.DateTimePicker();
            this.BtnReserve = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.vIEWToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rECORDSToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.CbxType = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Palatino Linotype", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(174, 61);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(558, 65);
            this.label1.TabIndex = 1;
            this.label1.Text = "Automotive Reservation";
            // 
            // LblID
            // 
            this.LblID.AutoSize = true;
            this.LblID.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold);
            this.LblID.Location = new System.Drawing.Point(188, 161);
            this.LblID.Name = "LblID";
            this.LblID.Size = new System.Drawing.Size(28, 32);
            this.LblID.TabIndex = 2;
            this.LblID.Text = "0";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(133, 161);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 32);
            this.label3.TabIndex = 3;
            this.label3.Text = "ID :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(78, 232);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 32);
            this.label2.TabIndex = 4;
            this.label2.Text = "Name :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold);
            this.label5.Location = new System.Drawing.Point(47, 353);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(126, 32);
            this.label5.TabIndex = 6;
            this.label5.Text = "Location :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold);
            this.label6.Location = new System.Drawing.Point(73, 420);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(81, 29);
            this.label6.TabIndex = 7;
            this.label6.Text = "Date: ";
            // 
            // TbxName
            // 
            this.TbxName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.TbxName.Font = new System.Drawing.Font("Segoe UI", 14.25F);
            this.TbxName.Location = new System.Drawing.Point(179, 231);
            this.TbxName.Name = "TbxName";
            this.TbxName.Size = new System.Drawing.Size(200, 33);
            this.TbxName.TabIndex = 1;
            // 
            // CbxLocation
            // 
            this.CbxLocation.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.CbxLocation.Font = new System.Drawing.Font("Segoe UI", 14.25F);
            this.CbxLocation.FormattingEnabled = true;
            this.CbxLocation.Items.AddRange(new object[] {
            "Amaga",
            "Ambao",
            "An-an",
            "Baculod",
            "Biasong",
            "Bugho (Green Valley)",
            "Cabulisan",
            "Cat-iwing",
            "District I (Poblacion)",
            "District II (Poblacion)",
            "District III (Poblacion)",
            "Hubasan",
            "Lungsodaan",
            "Navalita",
            "Plaridel",
            "Sabang",
            "Sagbok",
            "Other"});
            this.CbxLocation.Location = new System.Drawing.Point(179, 356);
            this.CbxLocation.Name = "CbxLocation";
            this.CbxLocation.Size = new System.Drawing.Size(200, 33);
            this.CbxLocation.TabIndex = 8;
            // 
            // DTPDate
            // 
            this.DTPDate.CalendarFont = new System.Drawing.Font("Segoe UI", 14.25F);
            this.DTPDate.CalendarForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.DTPDate.CalendarMonthBackground = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.DTPDate.CalendarTitleBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.DTPDate.CalendarTitleForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.DTPDate.CalendarTrailingForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.DTPDate.Font = new System.Drawing.Font("Segoe UI", 14.25F);
            this.DTPDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DTPDate.Location = new System.Drawing.Point(179, 417);
            this.DTPDate.Name = "DTPDate";
            this.DTPDate.Size = new System.Drawing.Size(200, 33);
            this.DTPDate.TabIndex = 9;
            this.DTPDate.ValueChanged += new System.EventHandler(this.DTPDate_ValueChanged);
            // 
            // BtnReserve
            // 
            this.BtnReserve.BackColor = System.Drawing.Color.Green;
            this.BtnReserve.FlatAppearance.BorderColor = System.Drawing.Color.Green;
            this.BtnReserve.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Green;
            this.BtnReserve.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Green;
            this.BtnReserve.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnReserve.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.BtnReserve.Location = new System.Drawing.Point(587, 548);
            this.BtnReserve.Name = "BtnReserve";
            this.BtnReserve.Size = new System.Drawing.Size(133, 56);
            this.BtnReserve.TabIndex = 10;
            this.BtnReserve.Text = "Reserve";
            this.BtnReserve.UseVisualStyleBackColor = false;
            this.BtnReserve.Click += new System.EventHandler(this.BtnReserve_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.vIEWToolStripMenuItem,
            this.rECORDSToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(873, 34);
            this.menuStrip1.TabIndex = 11;
            this.menuStrip1.Text = "list";
            // 
            // vIEWToolStripMenuItem
            // 
            this.vIEWToolStripMenuItem.Font = new System.Drawing.Font("Palatino Linotype", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.vIEWToolStripMenuItem.Name = "vIEWToolStripMenuItem";
            this.vIEWToolStripMenuItem.Size = new System.Drawing.Size(77, 30);
            this.vIEWToolStripMenuItem.Text = "VIEW";
            this.vIEWToolStripMenuItem.Click += new System.EventHandler(this.vIEWToolStripMenuItem_Click);
            // 
            // rECORDSToolStripMenuItem
            // 
            this.rECORDSToolStripMenuItem.Font = new System.Drawing.Font("Palatino Linotype", 14.25F, System.Drawing.FontStyle.Bold);
            this.rECORDSToolStripMenuItem.Name = "rECORDSToolStripMenuItem";
            this.rECORDSToolStripMenuItem.Size = new System.Drawing.Size(122, 30);
            this.rECORDSToolStripMenuItem.Text = "RECORDS";
            this.rECORDSToolStripMenuItem.Click += new System.EventHandler(this.rECORDSToolStripMenuItem_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::AutomotiveReservation.Properties.Resources.vecteezy_motorcycle_png_graphic_clipart_design_19907054;
            this.pictureBox1.Location = new System.Drawing.Point(473, 206);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(363, 244);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // CbxType
            // 
            this.CbxType.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.CbxType.Font = new System.Drawing.Font("Segoe UI", 14.25F);
            this.CbxType.FormattingEnabled = true;
            this.CbxType.Items.AddRange(new object[] {
            "Motor",
            "Car"});
            this.CbxType.Location = new System.Drawing.Point(179, 293);
            this.CbxType.Name = "CbxType";
            this.CbxType.Size = new System.Drawing.Size(200, 33);
            this.CbxType.TabIndex = 27;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold);
            this.label4.Location = new System.Drawing.Point(79, 290);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(82, 32);
            this.label4.TabIndex = 26;
            this.label4.Text = "Type: ";
            // 
            // Reservation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.ClientSize = new System.Drawing.Size(873, 660);
            this.Controls.Add(this.CbxType);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.BtnReserve);
            this.Controls.Add(this.DTPDate);
            this.Controls.Add(this.CbxLocation);
            this.Controls.Add(this.TbxName);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.LblID);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Reservation";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Reservation";
            this.Load += new System.EventHandler(this.Reservation_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label LblID;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox TbxName;
        private System.Windows.Forms.ComboBox CbxLocation;
        private System.Windows.Forms.DateTimePicker DTPDate;
        private System.Windows.Forms.Button BtnReserve;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem vIEWToolStripMenuItem;
        private System.Windows.Forms.ComboBox CbxType;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ToolStripMenuItem rECORDSToolStripMenuItem;
    }
}