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
    public partial class QLHoaDonDV : Form
    {

        // Khai báo biến kiểm tra việc Thêm hay Sửa dữ liệu  
        bool Them;
        string err;
        BLHoaDon dbHD = new BLHoaDon();
        QuanLyKhachSanEntities qlksEntity = new QuanLyKhachSanEntities();
        public QLHoaDonDV()
        {
            InitializeComponent();
        }
        void LoadData()
        {
            try
            {
                // đưa dữ liệu lên DGV
                dgvHoaDon.DataSource = dbHD.LayHoaDon();
                // ko cho thao tác
                this.btnLuu.Enabled = false;
                this.btnHuy.Enabled = false;
                this.panel1.Enabled = false;
                // cho thao tác
                this.btnThem.Enabled = true;
                this.btnSua.Enabled = true;
                this.btnXoa.Enabled = true;

                var tps = from p in qlksEntity.DICHVUs select p.MaDV;

                cbxMaDV.DisplayMember = "MaDV";
                cbxMaDV.ValueMember = "MaDV";
                cbxMaDV.DataSource = tps.ToList();


                var tps1 = from p in qlksEntity.KHACHHANGs select p.MaKH;

                cbxMaKH.DisplayMember = "MaKH";
                cbxMaKH.ValueMember = "MaKH";
                cbxMaKH.DataSource = tps1.ToList();

                dgvHoaDon_CellClick(null, null);
            }
            catch (SqlException)
            {
                MessageBox.Show("Ko lấy đc dữ liệu. Lỗi r!!");
            }
        }

        private void dgvHoaDon_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int r = dgvHoaDon.CurrentCell.RowIndex;
            this.txtMaHD.Text =
            dgvHoaDon.Rows[r].Cells[0].Value.ToString().Trim();
            this.txtTenHD.Text =
            dgvHoaDon.Rows[r].Cells[1].Value.ToString().Trim();
            this.cbxMaDV.Text =
           dgvHoaDon.Rows[r].Cells[2].Value.ToString().Trim();
            this.cbxMaKH.Text =
           dgvHoaDon.Rows[r].Cells[3].Value.ToString().Trim();
            this.dtpNgayLapHD.Text =
           dgvHoaDon.Rows[r].Cells[4].Value.ToString().Trim();               
        }

        private void QLHoaDon_Load(object sender, EventArgs e)
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
            this.txtMaHD.Clear();
            this.txtTenHD.Clear();
            this.txtTimKiem.Clear();
            this.txtMaHD.Enabled = true;           
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
                    BLHoaDon blHd = new BLHoaDon();
                    blHd.ThemHoaDon(this.txtMaHD.Text.Trim(), this.txtTenHD.Text.Trim(), this.cbxMaDV.Text.Trim(),
                        this.cbxMaKH.Text.Trim(), this.dtpNgayLapHD.Value, ref err);
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
                BLHoaDon blHd = new BLHoaDon();
                blHd.CapNhatHoaDon(this.txtMaHD.Text.Trim(), this.txtTenHD.Text.Trim(), this.cbxMaDV.Text.Trim(),
                        this.cbxMaKH.Text.Trim(), this.dtpNgayLapHD.Value,  ref err);
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
            dgvHoaDon_CellClick(null, null);
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            Them = false;
            this.panel1.Enabled = true;
            dgvHoaDon_CellClick(null, null);

            this.btnLuu.Enabled = true;
            this.btnHuy.Enabled = true;
            this.panel1.Enabled = true;

            this.txtMaHD.Enabled = false;
            this.btnThem.Enabled = false;
            this.btnSua.Enabled = false;
            this.btnXoa.Enabled = false;
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            try
            {
                int r = dgvHoaDon.CurrentCell.RowIndex;
                string strHOADON = dgvHoaDon.Rows[r].Cells[0].Value.ToString();

                DialogResult traloi;
                traloi = MessageBox.Show("Chắc xóa mẫu tin này ko?", "Trả lời",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (traloi == DialogResult.Yes)
                {
                    dbHD.XoaHoaDon(ref err, strHOADON);
                    LoadData();
                    MessageBox.Show("Đã Xóa Xong!");
                }
                else
                {
                    MessageBox.Show("Ko thực hiện vc xóa mẫu tin!");
                }
            }
            catch (SqlException)
            {
                MessageBox.Show("Ko xóa đc. Lỗi r!");
            }
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            var list = (from s in qlksEntity.HOADONs
                        where s.MaKH == txtTimKiem.Text.Trim()
                        select new { s.MaHD, s.TenHD, s.MaDV, s.MaKH, s.NgayLapHD }).ToList();
            dgvHoaDon.DataSource = list;
            txtMaHD.DataBindings.Clear();
            txtTenHD.DataBindings.Clear();
            cbxMaDV.DataBindings.Clear();
            cbxMaKH.DataBindings.Clear();
            dtpNgayLapHD.DataBindings.Clear();
            txtMaHD.DataBindings.Add("text", list, "MaHD");
            txtTenHD.DataBindings.Add("text", list, "TenHD");
            cbxMaDV.DataBindings.Add("text", list, "MaDV");
            cbxMaKH.DataBindings.Add("text", list, "MaKH");
            dtpNgayLapHD.DataBindings.Add("text", list, "NgayLapHD");
        }
    }
}
