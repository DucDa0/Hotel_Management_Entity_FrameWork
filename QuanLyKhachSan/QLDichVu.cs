using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using QuanLyKhachSan.BS_Layer;
namespace QuanLyKhachSan
{
    public partial class QLDichVu : Form
    {
        // Khai báo biến kiểm tra việc Thêm hay Sửa dữ liệu  
        bool Them;
        string err;
        BLDichVu dbDV = new BLDichVu();
        QuanLyKhachSanEntities qlksEntity = new QuanLyKhachSanEntities();
        public QLDichVu()
        {
            InitializeComponent();
        }
        void LoadData()
        {
            try
            {
                // đưa dữ liệu lên DGV
                dgvDichVu.DataSource = dbDV.LayDichVu();
                // ko cho thao tác
                this.btnLuu.Enabled = false;
                this.btnHuy.Enabled = false;
                this.panel1.Enabled = false;
                // cho thao tác
                this.btnThem.Enabled = true;
                this.btnSua.Enabled = true;
                this.btnXoa.Enabled = true;

                var tps = from p in qlksEntity.NHANVIENs select p.MaNV;

                cbxMaNV.DisplayMember = "MaNV";
                cbxMaNV.ValueMember = "MaNV";
                cbxMaNV.DataSource = tps.ToList();

                dgvDichVu_CellClick(null, null);
            }
            catch (SqlException)
            {
                MessageBox.Show("Ko lấy đc dữ liệu. Lỗi r!!");
            }
        }

        private void dgvDichVu_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int r = dgvDichVu.CurrentCell.RowIndex;
            this.txtMaDV.Text =
            dgvDichVu.Rows[r].Cells[0].Value.ToString().Trim();
            this.txtTenDV.Text =
            dgvDichVu.Rows[r].Cells[1].Value.ToString().Trim();
            this.txtGiaDV.Text =
           dgvDichVu.Rows[r].Cells[2].Value.ToString().Trim();
            this.cbxMaNV.Text =
           dgvDichVu.Rows[r].Cells[3].Value.ToString().Trim();            
        }

        private void btnReload_Click(object sender, EventArgs e)
        {
            LoadData();
        }

        private void QLDichVu_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            Them = true;
            this.txtMaDV.Clear();
            this.txtGiaDV.Clear();
            this.txtTenDV.Clear();

            this.txtMaDV.Enabled = true;
            this.btnLuu.Enabled = true;
            this.btnHuy.Enabled = true;
            this.panel1.Enabled = true;

            this.btnThem.Enabled = false;
            this.btnSua.Enabled = false;
            this.btnXoa.Enabled = false;
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (Them)
            {
                try
                {
                    BLDichVu blDv = new BLDichVu();
                    blDv.ThemDichVu(this.txtMaDV.Text.Trim(), this.txtTenDV.Text.Trim(), Convert.ToInt32(this.txtGiaDV.Text.Trim()),
                        this.cbxMaNV.Text.Trim(), ref err);
                    LoadData();
                    MessageBox.Show("Đã Thêm Xong");
                }
                catch (SqlException)
                {
                    MessageBox.Show("ko thêm đc. Lỗi r!.");
                }

            }
            else
            {
                BLDichVu blDv = new BLDichVu();
                blDv.CapNhatDichVu(this.txtMaDV.Text.Trim(), this.txtTenDV.Text.Trim(), Convert.ToInt32(this.txtGiaDV.Text.Trim()),
                        this.cbxMaNV.Text.Trim(), ref err);
                LoadData();
                MessageBox.Show("Đã sửa xong");
            }
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            this.btnThem.Enabled = true;
            this.btnSua.Enabled = true;
            this.btnXoa.Enabled = true;

            this.btnLuu.Enabled = false;
            this.btnHuy.Enabled = false;
            this.panel1.Enabled = false;
            dgvDichVu_CellClick(null, null);
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            Them = false;
            this.panel1.Enabled = true;
            dgvDichVu_CellClick(null, null);

            this.btnLuu.Enabled = true;
            this.btnHuy.Enabled = true;
            this.panel1.Enabled = true;

            this.txtMaDV.Enabled = false;
            this.btnThem.Enabled = false;
            this.btnSua.Enabled = false;
            this.btnXoa.Enabled = false;
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            try
            {
                int r = dgvDichVu.CurrentCell.RowIndex;
                string strDICHVU = dgvDichVu.Rows[r].Cells[0].Value.ToString();

                DialogResult traloi;
                traloi = MessageBox.Show("Chắc xóa mẫu tin này ko?", "Trả lời",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);


                if (traloi == DialogResult.Yes)
                {
                    dbDV.XoaDichVu(ref err, strDICHVU);
                    LoadData();
                    MessageBox.Show("Đã Xóa Xong!");
                }
                else
                {
                    MessageBox.Show("Ko thực hiện vc xóa mẫu tin!");
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Ko xóa đc. Lỗi r!");
            }
        }
    }
}
