namespace AutomotiveReservation
{
    partial class ListData
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
            this.DTPDate = new System.Windows.Forms.DateTimePicker();
            this.CbxLocation = new System.Windows.Forms.ComboBox();
            this.TbxName = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.LblID = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.DGVlist = new System.Windows.Forms.DataGridView();
            this.BtnCancel = new System.Windows.Forms.Button();
            this.BtnUpdate = new System.Windows.Forms.Button();
            this.BtnDone = new System.Windows.Forms.Button();
            this.CbxType = new System.Windows.Forms.ComboBox();
            this.BtnBack = new System.Windows.Forms.Button();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.DGVlist)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
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
            this.DTPDate.Location = new System.Drawing.Point(532, 151);
            this.DTPDate.Name = "DTPDate";
            this.DTPDate.Size = new System.Drawing.Size(200, 33);
            this.DTPDate.TabIndex = 19;
            this.DTPDate.ValueChanged += new System.EventHandler(this.DTPDate_ValueChanged);
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
            this.CbxLocation.Location = new System.Drawing.Point(532, 102);
            this.CbxLocation.Name = "CbxLocation";
            this.CbxLocation.Size = new System.Drawing.Size(200, 33);
            this.CbxLocation.TabIndex = 18;
            // 
            // TbxName
            // 
            this.TbxName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.TbxName.Font = new System.Drawing.Font("Segoe UI", 14.25F);
            this.TbxName.Location = new System.Drawing.Point(133, 102);
            this.TbxName.Name = "TbxName";
            this.TbxName.Size = new System.Drawing.Size(200, 33);
            this.TbxName.TabIndex = 10;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold);
            this.label6.Location = new System.Drawing.Point(432, 151);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(81, 29);
            this.label6.TabIndex = 17;
            this.label6.Text = "Date: ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold);
            this.label5.Location = new System.Drawing.Point(400, 99);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(126, 32);
            this.label5.TabIndex = 16;
            this.label5.Text = "Location :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold);
            this.label4.Location = new System.Drawing.Point(33, 151);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(82, 32);
            this.label4.TabIndex = 15;
            this.label4.Text = "Type: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(32, 103);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 32);
            this.label2.TabIndex = 14;
            this.label2.Text = "Name :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(32, 60);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 32);
            this.label3.TabIndex = 13;
            this.label3.Text = "ID :";
            // 
            // LblID
            // 
            this.LblID.AutoSize = true;
            this.LblID.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold);
            this.LblID.Location = new System.Drawing.Point(91, 60);
            this.LblID.Name = "LblID";
            this.LblID.Size = new System.Drawing.Size(28, 32);
            this.LblID.TabIndex = 12;
            this.LblID.Text = "0";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Palatino Linotype", 24.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(267, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(302, 45);
            this.label1.TabIndex = 20;
            this.label1.Text = "List of Reservation";
            // 
            // DGVlist
            // 
            this.DGVlist.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVlist.Location = new System.Drawing.Point(28, 279);
            this.DGVlist.Name = "DGVlist";
            this.DGVlist.Size = new System.Drawing.Size(745, 248);
            this.DGVlist.TabIndex = 21;
            this.DGVlist.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGVlist_CellContentClick);
            // 
            // BtnCancel
            // 
            this.BtnCancel.BackColor = System.Drawing.Color.Red;
            this.BtnCancel.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.BtnCancel.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Red;
            this.BtnCancel.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.BtnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnCancel.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold);
            this.BtnCancel.Location = new System.Drawing.Point(666, 214);
            this.BtnCancel.Name = "BtnCancel";
            this.BtnCancel.Size = new System.Drawing.Size(107, 40);
            this.BtnCancel.TabIndex = 22;
            this.BtnCancel.Text = "CANCEL";
            this.BtnCancel.UseVisualStyleBackColor = false;
            this.BtnCancel.Click += new System.EventHandler(this.BtnCancel_Click);
            // 
            // BtnUpdate
            // 
            this.BtnUpdate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.BtnUpdate.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.BtnUpdate.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.BtnUpdate.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.BtnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnUpdate.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnUpdate.Location = new System.Drawing.Point(555, 214);
            this.BtnUpdate.Name = "BtnUpdate";
            this.BtnUpdate.Size = new System.Drawing.Size(105, 40);
            this.BtnUpdate.TabIndex = 23;
            this.BtnUpdate.Text = "UPDATE";
            this.BtnUpdate.UseVisualStyleBackColor = false;
            this.BtnUpdate.Click += new System.EventHandler(this.BtnUpdate_Click);
            // 
            // BtnDone
            // 
            this.BtnDone.BackColor = System.Drawing.Color.Green;
            this.BtnDone.FlatAppearance.BorderColor = System.Drawing.Color.Green;
            this.BtnDone.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Green;
            this.BtnDone.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Green;
            this.BtnDone.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnDone.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnDone.Location = new System.Drawing.Point(444, 214);
            this.BtnDone.Name = "BtnDone";
            this.BtnDone.Size = new System.Drawing.Size(105, 40);
            this.BtnDone.TabIndex = 24;
            this.BtnDone.Text = "DONE";
            this.BtnDone.UseVisualStyleBackColor = false;
            this.BtnDone.Click += new System.EventHandler(this.BtnDone_Click);
            // 
            // CbxType
            // 
            this.CbxType.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.CbxType.Font = new System.Drawing.Font("Segoe UI", 14.25F);
            this.CbxType.FormattingEnabled = true;
            this.CbxType.Items.AddRange(new object[] {
            "Motor",
            "Car"});
            this.CbxType.Location = new System.Drawing.Point(133, 154);
            this.CbxType.Name = "CbxType";
            this.CbxType.Size = new System.Drawing.Size(200, 33);
            this.CbxType.TabIndex = 25;
            // 
            // BtnBack
            // 
            this.BtnBack.BackColor = System.Drawing.Color.Transparent;
            this.BtnBack.BackgroundImage = global::AutomotiveReservation.Properties.Resources.backts;
            this.BtnBack.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.BtnBack.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.BtnBack.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.BtnBack.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.BtnBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnBack.Location = new System.Drawing.Point(-3, -2);
            this.BtnBack.Name = "BtnBack";
            this.BtnBack.Size = new System.Drawing.Size(38, 23);
            this.BtnBack.TabIndex = 113;
            this.BtnBack.UseVisualStyleBackColor = false;
            this.BtnBack.Click += new System.EventHandler(this.BtnBack_Click);
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::AutomotiveReservation.Properties.Resources.vecteezy_motorcycle_png_graphic_clipart_design_19907054;
            this.pictureBox3.Location = new System.Drawing.Point(212, 8);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(64, 51);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 26;
            this.pictureBox3.TabStop = false;
            // 
            // ListData
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.ClientSize = new System.Drawing.Size(786, 538);
            this.Controls.Add(this.BtnBack);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.CbxType);
            this.Controls.Add(this.BtnDone);
            this.Controls.Add(this.BtnUpdate);
            this.Controls.Add(this.BtnCancel);
            this.Controls.Add(this.DGVlist);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.DTPDate);
            this.Controls.Add(this.CbxLocation);
            this.Controls.Add(this.TbxName);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.LblID);
            this.Name = "ListData";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.ListData_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DGVlist)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker DTPDate;
        private System.Windows.Forms.ComboBox CbxLocation;
        private System.Windows.Forms.TextBox TbxName;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label LblID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView DGVlist;
        private System.Windows.Forms.Button BtnCancel;
        private System.Windows.Forms.Button BtnUpdate;
        private System.Windows.Forms.Button BtnDone;
        private System.Windows.Forms.ComboBox CbxType;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Button BtnBack;
    }
}