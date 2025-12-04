namespace NguyenVanTam_231230895_LTTQ
{
    partial class frmTheLoai
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
            panel1 = new Panel();
            label1 = new Label();
            panel2 = new Panel();
            btnThoat = new Button();
            btnLamMoi = new Button();
            btnXoa = new Button();
            btnSua = new Button();
            btnThem = new Button();
            panel3 = new Panel();
            txtTenTheLoai = new TextBox();
            txtMaTheLoai = new TextBox();
            label3 = new Label();
            label2 = new Label();
            panel4 = new Panel();
            dgvTheLoai = new DataGridView();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvTheLoai).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1169, 125);
            panel1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(429, 41);
            label1.Name = "label1";
            label1.Size = new Size(275, 41);
            label1.TabIndex = 0;
            label1.Text = "Danh sách thể loại";
            // 
            // panel2
            // 
            panel2.Controls.Add(btnThoat);
            panel2.Controls.Add(btnLamMoi);
            panel2.Controls.Add(btnXoa);
            panel2.Controls.Add(btnSua);
            panel2.Controls.Add(btnThem);
            panel2.Dock = DockStyle.Bottom;
            panel2.Location = new Point(0, 503);
            panel2.Name = "panel2";
            panel2.Size = new Size(1169, 125);
            panel2.TabIndex = 1;
            // 
            // btnThoat
            // 
            btnThoat.Location = new Point(722, 44);
            btnThoat.Name = "btnThoat";
            btnThoat.Size = new Size(94, 29);
            btnThoat.TabIndex = 3;
            btnThoat.Text = "Thoát";
            btnThoat.UseVisualStyleBackColor = true;
            btnThoat.Click += btnThoat_Click;
            // 
            // btnLamMoi
            // 
            btnLamMoi.Location = new Point(565, 44);
            btnLamMoi.Name = "btnLamMoi";
            btnLamMoi.Size = new Size(94, 29);
            btnLamMoi.TabIndex = 2;
            btnLamMoi.Text = "Làm mới";
            btnLamMoi.UseVisualStyleBackColor = true;
            btnLamMoi.Click += btnLamMoi_Click;
            // 
            // btnXoa
            // 
            btnXoa.Location = new Point(412, 44);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(94, 29);
            btnXoa.TabIndex = 0;
            btnXoa.Text = "Xóa";
            btnXoa.UseVisualStyleBackColor = true;
            btnXoa.Click += btnXoa_Click;
            // 
            // btnSua
            // 
            btnSua.Location = new Point(253, 44);
            btnSua.Name = "btnSua";
            btnSua.Size = new Size(94, 29);
            btnSua.TabIndex = 1;
            btnSua.Text = "Sửa";
            btnSua.UseVisualStyleBackColor = true;
            btnSua.Click += btnSua_Click;
            // 
            // btnThem
            // 
            btnThem.Location = new Point(89, 44);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(94, 29);
            btnThem.TabIndex = 0;
            btnThem.Text = "Thêm";
            btnThem.UseVisualStyleBackColor = true;
            btnThem.Click += btnThem_Click;
            // 
            // panel3
            // 
            panel3.Controls.Add(txtTenTheLoai);
            panel3.Controls.Add(txtMaTheLoai);
            panel3.Controls.Add(label3);
            panel3.Controls.Add(label2);
            panel3.Dock = DockStyle.Right;
            panel3.Location = new Point(693, 125);
            panel3.Name = "panel3";
            panel3.Size = new Size(476, 378);
            panel3.TabIndex = 2;
            // 
            // txtTenTheLoai
            // 
            txtTenTheLoai.Location = new Point(136, 97);
            txtTenTheLoai.Name = "txtTenTheLoai";
            txtTenTheLoai.Size = new Size(190, 27);
            txtTenTheLoai.TabIndex = 3;
            // 
            // txtMaTheLoai
            // 
            txtMaTheLoai.Location = new Point(136, 42);
            txtMaTheLoai.Name = "txtMaTheLoai";
            txtMaTheLoai.Size = new Size(190, 27);
            txtMaTheLoai.TabIndex = 2;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(27, 104);
            label3.Name = "label3";
            label3.Size = new Size(89, 20);
            label3.TabIndex = 1;
            label3.Text = "Tên thể loại:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(29, 49);
            label2.Name = "label2";
            label2.Size = new Size(87, 20);
            label2.TabIndex = 0;
            label2.Text = "Mã thể loại:";
            // 
            // panel4
            // 
            panel4.Controls.Add(dgvTheLoai);
            panel4.Dock = DockStyle.Fill;
            panel4.Location = new Point(0, 125);
            panel4.Name = "panel4";
            panel4.Size = new Size(693, 378);
            panel4.TabIndex = 3;
            // 
            // dgvTheLoai
            // 
            dgvTheLoai.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvTheLoai.Dock = DockStyle.Fill;
            dgvTheLoai.Location = new Point(0, 0);
            dgvTheLoai.Name = "dgvTheLoai";
            dgvTheLoai.RowHeadersWidth = 51;
            dgvTheLoai.Size = new Size(693, 378);
            dgvTheLoai.TabIndex = 0;
            dgvTheLoai.CellClick += dgvTheLoai_CellClick;
            // 
            // frmTheLoai
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1169, 628);
            Controls.Add(panel4);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "frmTheLoai";
            Text = "frmTheLoai";
            Load += frmTheLoai_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvTheLoai).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private Panel panel2;
        private Button btnThoat;
        private Button btnLamMoi;
        private Button btnXoa;
        private Button btnSua;
        private Button btnThem;
        private Panel panel3;
        private TextBox txtTenTheLoai;
        private TextBox txtMaTheLoai;
        private Label label3;
        private Label label2;
        private Panel panel4;
        private DataGridView dgvTheLoai;
    }
}