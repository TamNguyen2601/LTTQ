namespace NguyenVanTam_231230895_LTTQ
{
    partial class frmSach
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
            btnExcel = new Button();
            btnLamMoi = new Button();
            btnXoa = new Button();
            btnSua = new Button();
            btnThem = new Button();
            panel3 = new Panel();
            btnAnh = new Button();
            btnTheLoai = new Button();
            picSach = new PictureBox();
            cboTheLoai = new ComboBox();
            txtTenSach = new TextBox();
            txtMaSach = new TextBox();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            panel4 = new Panel();
            dgvSach = new DataGridView();
            txtAnh = new TextBox();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picSach).BeginInit();
            panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvSach).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1218, 98);
            panel1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(468, 28);
            label1.Name = "label1";
            label1.Size = new Size(234, 41);
            label1.TabIndex = 0;
            label1.Text = "Danh sách Sách";
            // 
            // panel2
            // 
            panel2.Controls.Add(btnThoat);
            panel2.Controls.Add(btnExcel);
            panel2.Controls.Add(btnLamMoi);
            panel2.Controls.Add(btnXoa);
            panel2.Controls.Add(btnSua);
            panel2.Controls.Add(btnThem);
            panel2.Dock = DockStyle.Bottom;
            panel2.Location = new Point(0, 594);
            panel2.Name = "panel2";
            panel2.Size = new Size(1218, 77);
            panel2.TabIndex = 1;
            // 
            // btnThoat
            // 
            btnThoat.Location = new Point(922, 21);
            btnThoat.Name = "btnThoat";
            btnThoat.Size = new Size(94, 29);
            btnThoat.TabIndex = 5;
            btnThoat.Text = "Thoát";
            btnThoat.UseVisualStyleBackColor = true;
            btnThoat.Click += btnThoat_Click;
            // 
            // btnExcel
            // 
            btnExcel.Location = new Point(762, 21);
            btnExcel.Name = "btnExcel";
            btnExcel.Size = new Size(94, 29);
            btnExcel.TabIndex = 4;
            btnExcel.Text = "Excel";
            btnExcel.UseVisualStyleBackColor = true;
            btnExcel.Click += btnExcel_Click;
            // 
            // btnLamMoi
            // 
            btnLamMoi.Location = new Point(590, 21);
            btnLamMoi.Name = "btnLamMoi";
            btnLamMoi.Size = new Size(94, 29);
            btnLamMoi.TabIndex = 3;
            btnLamMoi.Text = "Làm mới";
            btnLamMoi.UseVisualStyleBackColor = true;
            btnLamMoi.Click += btnLamMoi_Click;
            // 
            // btnXoa
            // 
            btnXoa.Location = new Point(423, 21);
            btnXoa.Name = "btnXoa";
            btnXoa.RightToLeft = RightToLeft.No;
            btnXoa.Size = new Size(94, 29);
            btnXoa.TabIndex = 2;
            btnXoa.Text = "Xóa";
            btnXoa.UseVisualStyleBackColor = true;
            btnXoa.Click += btnXoa_Click;
            // 
            // btnSua
            // 
            btnSua.Location = new Point(242, 21);
            btnSua.Name = "btnSua";
            btnSua.Size = new Size(94, 29);
            btnSua.TabIndex = 1;
            btnSua.Text = "Sửa";
            btnSua.UseVisualStyleBackColor = true;
            btnSua.Click += btnSua_Click;
            // 
            // btnThem
            // 
            btnThem.Location = new Point(88, 21);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(94, 29);
            btnThem.TabIndex = 0;
            btnThem.Text = "Thêm";
            btnThem.UseVisualStyleBackColor = true;
            btnThem.Click += btnThem_Click;
            // 
            // panel3
            // 
            panel3.Controls.Add(txtAnh);
            panel3.Controls.Add(btnAnh);
            panel3.Controls.Add(btnTheLoai);
            panel3.Controls.Add(picSach);
            panel3.Controls.Add(cboTheLoai);
            panel3.Controls.Add(txtTenSach);
            panel3.Controls.Add(txtMaSach);
            panel3.Controls.Add(label4);
            panel3.Controls.Add(label3);
            panel3.Controls.Add(label2);
            panel3.Dock = DockStyle.Right;
            panel3.Location = new Point(590, 98);
            panel3.Name = "panel3";
            panel3.Size = new Size(628, 496);
            panel3.TabIndex = 2;
            // 
            // btnAnh
            // 
            btnAnh.Location = new Point(45, 315);
            btnAnh.Name = "btnAnh";
            btnAnh.Size = new Size(94, 29);
            btnAnh.TabIndex = 10;
            btnAnh.Text = "Ảnh";
            btnAnh.UseVisualStyleBackColor = true;
            btnAnh.Click += btnAnh_Click;
            // 
            // btnTheLoai
            // 
            btnTheLoai.Location = new Point(451, 154);
            btnTheLoai.Name = "btnTheLoai";
            btnTheLoai.Size = new Size(94, 29);
            btnTheLoai.TabIndex = 9;
            btnTheLoai.Text = "Thể loại";
            btnTheLoai.UseVisualStyleBackColor = true;
            btnTheLoai.Click += btnTheLoai_Click;
            // 
            // picSach
            // 
            picSach.Location = new Point(153, 231);
            picSach.Name = "picSach";
            picSach.Size = new Size(258, 209);
            picSach.TabIndex = 8;
            picSach.TabStop = false;
            // 
            // cboTheLoai
            // 
            cboTheLoai.FormattingEnabled = true;
            cboTheLoai.Location = new Point(153, 155);
            cboTheLoai.Name = "cboTheLoai";
            cboTheLoai.Size = new Size(244, 28);
            cboTheLoai.TabIndex = 7;
            // 
            // txtTenSach
            // 
            txtTenSach.Location = new Point(153, 88);
            txtTenSach.Name = "txtTenSach";
            txtTenSach.Size = new Size(244, 27);
            txtTenSach.TabIndex = 6;
            // 
            // txtMaSach
            // 
            txtMaSach.Location = new Point(153, 32);
            txtMaSach.Name = "txtMaSach";
            txtMaSach.Size = new Size(244, 27);
            txtMaSach.TabIndex = 5;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(45, 163);
            label4.Name = "label4";
            label4.Size = new Size(65, 20);
            label4.TabIndex = 3;
            label4.Text = "Thể loại:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(45, 95);
            label3.Name = "label3";
            label3.Size = new Size(68, 20);
            label3.TabIndex = 2;
            label3.Text = "Tên sách:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(45, 39);
            label2.Name = "label2";
            label2.Size = new Size(66, 20);
            label2.TabIndex = 1;
            label2.Text = "Mã sách:";
            // 
            // panel4
            // 
            panel4.Controls.Add(dgvSach);
            panel4.Dock = DockStyle.Fill;
            panel4.Location = new Point(0, 98);
            panel4.Name = "panel4";
            panel4.Size = new Size(590, 496);
            panel4.TabIndex = 3;
            // 
            // dgvSach
            // 
            dgvSach.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvSach.Dock = DockStyle.Fill;
            dgvSach.Location = new Point(0, 0);
            dgvSach.Name = "dgvSach";
            dgvSach.RowHeadersWidth = 51;
            dgvSach.Size = new Size(590, 496);
            dgvSach.TabIndex = 0;
            dgvSach.CellClick += dgvSach_CellClick;
            // 
            // txtAnh
            // 
            txtAnh.Location = new Point(437, 315);
            txtAnh.Name = "txtAnh";
            txtAnh.Size = new Size(168, 27);
            txtAnh.TabIndex = 11;
            // 
            // frmSach
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1218, 671);
            Controls.Add(panel4);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "frmSach";
            Text = "frmSach";
            Load += frmSach_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)picSach).EndInit();
            panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvSach).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private Panel panel2;
        private Button btnThoat;
        private Button btnExcel;
        private Button btnLamMoi;
        private Button btnXoa;
        private Button btnSua;
        private Button btnThem;
        private Panel panel3;
        private Button btnAnh;
        private Button btnTheLoai;
        private PictureBox picSach;
        private ComboBox cboTheLoai;
        private TextBox txtTenSach;
        private TextBox txtMaSach;
        private Label label4;
        private Label label3;
        private Label label2;
        private Panel panel4;
        private DataGridView dgvSach;
        private TextBox txtAnh;
    }
}