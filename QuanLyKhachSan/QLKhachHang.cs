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
    public partial class QLKhachHang : Form
    {
        // Khai báo biến kiểm tra việc Thêm hay Sửa dữ liệu  
        bool Them;
        string err;
        BLKhachHang dbKH = new BLKhachHang();
        QuanLyKhachSanEntities qlksEntity = new QuanLyKhachSanEntities();
        public QLKhachHang()
        {
            InitializeComponent();
        }
        void LoadData()
        {
            try
            {

                // đưa dữ liệu lên DGV
                dgvKhachHang.DataSource = dbKH.LayKhachHang();
                // ko cho thao tác
                this.btnLuu.Enabled = false;
                this.btnHuy.Enabled = false;
                this.panel1.Enabled = false;
                // cho thao tác
                this.btnThem.Enabled = true;
                this.btnSua.Enabled = true;
                this.btnXoa.Enabled = true;

                dgvKhachHang_CellClick(null, null);
            }
            catch (SqlException)
            {
                MessageBox.Show("Ko lấy đc dữ liệu. Lỗi r!!");
            }
        }

        private void dgvKhachHang_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int r = dgvKhachHang.CurrentCell.RowIndex;
            this.txtMaKH.Text =
            dgvKhachHang.Rows[r].Cells[0].Value.ToString().Trim();
            this.txtTenKH.Text =
            dgvKhachHang.Rows[r].Cells[1].Value.ToString().Trim();
            this.dtpNgaySinh.Text =
           dgvKhachHang.Rows[r].Cells[2].Value.ToString().Trim();
            this.cbxGioiTinh.Text =
           dgvKhachHang.Rows[r].Cells[3].Value.ToString().Trim();
            this.txtCMND.Text =
           dgvKhachHang.Rows[r].Cells[4].Value.ToString().Trim();
            this.txtSDT.Text =
           dgvKhachHang.Rows[r].Cells[5].Value.ToString().Trim();
            this.cbxQuocTich.Text =
           dgvKhachHang.Rows[r].Cells[6].Value.ToString().Trim();
        }

        private void QLKhachHang_Load(object sender, EventArgs e)
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
            this.txtMaKH.Clear();
            this.txtSDT.Clear();
            this.txtTenKH.Clear();
            this.txtTimKiem.Clear();
            this.txtMaKH.Enabled = true;
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
                    BLKhachHang blKh = new BLKhachHang();
                    blKh.ThemKhachHang(this.txtMaKH.Text.Trim(), this.txtTenKH.Text.Trim(), this.dtpNgaySinh.Value,
                        this.cbxGioiTinh.Text.Trim(), this.txtCMND.Text.Trim(), this.txtSDT.Text.Trim(), this.cbxQuocTich.Text.Trim(), ref err);
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
                BLKhachHang blKh = new BLKhachHang();
                blKh.CapNhatKhachHang(this.txtMaKH.Text.Trim(), this.txtTenKH.Text.Trim(), this.dtpNgaySinh.Value,
                        this.cbxGioiTinh.Text.Trim(), this.txtCMND.Text.Trim(), this.txtSDT.Text.Trim(), this.cbxQuocTich.Text.Trim(), ref err);
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
            dgvKhachHang_CellClick(null, null);
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            Them = false;
            this.panel1.Enabled = true;
            dgvKhachHang_CellClick(null, null);
    
            this.btnLuu.Enabled = true;
            this.btnHuy.Enabled = true;
            this.panel1.Enabled = true;

            this.txtMaKH.Enabled = false;
            this.btnThem.Enabled = false;
            this.btnSua.Enabled = false;
            this.btnXoa.Enabled = false;
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            try
            {
                int r = dgvKhachHang.CurrentCell.RowIndex;
                string strKHACHHANG = dgvKhachHang.Rows[r].Cells[0].Value.ToString();

                DialogResult traloi;
                traloi = MessageBox.Show("Chắc xóa mẫu tin này ko?", "Trả lời",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (traloi == DialogResult.Yes)
                {
                    dbKH.XoaKhachHang(ref err, strKHACHHANG);
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
            var list = (from s in qlksEntity.KHACHHANGs
                        where s.MaKH == txtTimKiem.Text.Trim()
                        select new { s.MaKH, s.TenKH, s.NgaySinh, s.GioiTinh, s.CMND, s.SDT, s.QuocTich }).ToList();
            dgvKhachHang.DataSource = list;
            txtMaKH.DataBindings.Clear();
            txtTenKH.DataBindings.Clear();
            dtpNgaySinh.DataBindings.Clear();
            cbxGioiTinh.DataBindings.Clear();
            txtCMND.DataBindings.Clear();
            txtSDT.DataBindings.Clear();
            cbxQuocTich.DataBindings.Clear();

            txtMaKH.DataBindings.Add("text", list, "MaKH");
            txtTenKH.DataBindings.Add("text", list, "TenKH");
            dtpNgaySinh.DataBindings.Add("text", list, "NgaySinh");
            cbxGioiTinh.DataBindings.Add("text", list, "GioiTinh");
            txtCMND.DataBindings.Add("text", list, "CMND");
            txtSDT.DataBindings.Add("text", list, "SDT");
            cbxQuocTich.DataBindings.Add("text", list, "QuocTich");
        }
    }
}
