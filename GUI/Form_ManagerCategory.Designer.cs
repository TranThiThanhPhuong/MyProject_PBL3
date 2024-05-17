namespace GUI
{
    partial class Form_ManagerCategory
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_ManagerCategory));
            this.dgvThucAn = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txbten = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txbma = new System.Windows.Forms.TextBox();
            this.txbtimkiem = new System.Windows.Forms.TextBox();
            this.btntimkiem = new System.Windows.Forms.Button();
            this.btntailai = new System.Windows.Forms.Button();
            this.btnthem = new System.Windows.Forms.Button();
            this.btnsua = new System.Windows.Forms.Button();
            this.btnxoa = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvThucAn)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvThucAn
            // 
            this.dgvThucAn.BackgroundColor = System.Drawing.Color.LightPink;
            this.dgvThucAn.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvThucAn.ColumnHeadersHeight = 34;
            this.dgvThucAn.Location = new System.Drawing.Point(12, 348);
            this.dgvThucAn.Name = "dgvThucAn";
            this.dgvThucAn.RowHeadersWidth = 120;
            this.dgvThucAn.RowTemplate.Height = 28;
            this.dgvThucAn.Size = new System.Drawing.Size(1168, 353);
            this.dgvThucAn.TabIndex = 1;
            this.dgvThucAn.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvThucAn_CellContentClick);
            this.dgvThucAn.SelectionChanged += new System.EventHandler(this.dgvThucAn_SelectionChanged);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LightPink;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Controls.Add(this.txbten);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.txbma);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(510, 233);
            this.panel1.TabIndex = 6;
            // 
            // txbten
            // 
            this.txbten.BackColor = System.Drawing.Color.PaleVioletRed;
            this.txbten.Font = new System.Drawing.Font("Bahnschrift", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbten.Location = new System.Drawing.Point(218, 76);
            this.txbten.Name = "txbten";
            this.txbten.Size = new System.Drawing.Size(268, 34);
            this.txbten.TabIndex = 2;
            this.txbten.TextChanged += new System.EventHandler(this.txbten_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.PaleVioletRed;
            this.label2.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(25, 81);
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
            this.txbma.Location = new System.Drawing.Point(218, 19);
            this.txbma.Name = "txbma";
            this.txbma.ReadOnly = true;
            this.txbma.Size = new System.Drawing.Size(268, 34);
            this.txbma.TabIndex = 1;
            // 
            // txbtimkiem
            // 
            this.txbtimkiem.BackColor = System.Drawing.Color.PaleVioletRed;
            this.txbtimkiem.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbtimkiem.ForeColor = System.Drawing.Color.Black;
            this.txbtimkiem.Location = new System.Drawing.Point(631, 289);
            this.txbtimkiem.Name = "txbtimkiem";
            this.txbtimkiem.Size = new System.Drawing.Size(333, 36);
            this.txbtimkiem.TabIndex = 16;
            this.txbtimkiem.TextChanged += new System.EventHandler(this.txbtimkiem_TextChanged);
            // 
            // btntimkiem
            // 
            this.btntimkiem.BackColor = System.Drawing.Color.HotPink;
            this.btntimkiem.Font = new System.Drawing.Font("Bahnschrift", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btntimkiem.Image = ((System.Drawing.Image)(resources.GetObject("btntimkiem.Image")));
            this.btntimkiem.Location = new System.Drawing.Point(979, 234);
            this.btntimkiem.Name = "btntimkiem";
            this.btntimkiem.Size = new System.Drawing.Size(91, 91);
            this.btntimkiem.TabIndex = 15;
            this.btntimkiem.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btntimkiem.UseVisualStyleBackColor = false;
            this.btntimkiem.Click += new System.EventHandler(this.btntimkiem_Click);
            // 
            // btntailai
            // 
            this.btntailai.BackColor = System.Drawing.Color.HotPink;
            this.btntailai.Font = new System.Drawing.Font("Bahnschrift", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btntailai.Image = ((System.Drawing.Image)(resources.GetObject("btntailai.Image")));
            this.btntailai.Location = new System.Drawing.Point(1089, 12);
            this.btntailai.Name = "btntailai";
            this.btntailai.Size = new System.Drawing.Size(91, 91);
            this.btntailai.TabIndex = 14;
            this.btntailai.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btntailai.UseVisualStyleBackColor = false;
            this.btntailai.Click += new System.EventHandler(this.btntailai_Click);
            // 
            // btnthem
            // 
            this.btnthem.BackColor = System.Drawing.Color.HotPink;
            this.btnthem.Font = new System.Drawing.Font("Bahnschrift", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnthem.Image = ((System.Drawing.Image)(resources.GetObject("btnthem.Image")));
            this.btnthem.Location = new System.Drawing.Point(1089, 123);
            this.btnthem.Name = "btnthem";
            this.btnthem.Size = new System.Drawing.Size(91, 91);
            this.btnthem.TabIndex = 12;
            this.btnthem.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnthem.UseVisualStyleBackColor = false;
            this.btnthem.Click += new System.EventHandler(this.btnthem_Click);
            // 
            // btnsua
            // 
            this.btnsua.BackColor = System.Drawing.Color.HotPink;
            this.btnsua.Font = new System.Drawing.Font("Bahnschrift", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsua.Image = ((System.Drawing.Image)(resources.GetObject("btnsua.Image")));
            this.btnsua.Location = new System.Drawing.Point(979, 123);
            this.btnsua.Name = "btnsua";
            this.btnsua.Size = new System.Drawing.Size(91, 91);
            this.btnsua.TabIndex = 13;
            this.btnsua.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnsua.UseVisualStyleBackColor = false;
            this.btnsua.Click += new System.EventHandler(this.btnsua_Click);
            // 
            // btnxoa
            // 
            this.btnxoa.BackColor = System.Drawing.Color.HotPink;
            this.btnxoa.Font = new System.Drawing.Font("Bahnschrift", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnxoa.Image = ((System.Drawing.Image)(resources.GetObject("btnxoa.Image")));
            this.btnxoa.Location = new System.Drawing.Point(979, 12);
            this.btnxoa.Name = "btnxoa";
            this.btnxoa.Size = new System.Drawing.Size(91, 91);
            this.btnxoa.TabIndex = 11;
            this.btnxoa.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnxoa.UseVisualStyleBackColor = false;
            this.btnxoa.Click += new System.EventHandler(this.btnxoa_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.PaleVioletRed;
            this.label5.Font = new System.Drawing.Font("Bahnschrift", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(12, 276);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(534, 48);
            this.label5.TabIndex = 17;
            this.label5.Text = "Danh sách danh mục món ăn";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.HotPink;
            this.button1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button1.BackgroundImage")));
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button1.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.OrangeRed;
            this.button1.Location = new System.Drawing.Point(1089, 234);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(91, 91);
            this.button1.TabIndex = 18;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form_ManagerCategory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Pink;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1205, 749);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txbtimkiem);
            this.Controls.Add(this.btntimkiem);
            this.Controls.Add(this.btntailai);
            this.Controls.Add(this.btnthem);
            this.Controls.Add(this.btnsua);
            this.Controls.Add(this.btnxoa);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dgvThucAn);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form_ManagerCategory";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Phần mềm quản lí quán cà phê COFFEE TEA";
            ((System.ComponentModel.ISupportInitialize)(this.dgvThucAn)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvThucAn;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txbten;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txbma;
        private System.Windows.Forms.TextBox txbtimkiem;
        private System.Windows.Forms.Button btntimkiem;
        private System.Windows.Forms.Button btntailai;
        private System.Windows.Forms.Button btnthem;
        private System.Windows.Forms.Button btnsua;
        private System.Windows.Forms.Button btnxoa;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button1;
    }
}