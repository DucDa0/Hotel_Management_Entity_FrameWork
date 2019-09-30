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
    public partial class QLPhongThue_Info : Form
    {
        // Khai báo biến kiểm tra việc Thêm hay Sửa dữ liệu  
        bool Them;
        string err;
        BLPhongThue_Info dbPT_info = new BLPhongThue_Info();
        QuanLyKhachSanEntities qlksEntity = new QuanLyKhachSanEntities();
        public QLPhongThue_Info()
        {
            InitializeComponent();
        }
        void LoadData()
        {
            try
            {

                // đưa dữ liệu lên DGV
                dgvPhongThue_info.DataSource = dbPT_info.LayPhongThue_info();
                // ko cho thao tác
                this.btnLuu.Enabled = false;
                this.btnHuy.Enabled = false;
                this.panel1.Enabled = false;
                // cho thao tác
                this.btnThem.Enabled = true;
                this.btnSua.Enabled = true;
                this.btnXoa.Enabled = true;

                dgvPhongThue_info_CellClick(null, null);
            }
            catch (SqlException)
            {
                MessageBox.Show("Ko lấy đc dữ liệu. Lỗi r!!");
            }
        }

        private void dgvPhongThue_info_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int r = dgvPhongThue_info.CurrentCell.RowIndex;
            this.txtTenPhong.Text =
            dgvPhongThue_info.Rows[r].Cells[0].Value.ToString().Trim();
            this.txtLoaiPhong.Text =
            dgvPhongThue_info.Rows[r].Cells[1].Value.ToString().Trim();
            this.cbxTinhTrang.Text =
            dgvPhongThue_info.Rows[r].Cells[2].Value.ToString().Trim();
        }

        private void QLPhongThue_Info_Load(object sender, EventArgs e)
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
            this.txtLoaiPhong.Clear();
            this.txtTenPhong.Clear();
            this.txtTimKiem.Clear();
            this.txtTenPhong.Enabled = true;
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
                    BLPhongThue_Info blPt = new BLPhongThue_Info();
                    blPt.ThemPhongThue_info(this.txtTenPhong.Text.Trim(), this.txtLoaiPhong.Text.Trim(), this.cbxTinhTrang.Text.Trim(), ref err);
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
                BLPhongThue_Info blPt = new BLPhongThue_Info();
                blPt.CapNhatPhongThue_info(this.txtTenPhong.Text.Trim(), this.txtLoaiPhong.Text.Trim(), this.cbxTinhTrang.Text.Trim(), ref err);
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
            dgvPhongThue_info_CellClick(null, null);
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            Them = false;
            this.panel1.Enabled = true;
            dgvPhongThue_info_CellClick(null, null);

            this.btnLuu.Enabled = true;
            this.btnHuy.Enabled = true;
            this.panel1.Enabled = true;

            this.txtTenPhong.Enabled = false;
            this.btnThem.Enabled = false;
            this.btnSua.Enabled = false;
            this.btnXoa.Enabled = false;
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            try
            {
                int r = dgvPhongThue_info.CurrentCell.RowIndex;
                string strPHONGTHUE_info = dgvPhongThue_info.Rows[r].Cells[0].Value.ToString();

                DialogResult traloi;
                traloi = MessageBox.Show("Chắc xóa mẫu tin này ko?", "Trả lời",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (traloi == DialogResult.Yes)
                {
                    dbPT_info.XoaPhongThue_info(ref err, strPHONGTHUE_info);
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

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            var list = (from s in qlksEntity.THONGTIN_PHONG
                        where s.TenPhong == txtTimKiem.Text.Trim()
                        select new { s.TenPhong, s.LoaiPhong, s.TinhTrang }).ToList();
            dgvPhongThue_info.DataSource = list;
            txtTenPhong.DataBindings.Clear();
            txtLoaiPhong.DataBindings.Clear();
            cbxTinhTrang.DataBindings.Clear();

            txtTenPhong.DataBindings.Add("text", list, "TenPhong");
            txtLoaiPhong.DataBindings.Add("text", list, "LoaiPhong");
            cbxTinhTrang.DataBindings.Add("text", list, "TinhTrang");
        }
    }
}
