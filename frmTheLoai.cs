using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NguyenVanTam_231230895_LTTQ
{
    public partial class frmTheLoai : Form
    {
        Database db = new Database();
        public frmTheLoai()
        {
            InitializeComponent();
        }

        private void frmTheLoai_Load(object sender, EventArgs e)
        {
            loadDgv();
            defaultButton();
        }

        private void loadDgv()
        {
            dgvTheLoai.DataSource = db.ReadData("select * from tblTheLoai");
        }

        private void refresh()
        {
            txtMaTheLoai.Text = "";
            txtTenTheLoai.Text = "";
        }

        private bool isValid()
        {
            if (txtMaTheLoai.Text == "")
            {
                MessageBox.Show("Bạn phải nhập mã", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (txtTenTheLoai.Text == "")
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
            btnThoat.Enabled = true;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (isValid())
            {
                DataTable dt = db.ReadData($@"select * from tblTheLoai where MaTheLoai='{txtMaTheLoai.Text}'");
                if (dt.Rows.Count > 0)
                {
                    MessageBox.Show("Vui lòng nhập mã khác", "Thông báp", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                string insert = $@"insert into tblTheLoai values('{txtMaTheLoai.Text}',N'{txtTenTheLoai.Text}')";
                db.UpdateData(insert);

                loadDgv();
                refresh();
                defaultButton();
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (isValid())
            {
            string update = $@"update tblTheLoai set TenTheLoai=N'{txtTenTheLoai.Text}' where MaTheLoai='{txtMaTheLoai.Text}'";
            db.UpdateData(update);

            loadDgv();
            refresh();
            defaultButton();
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Bạn có chắc muốn xóa không?", "Thông báp", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                string delete = $@"delete from tblTheLoai where MaTheLoai='{txtMaTheLoai.Text}'";
                db.UpdateData(delete);

                loadDgv();
                refresh();
                defaultButton();
            }
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            defaultButton();
            refresh();
            loadDgv();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dgvTheLoai_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            btnSua.Enabled = true;
            btnXoa.Enabled = true;

            txtMaTheLoai.Text = dgvTheLoai.CurrentRow.Cells[0].Value.ToString();
            txtTenTheLoai.Text = dgvTheLoai.CurrentRow.Cells[1].Value.ToString();
        }
    }
}
