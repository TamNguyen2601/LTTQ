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
using Excel = Microsoft.Office.Interop.Excel;


namespace NguyenVanTam_231230895_LTTQ
{
    public partial class frmSach : Form
    {
        Database db = new Database();
        FillComboBox fillCb = new FillComboBox();
        string fileName = "";
        string fullPath = "";

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
            dgvSach.DataSource = db.ReadData("select s.MaSach,s.TenSach,s.Anh,t.TenTheLoai from tblSach s join tblTheLoai t on s.TheLoai=t.MaTheLoai");
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
            fileName = "";
            fullPath = "";
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
                string insert = $@"insert into tblSach values('{txtMaSach.Text}',N'{txtTenSach.Text}','{cboTheLoai.SelectedValue}',N'{fileName}')";
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

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                picSach.Image = Image.FromFile(ofd.FileName);
                fullPath = ofd.FileName;
                fileName = Path.GetFileName(fullPath);
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            string update = $@"update tblSach set TenSach=N'{txtTenSach.Text}',TheLoai='{cboTheLoai.SelectedValue}',Anh=N'{fileName}' where MaSach='{txtMaSach.Text}'";
            db.UpdateData(update);

            loadDgv();
            refresh();
            defaultButton();
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

            Excel.Application exApp = new Excel.Application();
            Excel.Workbook exBook = exApp.Workbooks.Add(Excel.XlWBATemplate.xlWBATWorksheet);
            Excel.Worksheet exSheet = (Excel.Worksheet)exBook.Worksheets[1];
            Excel.Range range = (Excel.Range)exSheet.Cells[1, 1];

            range.Range["B2"].Font.Size = 25;
            range.Range["B2"].Font.Name = "Times New Roman";
            range.Range["B2"].Font.Color = Color.Red;
            range.Range["B2"].Value = "DANH SÁCH SÁCH";

            range.Range["A4:F4"].Font.Size = 13;
            range.Range["A4:F4"].Font.Name = "Times New Roman";
            range.Range["A4:F4"].Font.Bold = true;
            range.Range["A4:F4"].Font.Color = Color.Black;

            range.Range["A4"].Value = "Mã sách";
            range.Range["B4"].Value = "Tên sách";
            range.Range["C4"].Value = "Thể loại";
            range.Range["D4"].Value = "Ảnh";
 

            int hang = 5;

            for (int i = 0; i < dgvSach.Rows.Count - 1; i++)
            {
                range.Range["A" + hang].Value = dgvSach.Rows[i].Cells[0].Value.ToString();
                range.Range["B" + hang].Value = dgvSach.Rows[i].Cells[1].Value.ToString();
                range.Range["C" + hang].Value = dgvSach.Rows[i].Cells[3].Value.ToString(); 
                range.Range["D" + hang].Value = dgvSach.Rows[i].Cells[2].Value.ToString(); 
                hang++;
            }

            exSheet.Name = "DSSach";

            exBook.Activate();

            SaveFileDialog save = new SaveFileDialog();

            if (save.ShowDialog() == DialogResult.OK)
            {
                exBook.SaveAs(save.FileName.ToString());
            }

            exApp.Quit();
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
            cboTheLoai.Text = dgvSach.CurrentRow.Cells[3].Value.ToString();
            txtAnh.Text = dgvSach.CurrentRow.Cells[2].Value.ToString();
        }
    }
}
