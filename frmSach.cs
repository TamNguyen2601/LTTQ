using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.Design;
using ClosedXML.Excel;


namespace NguyenVanTam_231230895_LTTQ
{
    public partial class frmSach : Form
    {
        Database db = new Database();
        FillComboBox fillCb = new FillComboBox();

        public frmSach()
        {
            InitializeComponent();
        }

        private void frmSach_Load(object sender, EventArgs e)
        {
            loadDgv();
            loadCombobox();
            defaultButton();
        }

        private void loadDgv()
        {
            dgvSach.DataSource = db.ReadData("select s.MaSach,s.TenSach,t.TenTheLoai,s.Anh from tblSach s join tblTheLoai t on s.TheLoai=t.MaTheLoai");
        }

        private void loadCombobox()
        {
            DataTable dt = db.ReadData("select * from tblTheLoai");
            fillCb.FillCombox(cboTheLoai, dt, "TenTheLoai", "MaTheLoai");
        }

        private void refresh()
        {
            txtMaSach.Text = "";
            txtTenSach.Text = "";
            cboTheLoai.SelectedIndex = -1;
            picSach.Image = null;
            txtAnh.Text = "";
        }

        private bool isValid()
        {
            if (txtMaSach.Text == "")
            {
                MessageBox.Show("Bạn phải nhập mã", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (txtTenSach.Text == "")
            {
                MessageBox.Show("Bạn phải nhập tên", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            return true;
        }

        private void defaultButton()
        {
            btnThem.Enabled = true;
            btnSua.Enabled = false;
            btnXoa.Enabled = false;
            btnLamMoi.Enabled = true;
            btnExcel.Enabled = true;
            btnThoat.Enabled = true;
            btnTheLoai.Enabled = true;
        }



        private void btnThem_Click(object sender, EventArgs e)
        {
            if (isValid())
            {
                DataTable dt = db.ReadData($@"select * from tblSach where MaSach='{txtMaSach.Text}'");
                if (dt.Rows.Count > 0)
                {
                    MessageBox.Show("Vui lòng nhập mã khác", "Thông báp", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                string insert = $@"insert into tblSach values('{txtMaSach.Text}',N'{txtTenSach.Text}','{cboTheLoai.SelectedValue}',N'{txtAnh.Text}')";
                db.UpdateData(insert);

                loadDgv();
                refresh();
                defaultButton();
            }
        }

        private void btnAnh_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.InitialDirectory = Application.StartupPath;
            ofd.Filter = "(*.jpg;*.jpeg;*.png;*.gif;*.bmp)|*.jpg;*.jpeg;*.png;*.gif;*.bmp";


            if (ofd.ShowDialog() == DialogResult.OK)
            {
                picSach.Image = Image.FromFile(ofd.FileName);
                string fileName = Path.GetFileName(ofd.FileName);
                txtAnh.Text = fileName;
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (isValid())
            {
            string update = $@"update tblSach set TenSach=N'{txtTenSach.Text}',TheLoai='{cboTheLoai.SelectedValue}',Anh=N'{txtAnh.Text}' where MaSach='{txtMaSach.Text}'";
            db.UpdateData(update);

            loadDgv();
            refresh();
            defaultButton();
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc muốn xóa không?", "Thông báp", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                string delete = $@"delete from tblSach where MaSach='{txtMaSach.Text}'";
                db.UpdateData(delete);

                loadDgv();
                defaultButton();
                refresh();
            }
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            defaultButton();
            refresh();
            loadDgv();
        }

        private void btnExcel_Click(object sender, EventArgs e)
        {
            using var save = new SaveFileDialog
            {
                Title = "Save Excel",
                Filter = "(*.xlsx)|*.xlsx",
                FileName = "DSSach.xlsx",
                OverwritePrompt = true
            };

            if (save.ShowDialog() != DialogResult.OK)
                return;

            using var wb = new XLWorkbook();
            var ws = wb.Worksheets.Add("DSSach");

            var title = ws.Cell("B2");
            title.Value = "DANH SÁCH SÁCH";
            title.Style.Font.FontSize = 25;
            title.Style.Font.Bold = true;
            title.Style.Font.FontColor = XLColor.Red;

            ws.Cell("A4").Value = "Mã sách";
            ws.Cell("B4").Value = "Tên sách";
            ws.Cell("C4").Value = "Thể loại";
            ws.Cell("D4").Value = "Ảnh";

            var header = ws.Range("A4:D4");
            header.Style.Font.Bold = true;
            header.Style.Font.FontSize = 13;
            header.Style.Font.FontColor = XLColor.Black;

            int row = 5;
            for (int i = 0; i < dgvSach.Rows.Count; i++)
            {
                var r = dgvSach.Rows[i];
                if (r.IsNewRow) continue;

                ws.Cell(row, 1).Value = r.Cells[0].Value?.ToString();
                ws.Cell(row, 2).Value = r.Cells[1].Value?.ToString();
                ws.Cell(row, 3).Value = r.Cells[3].Value?.ToString();
                ws.Cell(row, 4).Value = r.Cells[2].Value?.ToString();
                row++;
            }

            ws.ColumnsUsed().AdjustToContents();
            wb.SaveAs(save.FileName);

            MessageBox.Show("Xuất Excel thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnTheLoai_Click(object sender, EventArgs e)
        {
            Form f = new frmTheLoai();
            f.ShowDialog();
            loadCombobox();
        }

        private void dgvSach_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            btnSua.Enabled = true;
            btnXoa.Enabled = true;

            txtMaSach.Text = dgvSach.CurrentRow.Cells[0].Value.ToString();
            txtTenSach.Text = dgvSach.CurrentRow.Cells[1].Value.ToString();
            cboTheLoai.Text = dgvSach.CurrentRow.Cells[2].Value.ToString();
            txtAnh.Text = dgvSach.CurrentRow.Cells[3].Value.ToString();
        }
    }
}
