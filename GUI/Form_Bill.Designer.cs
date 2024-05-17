namespace GUI
{
    partial class Form_Bill
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_Bill));
            this.dateTimePickerfromdate = new System.Windows.Forms.DateTimePicker();
            this.btntailai = new System.Windows.Forms.Button();
            this.dateTimePickertodate = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dgvHoaDon = new System.Windows.Forms.DataGridView();
            this.btnthoat = new System.Windows.Forms.Button();
            this.dgvMonAn = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHoaDon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMonAn)).BeginInit();
            this.SuspendLayout();
            // 
            // dateTimePickerfromdate
            // 
            this.dateTimePickerfromdate.CalendarMonthBackground = System.Drawing.Color.PaleVioletRed;
            this.dateTimePickerfromdate.Font = new System.Drawing.Font("Bahnschrift", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePickerfromdate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePickerfromdate.Location = new System.Drawing.Point(198, 116);
            this.dateTimePickerfromdate.Name = "dateTimePickerfromdate";
            this.dateTimePickerfromdate.Size = new System.Drawing.Size(184, 41);
            this.dateTimePickerfromdate.TabIndex = 3;
            // 
            // btntailai
            // 
            this.btntailai.BackColor = System.Drawing.Color.HotPink;
            this.btntailai.Font = new System.Drawing.Font("Bahnschrift", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btntailai.Image = ((System.Drawing.Image)(resources.GetObject("btntailai.Image")));
            this.btntailai.Location = new System.Drawing.Point(1092, 14);
            this.btntailai.Name = "btntailai";
            this.btntailai.Size = new System.Drawing.Size(91, 91);
            this.btntailai.TabIndex = 9;
            this.btntailai.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btntailai.UseVisualStyleBackColor = false;
            this.btntailai.Click += new System.EventHandler(this.btntailai_Click);
            // 
            // dateTimePickertodate
            // 
            this.dateTimePickertodate.CalendarMonthBackground = System.Drawing.Color.PaleVioletRed;
            this.dateTimePickertodate.Font = new System.Drawing.Font("Bahnschrift", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePickertodate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePickertodate.Location = new System.Drawing.Point(198, 191);
            this.dateTimePickertodate.Name = "dateTimePickertodate";
            this.dateTimePickertodate.Size = new System.Drawing.Size(184, 41);
            this.dateTimePickertodate.TabIndex = 11;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Bahnschrift", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(53, 123);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(120, 34);
            this.label1.TabIndex = 12;
            this.label1.Text = "Từ ngày ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Bahnschrift", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(53, 198);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(141, 34);
            this.label2.TabIndex = 13;
            this.label2.Text = "Đến ngày ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.PaleVioletRed;
            this.label3.Font = new System.Drawing.Font("Bahnschrift", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 30);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(370, 48);
            this.label3.TabIndex = 14;
            this.label3.Text = "Danh sách hóa đơn ";
            // 
            // dgvHoaDon
            // 
            this.dgvHoaDon.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvHoaDon.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvHoaDon.BackgroundColor = System.Drawing.Color.LightPink;
            this.dgvHoaDon.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvHoaDon.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            this.dgvHoaDon.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvHoaDon.Location = new System.Drawing.Point(20, 291);
            this.dgvHoaDon.Name = "dgvHoaDon";
            this.dgvHoaDon.RowHeadersWidth = 62;
            this.dgvHoaDon.RowTemplate.Height = 28;
            this.dgvHoaDon.Size = new System.Drawing.Size(1176, 446);
            this.dgvHoaDon.TabIndex = 15;
            this.dgvHoaDon.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvHoaDon_CellClick);
            //this.dgvHoaDon.Click += new System.EventHandler(this.dgvHoaDon_Click);
            // 
            // btnthoat
            // 
            this.btnthoat.BackColor = System.Drawing.Color.HotPink;
            this.btnthoat.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnthoat.BackgroundImage")));
            this.btnthoat.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnthoat.Font = new System.Drawing.Font("Bahnschrift", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnthoat.Location = new System.Drawing.Point(1092, 123);
            this.btnthoat.Name = "btnthoat";
            this.btnthoat.Size = new System.Drawing.Size(91, 91);
            this.btnthoat.TabIndex = 17;
            this.btnthoat.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnthoat.UseVisualStyleBackColor = false;
            this.btnthoat.Click += new System.EventHandler(this.btnthoat_Click);
            // 
            // dgvMonAn
            // 
            this.dgvMonAn.BackgroundColor = System.Drawing.Color.LightPink;
            this.dgvMonAn.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMonAn.Location = new System.Drawing.Point(599, 47);
            this.dgvMonAn.Name = "dgvMonAn";
            this.dgvMonAn.RowHeadersWidth = 62;
            this.dgvMonAn.RowTemplate.Height = 28;
            this.dgvMonAn.Size = new System.Drawing.Size(469, 238);
            this.dgvMonAn.TabIndex = 18;
            // 
            // Form_Bill
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Pink;
            this.ClientSize = new System.Drawing.Size(1208, 749);
            this.Controls.Add(this.dgvMonAn);
            this.Controls.Add(this.btnthoat);
            this.Controls.Add(this.dgvHoaDon);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dateTimePickertodate);
            this.Controls.Add(this.btntailai);
            this.Controls.Add(this.dateTimePickerfromdate);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form_Bill";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Phần mềm quản lí quán cà phê COFFEE TEA";
            this.Load += new System.EventHandler(this.Form_Bill_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvHoaDon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMonAn)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DateTimePicker dateTimePickerfromdate;
        private System.Windows.Forms.Button btntailai;
        private System.Windows.Forms.DateTimePicker dateTimePickertodate;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dgvHoaDon;
        private System.Windows.Forms.Button btnthoat;
        private System.Windows.Forms.DataGridView dgvMonAn;
    }
}