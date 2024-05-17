namespace GUI
{
    partial class Form_Account
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_Account));
            this.comboBoxtaikhoan = new System.Windows.Forms.ComboBox();
            this.txbtenhienthi = new System.Windows.Forms.TextBox();
            this.txbtendangnhap = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnthem = new System.Windows.Forms.Button();
            this.btnxoa = new System.Windows.Forms.Button();
            this.tbnsua = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.txbtimkiem = new System.Windows.Forms.TextBox();
            this.btntimkiem = new System.Windows.Forms.Button();
            this.dgvAccount = new System.Windows.Forms.DataGridView();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.button2 = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAccount)).BeginInit();
            this.SuspendLayout();
            // 
            // comboBoxtaikhoan
            // 
            this.comboBoxtaikhoan.BackColor = System.Drawing.Color.PaleVioletRed;
            this.comboBoxtaikhoan.Font = new System.Drawing.Font("Bahnschrift", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxtaikhoan.ForeColor = System.Drawing.Color.Black;
            this.comboBoxtaikhoan.FormattingEnabled = true;
            this.comboBoxtaikhoan.Location = new System.Drawing.Point(211, 133);
            this.comboBoxtaikhoan.Name = "comboBoxtaikhoan";
            this.comboBoxtaikhoan.Size = new System.Drawing.Size(391, 35);
            this.comboBoxtaikhoan.TabIndex = 4;
            // 
            // txbtenhienthi
            // 
            this.txbtenhienthi.BackColor = System.Drawing.Color.PaleVioletRed;
            this.txbtenhienthi.Font = new System.Drawing.Font("Bahnschrift", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbtenhienthi.ForeColor = System.Drawing.Color.Black;
            this.txbtenhienthi.Location = new System.Drawing.Point(211, 69);
            this.txbtenhienthi.Name = "txbtenhienthi";
            this.txbtenhienthi.Size = new System.Drawing.Size(391, 34);
            this.txbtenhienthi.TabIndex = 3;
            // 
            // txbtendangnhap
            // 
            this.txbtendangnhap.BackColor = System.Drawing.Color.PaleVioletRed;
            this.txbtendangnhap.Font = new System.Drawing.Font("Bahnschrift", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbtendangnhap.ForeColor = System.Drawing.Color.Black;
            this.txbtendangnhap.Location = new System.Drawing.Point(211, 5);
            this.txbtendangnhap.Name = "txbtendangnhap";
            this.txbtendangnhap.Size = new System.Drawing.Size(391, 34);
            this.txbtendangnhap.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.PaleVioletRed;
            this.label4.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(3, 10);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(166, 29);
            this.label4.TabIndex = 4;
            this.label4.Text = "Tên đăng nhập";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.PaleVioletRed;
            this.label3.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(3, 139);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(163, 29);
            this.label3.TabIndex = 3;
            this.label3.Text = "Loại tài khoản";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.PaleVioletRed;
            this.label2.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(3, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(134, 29);
            this.label2.TabIndex = 2;
            this.label2.Text = "Tên hiển thị";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.txbtendangnhap);
            this.panel1.Controls.Add(this.comboBoxtaikhoan);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.txbtenhienthi);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(611, 214);
            this.panel1.TabIndex = 8;
            // 
            // btnthem
            // 
            this.btnthem.BackColor = System.Drawing.Color.HotPink;
            this.btnthem.Font = new System.Drawing.Font("Bahnschrift", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnthem.Image = ((System.Drawing.Image)(resources.GetObject("btnthem.Image")));
            this.btnthem.Location = new System.Drawing.Point(1089, 119);
            this.btnthem.Name = "btnthem";
            this.btnthem.Size = new System.Drawing.Size(91, 91);
            this.btnthem.TabIndex = 9;
            this.btnthem.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnthem.UseVisualStyleBackColor = false;
            this.btnthem.Click += new System.EventHandler(this.btnthem_Click_1);
            // 
            // btnxoa
            // 
            this.btnxoa.BackColor = System.Drawing.Color.HotPink;
            this.btnxoa.Font = new System.Drawing.Font("Bahnschrift", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnxoa.Image = ((System.Drawing.Image)(resources.GetObject("btnxoa.Image")));
            this.btnxoa.Location = new System.Drawing.Point(973, 12);
            this.btnxoa.Name = "btnxoa";
            this.btnxoa.Size = new System.Drawing.Size(91, 91);
            this.btnxoa.TabIndex = 10;
            this.btnxoa.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnxoa.UseVisualStyleBackColor = false;
            this.btnxoa.Click += new System.EventHandler(this.btnxoa_Click_1);
            // 
            // tbnsua
            // 
            this.tbnsua.BackColor = System.Drawing.Color.HotPink;
            this.tbnsua.Font = new System.Drawing.Font("Bahnschrift", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbnsua.Image = ((System.Drawing.Image)(resources.GetObject("tbnsua.Image")));
            this.tbnsua.Location = new System.Drawing.Point(973, 119);
            this.tbnsua.Name = "tbnsua";
            this.tbnsua.Size = new System.Drawing.Size(91, 91);
            this.tbnsua.TabIndex = 11;
            this.tbnsua.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.tbnsua.UseVisualStyleBackColor = false;
            this.tbnsua.Click += new System.EventHandler(this.tbnsua_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.HotPink;
            this.button1.Font = new System.Drawing.Font("Bahnschrift", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.Location = new System.Drawing.Point(1089, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(91, 91);
            this.button1.TabIndex = 14;
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txbtimkiem
            // 
            this.txbtimkiem.BackColor = System.Drawing.Color.PaleVioletRed;
            this.txbtimkiem.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbtimkiem.ForeColor = System.Drawing.Color.DarkRed;
            this.txbtimkiem.Location = new System.Drawing.Point(666, 290);
            this.txbtimkiem.Name = "txbtimkiem";
            this.txbtimkiem.Size = new System.Drawing.Size(289, 36);
            this.txbtimkiem.TabIndex = 13;
            this.txbtimkiem.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // btntimkiem
            // 
            this.btntimkiem.BackColor = System.Drawing.Color.HotPink;
            this.btntimkiem.Font = new System.Drawing.Font("Bahnschrift", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btntimkiem.Image = ((System.Drawing.Image)(resources.GetObject("btntimkiem.Image")));
            this.btntimkiem.Location = new System.Drawing.Point(973, 235);
            this.btntimkiem.Name = "btntimkiem";
            this.btntimkiem.Size = new System.Drawing.Size(91, 91);
            this.btntimkiem.TabIndex = 12;
            this.btntimkiem.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btntimkiem.UseVisualStyleBackColor = false;
            this.btntimkiem.Click += new System.EventHandler(this.btntimkiem_Click_1);
            // 
            // dgvAccount
            // 
            this.dgvAccount.BackgroundColor = System.Drawing.Color.LightPink;
            this.dgvAccount.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvAccount.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAccount.Location = new System.Drawing.Point(12, 344);
            this.dgvAccount.Name = "dgvAccount";
            this.dgvAccount.RowHeadersWidth = 62;
            this.dgvAccount.RowTemplate.Height = 28;
            this.dgvAccount.Size = new System.Drawing.Size(1168, 359);
            this.dgvAccount.TabIndex = 13;
            this.dgvAccount.SelectionChanged += new System.EventHandler(this.dgvAccount_SelectionChanged_1);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.HotPink;
            this.button2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button2.BackgroundImage")));
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button2.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.OrangeRed;
            this.button2.Location = new System.Drawing.Point(1089, 235);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(91, 91);
            this.button2.TabIndex = 19;
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.PaleVioletRed;
            this.label5.Font = new System.Drawing.Font("Bahnschrift", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(12, 278);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(388, 48);
            this.label5.TabIndex = 20;
            this.label5.Text = "Danh sách nhân viên";
            // 
            // Form_Account
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Pink;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1201, 745);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.txbtimkiem);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btntimkiem);
            this.Controls.Add(this.dgvAccount);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.tbnsua);
            this.Controls.Add(this.btnthem);
            this.Controls.Add(this.btnxoa);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form_Account";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Phần mềm quản lí quán cà phê COFFEE TEA";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAccount)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ComboBox comboBoxtaikhoan;
        private System.Windows.Forms.TextBox txbtenhienthi;
        private System.Windows.Forms.TextBox txbtendangnhap;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnthem;
        private System.Windows.Forms.Button btnxoa;
        private System.Windows.Forms.Button tbnsua;
        private System.Windows.Forms.TextBox txbtimkiem;
        private System.Windows.Forms.Button btntimkiem;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dgvAccount;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label5;
    }
}