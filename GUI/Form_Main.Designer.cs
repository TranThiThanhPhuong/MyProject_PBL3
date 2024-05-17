namespace GUI
{
    partial class Form_Main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_Main));
            this.flpBan = new System.Windows.Forms.FlowLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label8 = new System.Windows.Forms.Label();
            this.numericUpDowngiamgia = new System.Windows.Forms.NumericUpDown();
            this.label7 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnthanhtoan = new System.Windows.Forms.Button();
            this.texboxtien = new System.Windows.Forms.TextBox();
            this.numericUpDownsoluongmon = new System.Windows.Forms.NumericUpDown();
            this.comboBoxDanhMuc = new System.Windows.Forms.ComboBox();
            this.comboBoxMatHang = new System.Windows.Forms.ComboBox();
            this.btnthemmon = new System.Windows.Forms.Button();
            this.btnchuyenban = new System.Windows.Forms.Button();
            this.comboBoxchuyenban = new System.Windows.Forms.ComboBox();
            this.listViewHoaDon = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnthoat = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDowngiamgia)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownsoluongmon)).BeginInit();
            this.SuspendLayout();
            // 
            // flpBan
            // 
            this.flpBan.AutoScroll = true;
            this.flpBan.BackColor = System.Drawing.Color.LightPink;
            this.flpBan.Location = new System.Drawing.Point(8, 12);
            this.flpBan.Name = "flpBan";
            this.flpBan.Size = new System.Drawing.Size(649, 869);
            this.flpBan.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.numericUpDowngiamgia);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.btnthanhtoan);
            this.panel1.Controls.Add(this.texboxtien);
            this.panel1.Controls.Add(this.numericUpDownsoluongmon);
            this.panel1.Controls.Add(this.comboBoxDanhMuc);
            this.panel1.Controls.Add(this.comboBoxMatHang);
            this.panel1.Controls.Add(this.btnthemmon);
            this.panel1.Controls.Add(this.btnchuyenban);
            this.panel1.Controls.Add(this.comboBoxchuyenban);
            this.panel1.Controls.Add(this.listViewHoaDon);
            this.panel1.Location = new System.Drawing.Point(663, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(808, 783);
            this.panel1.TabIndex = 2;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.HotPink;
            this.label8.Font = new System.Drawing.Font("Arial Narrow", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.MediumVioletRed;
            this.label8.Location = new System.Drawing.Point(156, 742);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(121, 31);
            this.label8.TabIndex = 14;
            this.label8.Text = "Tổng tiền ";
            // 
            // numericUpDowngiamgia
            // 
            this.numericUpDowngiamgia.BackColor = System.Drawing.Color.LavenderBlush;
            this.numericUpDowngiamgia.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericUpDowngiamgia.Location = new System.Drawing.Point(326, 693);
            this.numericUpDowngiamgia.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
            this.numericUpDowngiamgia.Name = "numericUpDowngiamgia";
            this.numericUpDowngiamgia.Size = new System.Drawing.Size(225, 35);
            this.numericUpDowngiamgia.TabIndex = 13;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.HotPink;
            this.label7.Font = new System.Drawing.Font("Arial Narrow", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.MediumVioletRed;
            this.label7.Location = new System.Drawing.Point(157, 697);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(120, 31);
            this.label7.TabIndex = 12;
            this.label7.Text = "Giảm giá  ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.HotPink;
            this.label1.Font = new System.Drawing.Font("Arial Narrow", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.MediumVioletRed;
            this.label1.Location = new System.Drawing.Point(24, 108);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(111, 31);
            this.label1.TabIndex = 11;
            this.label1.Text = "Số lượng";
            // 
            // btnthanhtoan
            // 
            this.btnthanhtoan.BackColor = System.Drawing.Color.HotPink;
            this.btnthanhtoan.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnthanhtoan.ForeColor = System.Drawing.Color.DeepPink;
            this.btnthanhtoan.Location = new System.Drawing.Point(623, 700);
            this.btnthanhtoan.Name = "btnthanhtoan";
            this.btnthanhtoan.Size = new System.Drawing.Size(180, 73);
            this.btnthanhtoan.TabIndex = 10;
            this.btnthanhtoan.Text = "Thanh toán";
            this.btnthanhtoan.UseVisualStyleBackColor = false;
            this.btnthanhtoan.Click += new System.EventHandler(this.btnthanhtoan_Click);
            // 
            // texboxtien
            // 
            this.texboxtien.BackColor = System.Drawing.Color.LavenderBlush;
            this.texboxtien.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.texboxtien.Location = new System.Drawing.Point(326, 740);
            this.texboxtien.Name = "texboxtien";
            this.texboxtien.ReadOnly = true;
            this.texboxtien.Size = new System.Drawing.Size(225, 33);
            this.texboxtien.TabIndex = 9;
            this.texboxtien.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // numericUpDownsoluongmon
            // 
            this.numericUpDownsoluongmon.BackColor = System.Drawing.Color.LavenderBlush;
            this.numericUpDownsoluongmon.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericUpDownsoluongmon.Location = new System.Drawing.Point(163, 104);
            this.numericUpDownsoluongmon.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
            this.numericUpDownsoluongmon.Name = "numericUpDownsoluongmon";
            this.numericUpDownsoluongmon.Size = new System.Drawing.Size(155, 35);
            this.numericUpDownsoluongmon.TabIndex = 7;
            // 
            // comboBoxDanhMuc
            // 
            this.comboBoxDanhMuc.BackColor = System.Drawing.Color.LavenderBlush;
            this.comboBoxDanhMuc.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxDanhMuc.FormattingEnabled = true;
            this.comboBoxDanhMuc.Location = new System.Drawing.Point(187, 6);
            this.comboBoxDanhMuc.Name = "comboBoxDanhMuc";
            this.comboBoxDanhMuc.Size = new System.Drawing.Size(247, 37);
            this.comboBoxDanhMuc.TabIndex = 5;
            this.comboBoxDanhMuc.SelectedIndexChanged += new System.EventHandler(this.comboBoxDanhMuc_SelectedIndexChanged);
            // 
            // comboBoxMatHang
            // 
            this.comboBoxMatHang.BackColor = System.Drawing.Color.LavenderBlush;
            this.comboBoxMatHang.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxMatHang.FormattingEnabled = true;
            this.comboBoxMatHang.Location = new System.Drawing.Point(187, 56);
            this.comboBoxMatHang.Name = "comboBoxMatHang";
            this.comboBoxMatHang.Size = new System.Drawing.Size(247, 37);
            this.comboBoxMatHang.TabIndex = 4;
            this.comboBoxMatHang.SelectedIndexChanged += new System.EventHandler(this.comboBoxMatHang_SelectedIndexChanged);
            // 
            // btnthemmon
            // 
            this.btnthemmon.BackColor = System.Drawing.Color.HotPink;
            this.btnthemmon.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnthemmon.ForeColor = System.Drawing.Color.DeepPink;
            this.btnthemmon.Location = new System.Drawing.Point(14, 6);
            this.btnthemmon.Name = "btnthemmon";
            this.btnthemmon.Size = new System.Drawing.Size(155, 87);
            this.btnthemmon.TabIndex = 3;
            this.btnthemmon.Text = "Thêm ";
            this.btnthemmon.UseVisualStyleBackColor = false;
            this.btnthemmon.Click += new System.EventHandler(this.btnthemmon_Click);
            // 
            // btnchuyenban
            // 
            this.btnchuyenban.BackColor = System.Drawing.Color.HotPink;
            this.btnchuyenban.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnchuyenban.ForeColor = System.Drawing.Color.DeepPink;
            this.btnchuyenban.Location = new System.Drawing.Point(440, 6);
            this.btnchuyenban.Name = "btnchuyenban";
            this.btnchuyenban.Size = new System.Drawing.Size(148, 87);
            this.btnchuyenban.TabIndex = 1;
            this.btnchuyenban.Text = "Chuyển bàn";
            this.btnchuyenban.UseVisualStyleBackColor = false;
            this.btnchuyenban.Click += new System.EventHandler(this.btnchuyenban_Click);
            // 
            // comboBoxchuyenban
            // 
            this.comboBoxchuyenban.BackColor = System.Drawing.Color.LavenderBlush;
            this.comboBoxchuyenban.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxchuyenban.FormattingEnabled = true;
            this.comboBoxchuyenban.Location = new System.Drawing.Point(594, 35);
            this.comboBoxchuyenban.Name = "comboBoxchuyenban";
            this.comboBoxchuyenban.Size = new System.Drawing.Size(209, 37);
            this.comboBoxchuyenban.TabIndex = 2;
            // 
            // listViewHoaDon
            // 
            this.listViewHoaDon.BackColor = System.Drawing.Color.LightPink;
            this.listViewHoaDon.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4});
            this.listViewHoaDon.GridLines = true;
            this.listViewHoaDon.Location = new System.Drawing.Point(0, 178);
            this.listViewHoaDon.Name = "listViewHoaDon";
            this.listViewHoaDon.Size = new System.Drawing.Size(803, 498);
            this.listViewHoaDon.TabIndex = 0;
            this.listViewHoaDon.UseCompatibleStateImageBehavior = false;
            this.listViewHoaDon.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Tên mặt hàng";
            this.columnHeader1.Width = 170;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Số lượng ";
            this.columnHeader2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader2.Width = 80;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Đơn giá";
            this.columnHeader3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader3.Width = 80;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Thành tiền";
            this.columnHeader4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader4.Width = 200;
            // 
            // btnthoat
            // 
            this.btnthoat.BackColor = System.Drawing.Color.HotPink;
            this.btnthoat.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnthoat.BackgroundImage")));
            this.btnthoat.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnthoat.Font = new System.Drawing.Font("Bahnschrift", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnthoat.Location = new System.Drawing.Point(1382, 801);
            this.btnthoat.Name = "btnthoat";
            this.btnthoat.Size = new System.Drawing.Size(89, 89);
            this.btnthoat.TabIndex = 3;
            this.btnthoat.UseVisualStyleBackColor = false;
            this.btnthoat.Click += new System.EventHandler(this.btnthoat_Click);
            // 
            // Form_Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.Pink;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1483, 893);
            this.Controls.Add(this.btnthoat);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.flpBan);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form_Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Phần mềm quản lí quán cà phê COFFEE TEA";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDowngiamgia)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownsoluongmon)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flpBan;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.NumericUpDown numericUpDowngiamgia;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnthanhtoan;
        private System.Windows.Forms.TextBox texboxtien;
        private System.Windows.Forms.NumericUpDown numericUpDownsoluongmon;
        private System.Windows.Forms.ComboBox comboBoxDanhMuc;
        private System.Windows.Forms.ComboBox comboBoxMatHang;
        private System.Windows.Forms.Button btnthemmon;
        private System.Windows.Forms.Button btnchuyenban;
        private System.Windows.Forms.ComboBox comboBoxchuyenban;
        private System.Windows.Forms.ListView listViewHoaDon;
        public System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.Button btnthoat;
    }
}