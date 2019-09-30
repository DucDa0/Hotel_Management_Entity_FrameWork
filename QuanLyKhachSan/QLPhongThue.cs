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
    public partial class QLPhongThue : Form
    {
        // Khai báo biến kiểm tra việc Thêm hay Sửa dữ liệu  
        bool Them;
        string err;
        BLPhongThue dbPT = new BLPhongThue();
        QuanLyKhachSanEntities qlksEntity = new QuanLyKhachSanEntities();
        public QLPhongThue()
        {
            InitializeComponent();           
        }
        void LoadData()
        {
            try
            {
                // đưa dữ liệu lên DGV
                dgvPhongThue.DataSource = dbPT.LayPhongThue();
                // ko cho thao tác
                this.btnLuu.Enabled = false;
                this.btnHuy.Enabled = false;
                this.panel1.Enabled = false;
                // cho thao tác
                this.btnThem.Enabled = true;
                this.btnSua.Enabled = true;
                this.btnXoa.Enabled = true;


                var tps = from p in qlksEntity.KHACHHANGs select p.MaKH;

                cbxMaKH.DisplayMember = "MaKH";
                cbxMaKH.ValueMember = "MaKH";
                cbxMaKH.DataSource = tps.ToList();

                var tps1 = from p in qlksEntity.THONGTIN_PHONG select p.TenPhong;

                cbxTenPhong.DisplayMember = "TenPhong";
                cbxTenPhong.ValueMember = "TenPhong";
                cbxTenPhong.DataSource = tps1.ToList();

                dgvPhongThue_CellClick(null, null);
            }
            catch (SqlException)
            {
                MessageBox.Show("Ko lấy đc dữ liệu. Lỗi r!!");
            }
        }

        private void dgvPhongThue_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int r = dgvPhongThue.CurrentCell.RowIndex;

            this.txtMaDK.Text =
            dgvPhongThue.Rows[r].Cells[0].Value.ToString().Trim();
            this.cbxMaKH.Text =
            dgvPhongThue.Rows[r].Cells[1].Value.ToString().Trim();
            this.cbxTenPhong.Text =
            dgvPhongThue.Rows[r].Cells[2].Value.ToString().Trim();
            this.dtpNgayDK.Text =
            dgvPhongThue.Rows[r].Cells[3].Value.ToString().Trim();
            this.cbxTinhTrang.Text =
            dgvPhongThue.Rows[r].Cells[4].Value.ToString().Trim();           
        }

        private void QLPHONGTHUE_Load(object sender, EventArgs e)
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
            this.txtMaDK.Clear();
            this.txtTimKiem.Clear();
            this.txtMaDK.Enabled = true;
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
                    BLPhongThue blPt = new BLPhongThue();
                    blPt.ThemPhongThue(this.txtMaDK.Text.Trim(), this.cbxMaKH.Text.Trim(), this.cbxTenPhong.Text.Trim(),
                        this.dtpNgayDK.Value, this.cbxTinhTrang.Text.Trim(),  ref err);
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
                BLPhongThue blPt = new BLPhongThue();
                blPt.CapNhatPhongThue(this.txtMaDK.Text.Trim(), this.cbxMaKH.Text.Trim(), this.cbxTenPhong.Text.Trim(),
                        this.dtpNgayDK.Value, this.cbxTinhTrang.Text.Trim(),  ref err);
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
            dgvPhongThue_CellClick(null, null);
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            Them = false;
            this.panel1.Enabled = true;
            dgvPhongThue_CellClick(null, null);

            this.btnLuu.Enabled = true;
            this.btnHuy.Enabled = true;
            this.panel1.Enabled = true;

            this.txtMaDK.Enabled = false;
            this.btnThem.Enabled = false;
            this.btnSua.Enabled = false;
            this.btnXoa.Enabled = false;
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            try
            {
                int r = dgvPhongThue.CurrentCell.RowIndex;
                string strPHONGTHUE = dgvPhongThue.Rows[r].Cells[0].Value.ToString();

                DialogResult traloi;
                traloi = MessageBox.Show("Chắc xóa mẫu tin này ko?", "Trả lời",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (traloi == DialogResult.Yes)
                {
                    dbPT.XoaPhongThue(ref err, strPHONGTHUE);
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
            var list = (from s in qlksEntity.PHONGTHUEs
                        where s.MaKH == txtTimKiem.Text.Trim()
                        select new { s.MaDK, s.MaKH, s.TenPhong, s.NgayDK, s.TinhTrang }).ToList();
            dgvPhongThue.DataSource = list;
            txtMaDK.DataBindings.Clear();
            cbxMaKH.DataBindings.Clear();
            cbxTenPhong.DataBindings.Clear();
            dtpNgayDK.DataBindings.Clear();
            cbxTinhTrang.DataBindings.Clear();

            txtMaDK.DataBindings.Add("text", list, "MaDK");
            cbxMaKH.DataBindings.Add("text", list, "MaKH");
            cbxTenPhong.DataBindings.Add("text", list, "TenPhong");
            dtpNgayDK.DataBindings.Add("text", list, "NgayDK");
            cbxTinhTrang.DataBindings.Add("text", list, "TinhTrang");
        }
    }
}
