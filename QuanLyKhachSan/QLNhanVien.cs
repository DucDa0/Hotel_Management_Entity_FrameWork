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
    public partial class QLNhanVien : Form
    {
        // Khai báo biến kiểm tra việc Thêm hay Sửa dữ liệu  
        bool Them;
        string err;
        BLNhanVien dbNV = new BLNhanVien();
        QuanLyKhachSanEntities qlksEntity = new QuanLyKhachSanEntities();
        public QLNhanVien()
        {
            InitializeComponent();
        }
        void LoadData()
        {
            try
            {

                // đưa dữ liệu lên DGV
                dgvNhanVien.DataSource = dbNV.LayNhanVien();
                // ko cho thao tác
                this.btnLuu.Enabled = false;
                this.btnHuy.Enabled = false;
                this.panel1.Enabled = false;
                // cho thao tác
                this.btnThem.Enabled = true;
                this.btnSua.Enabled = true;
                this.btnXoa.Enabled = true;

                var tps = from p in qlksEntity.CHUCVUs select p.MaChucVu;

                cbxMaChucVu.DisplayMember = "MaChucVu";
                cbxMaChucVu.ValueMember = "MaChucVu";
                cbxMaChucVu.DataSource = tps.ToList();

                dgvNhanVien_CellClick(null, null);
            }
            catch (SqlException)
            {
                MessageBox.Show("Ko lấy đc dữ liệu. Lỗi r!!");
            }
        }

        private void dgvNhanVien_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int r = dgvNhanVien.CurrentCell.RowIndex;

            this.txtMaNV.Text =
            dgvNhanVien.Rows[r].Cells[0].Value.ToString().Trim();           
            this.txtHoTen.Text =
            dgvNhanVien.Rows[r].Cells[1].Value.ToString().Trim();
            this.dtpNgaySinh.Text =
            dgvNhanVien.Rows[r].Cells[2].Value.ToString().Trim();
            this.cbxGioiTinh.Text =
            dgvNhanVien.Rows[r].Cells[3].Value.ToString().Trim();
            this.txtCMND.Text =
            dgvNhanVien.Rows[r].Cells[4].Value.ToString().Trim();
            this.txtDiaChi.Text =
            dgvNhanVien.Rows[r].Cells[5].Value.ToString().Trim();
            this.cbxMaChucVu.Text =
            dgvNhanVien.Rows[r].Cells[6].Value.ToString().Trim();
        }

        private void QLNhanVien_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void btnReload_Click(object sender, EventArgs e)
        {
            LoadData();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            Them = true;
            this.txtCMND.Clear();
            this.txtDiaChi.Clear();
            this.txtHoTen.Clear();
            this.txtMaNV.Clear();
            this.txtTimKiem.Clear();
            this.txtMaNV.Enabled = true;
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
                    BLNhanVien blNv = new BLNhanVien();
                    blNv.ThemNhanVien(this.txtMaNV.Text.Trim(), this.txtHoTen.Text.Trim(), this.dtpNgaySinh.Value,
                        this.cbxGioiTinh.Text, this.txtCMND.Text.Trim(), this.txtDiaChi.Text.Trim(), this.cbxMaChucVu.Text.Trim(), ref err);
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
                BLNhanVien blNv = new BLNhanVien();
                blNv.CapNhatNhanVien(this.txtMaNV.Text.Trim(), this.txtHoTen.Text.Trim(), this.dtpNgaySinh.Value,
                        this.cbxGioiTinh.Text, this.txtCMND.Text.Trim(), this.txtDiaChi.Text.Trim(), this.cbxMaChucVu.Text.Trim(), ref err);
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
            dgvNhanVien_CellClick(null, null);
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            Them = false;
            this.panel1.Enabled = true;
            dgvNhanVien_CellClick(null, null);

            this.btnLuu.Enabled = true;
            this.btnHuy.Enabled = true;
            this.panel1.Enabled = true;

            this.txtMaNV.Enabled = false;
            this.btnThem.Enabled = false;
            this.btnSua.Enabled = false;
            this.btnXoa.Enabled = false;
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            try
            {
                int r = dgvNhanVien.CurrentCell.RowIndex;
                string strNHANVIEN = dgvNhanVien.Rows[r].Cells[0].Value.ToString();

                DialogResult traloi;
                traloi = MessageBox.Show("Chắc xóa mẫu tin này ko?", "Trả lời",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (traloi == DialogResult.Yes)
                {
                    dbNV.XoaNhanVien(ref err, strNHANVIEN);
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

        private void btnThoat_Click(object sender, EventArgs e)
        {
            // khai báo biến traloi
            DialogResult traloi;
            // hiện hộp thoại hỏi đáp
            traloi = MessageBox.Show("Chắc ko?", "Trả Lời", MessageBoxButtons.OKCancel
                , MessageBoxIcon.Question);
            if (traloi == DialogResult.OK)
                this.Close();
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            var list = (from s in qlksEntity.NHANVIENs
                        where s.MaNV == txtTimKiem.Text.Trim()
                        select new { s.MaNV, s.HoTen, s.NgaySinh, s.GioiTinh, s.CMND_NV, s.DiaChi, s.MaChucVu }).ToList();
            dgvNhanVien.DataSource = list;
            txtMaNV.DataBindings.Clear();
            txtHoTen.DataBindings.Clear();
            dtpNgaySinh.DataBindings.Clear();
            cbxGioiTinh.DataBindings.Clear();
            txtCMND.DataBindings.Clear();
            txtDiaChi.DataBindings.Clear();
            cbxMaChucVu.DataBindings.Clear();

            txtMaNV.DataBindings.Add("text", list, "MaNV");
            txtHoTen.DataBindings.Add("text", list, "HoTen");
            dtpNgaySinh.DataBindings.Add("text", list, "NgaySinh");
            cbxGioiTinh.DataBindings.Add("text", list, "GioiTinh");
            txtCMND.DataBindings.Add("text", list, "CMND_NV");
            txtDiaChi.DataBindings.Add("text", list, "DiaChi");
            cbxMaChucVu.DataBindings.Add("text", list, "MaChucVu");
        }
    }
}
