namespace GUI
{
    partial class Form_ManagerFood
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_ManagerFood));
            this.btnxoa = new System.Windows.Forms.Button();
            this.dgvThucAn = new System.Windows.Forms.DataGridView();
            this.btnsua = new System.Windows.Forms.Button();
            this.btnthem = new System.Windows.Forms.Button();
            this.btntailai = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.comboBoxdanhmuc = new System.Windows.Forms.ComboBox();
            this.txbgia = new System.Windows.Forms.TextBox();
            this.txbten = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txbma = new System.Windows.Forms.TextBox();
            this.btntimkiem = new System.Windows.Forms.Button();
            this.txbtimkiem = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvThucAn)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnxoa
            // 
            this.btnxoa.BackColor = System.Drawing.Color.HotPink;
            this.btnxoa.Font = new System.Drawing.Font("Bahnschrift", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnxoa.Image = ((System.Drawing.Image)(resources.GetObject("btnxoa.Image")));
            this.btnxoa.Location = new System.Drawing.Point(975, 12);
            this.btnxoa.Name = "btnxoa";
            this.btnxoa.Size = new System.Drawing.Size(91, 91);
            this.btnxoa.TabIndex = 5;
            this.btnxoa.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnxoa.UseVisualStyleBackColor = false;
            this.btnxoa.Click += new System.EventHandler(this.btnxoa_Click);
            // 
            // dgvThucAn
            // 
            this.dgvThucAn.BackgroundColor = System.Drawing.Color.LightPink;
            this.dgvThucAn.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvThucAn.ColumnHeadersHeight = 34;
            this.dgvThucAn.Location = new System.Drawing.Point(12, 344);
            this.dgvThucAn.Name = "dgvThucAn";
            this.dgvThucAn.RowHeadersWidth = 120;
            this.dgvThucAn.RowTemplate.Height = 28;
            this.dgvThucAn.Size = new System.Drawing.Size(1168, 359);
            this.dgvThucAn.TabIndex = 0;
            this.dgvThucAn.SelectionChanged += new System.EventHandler(this.dgvThucAn_SelectionChanged);
            // 
            // btnsua
            // 
            this.btnsua.BackColor = System.Drawing.Color.HotPink;
            this.btnsua.Font = new System.Drawing.Font("Bahnschrift", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsua.Image = ((System.Drawing.Image)(resources.GetObject("btnsua.Image")));
            this.btnsua.Location = new System.Drawing.Point(975, 125);
            this.btnsua.Name = "btnsua";
            this.btnsua.Size = new System.Drawing.Size(91, 91);
            this.btnsua.TabIndex = 7;
            this.btnsua.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnsua.UseVisualStyleBackColor = false;
            this.btnsua.Click += new System.EventHandler(this.btnsua_Click);
            // 
            // btnthem
            // 
            this.btnthem.BackColor = System.Drawing.Color.HotPink;
            this.btnthem.Font = new System.Drawing.Font("Bahnschrift", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnthem.Image = ((System.Drawing.Image)(resources.GetObject("btnthem.Image")));
            this.btnthem.Location = new System.Drawing.Point(1089, 125);
            this.btnthem.Name = "btnthem";
            this.btnthem.Size = new System.Drawing.Size(91, 91);
            this.btnthem.TabIndex = 6;
            this.btnthem.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnthem.UseVisualStyleBackColor = false;
            this.btnthem.Click += new System.EventHandler(this.btnthem_Click);
            // 
            // btntailai
            // 
            this.btntailai.BackColor = System.Drawing.Color.HotPink;
            this.btntailai.Font = new System.Drawing.Font("Bahnschrift", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btntailai.Image = ((System.Drawing.Image)(resources.GetObject("btntailai.Image")));
            this.btntailai.Location = new System.Drawing.Point(1089, 14);
            this.btntailai.Name = "btntailai";
            this.btntailai.Size = new System.Drawing.Size(91, 91);
            this.btntailai.TabIndex = 8;
            this.btntailai.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btntailai.UseVisualStyleBackColor = false;
            this.btntailai.Click += new System.EventHandler(this.btntailai_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LightPink;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Controls.Add(this.comboBoxdanhmuc);
            this.panel1.Controls.Add(this.txbgia);
            this.panel1.Controls.Add(this.txbten);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.txbma);
            this.panel1.Location = new System.Drawing.Point(12, 14);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(510, 233);
            this.panel1.TabIndex = 5;
            // 
            // comboBoxdanhmuc
            // 
            this.comboBoxdanhmuc.BackColor = System.Drawing.Color.PaleVioletRed;
            this.comboBoxdanhmuc.Font = new System.Drawing.Font("Bahnschrift", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxdanhmuc.FormattingEnabled = true;
            this.comboBoxdanhmuc.Location = new System.Drawing.Point(233, 184);
            this.comboBoxdanhmuc.Name = "comboBoxdanhmuc";
            this.comboBoxdanhmuc.Size = new System.Drawing.Size(252, 35);
            this.comboBoxdanhmuc.TabIndex = 4;
            // 
            // txbgia
            // 
            this.txbgia.BackColor = System.Drawing.Color.PaleVioletRed;
            this.txbgia.Font = new System.Drawing.Font("Bahnschrift", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbgia.Location = new System.Drawing.Point(233, 129);
            this.txbgia.Name = "txbgia";
            this.txbgia.Size = new System.Drawing.Size(252, 34);
            this.txbgia.TabIndex = 3;
            // 
            // txbten
            // 
            this.txbten.BackColor = System.Drawing.Color.PaleVioletRed;
            this.txbten.Font = new System.Drawing.Font("Bahnschrift", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbten.Location = new System.Drawing.Point(233, 71);
            this.txbten.Name = "txbten";
            this.txbten.Size = new System.Drawing.Size(252, 34);
            this.txbten.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.PaleVioletRed;
            this.label4.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(25, 129);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 29);
            this.label4.TabIndex = 4;
            this.label4.Text = "Giá";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.PaleVioletRed;
            this.label3.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(22, 184);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(120, 29);
            this.label3.TabIndex = 3;
            this.label3.Text = "Danh mục";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.PaleVioletRed;
            this.label2.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(25, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 29);
            this.label2.TabIndex = 2;
            this.label2.Text = "Tên";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.PaleVioletRed;
            this.label1.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(25, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 29);
            this.label1.TabIndex = 1;
            this.label1.Text = "Mã";
            // 
            // txbma
            // 
            this.txbma.BackColor = System.Drawing.Color.PaleVioletRed;
            this.txbma.Font = new System.Drawing.Font("Bahnschrift", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbma.Location = new System.Drawing.Point(233, 14);
            this.txbma.Name = "txbma";
            this.txbma.ReadOnly = true;
            this.txbma.Size = new System.Drawing.Size(252, 34);
            this.txbma.TabIndex = 1;
            this.txbma.TextChanged += new System.EventHandler(this.txbma_TextChanged);
            // 
            // btntimkiem
            // 
            this.btntimkiem.BackColor = System.Drawing.Color.HotPink;
            this.btntimkiem.Font = new System.Drawing.Font("Bahnschrift", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btntimkiem.Image = ((System.Drawing.Image)(resources.GetObject("btntimkiem.Image")));
            this.btntimkiem.Location = new System.Drawing.Point(975, 239);
            this.btntimkiem.Name = "btntimkiem";
            this.btntimkiem.Size = new System.Drawing.Size(91, 91);
            this.btntimkiem.TabIndex = 9;
            this.btntimkiem.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btntimkiem.UseVisualStyleBackColor = false;
            this.btntimkiem.Click += new System.EventHandler(this.btntimkiem_Click);
            // 
            // txbtimkiem
            // 
            this.txbtimkiem.BackColor = System.Drawing.Color.PaleVioletRed;
            this.txbtimkiem.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbtimkiem.ForeColor = System.Drawing.Color.IndianRed;
            this.txbtimkiem.Location = new System.Drawing.Point(616, 294);
            this.txbtimkiem.Name = "txbtimkiem";
            this.txbtimkiem.Size = new System.Drawing.Size(343, 36);
            this.txbtimkiem.TabIndex = 10;
            this.txbtimkiem.TextChanged += new System.EventHandler(this.txbtimkiem_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.PaleVioletRed;
            this.label5.Font = new System.Drawing.Font("Bahnschrift", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(12, 281);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(349, 48);
            this.label5.TabIndex = 11;
            this.label5.Text = "Danh sách món ăn";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.HotPink;
            this.button1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button1.BackgroundImage")));
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button1.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.OrangeRed;
            this.button1.Location = new System.Drawing.Point(1089, 240);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(91, 91);
            this.button1.TabIndex = 12;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form_ManagerFood
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Pink;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1201, 745);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txbtimkiem);
            this.Controls.Add(this.btntimkiem);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btntailai);
            this.Controls.Add(this.btnthem);
            this.Controls.Add(this.btnsua);
            this.Controls.Add(this.btnxoa);
            this.Controls.Add(this.dgvThucAn);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form_ManagerFood";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Phần mềm quản lí quán cà phê COFFEE TEA";
            ((System.ComponentModel.ISupportInitialize)(this.dgvThucAn)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnxoa;
        private System.Windows.Forms.DataGridView dgvThucAn;
        private System.Windows.Forms.Button btnsua;
        private System.Windows.Forms.Button btnthem;
        private System.Windows.Forms.Button btntailai;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txbma;
        private System.Windows.Forms.Button btntimkiem;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txbgia;
        private System.Windows.Forms.TextBox txbten;
        private System.Windows.Forms.TextBox txbtimkiem;
        private System.Windows.Forms.ComboBox comboBoxdanhmuc;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button1;
    }
}