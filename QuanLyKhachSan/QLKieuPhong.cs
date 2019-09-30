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
    public partial class QLKieuPhong : Form
    {
        // Khai báo biến kiểm tra việc Thêm hay Sửa dữ liệu  
        bool Them;
        string err;
        BLLoaiPhong dbLP = new BLLoaiPhong();
        public QLKieuPhong()
        {
            InitializeComponent();
        }
        void LoadData()
        {
            try
            {
                // đưa dữ liệu lên DGV
                dgvLoaiPhong.DataSource = dbLP.LayLoaiPhong();
                // ko cho thao tác
                this.btnLuu.Enabled = false;
                this.btnHuy.Enabled = false;
                this.panel1.Enabled = false;
                // cho thao tác
                this.btnThem.Enabled = true;
                this.btnSua.Enabled = true;
                this.btnXoa.Enabled = true;

                dgvLoaiPhong_CellClick(null, null);
            }
            catch (SqlException)
            {
                MessageBox.Show("Ko lấy đc dữ liệu. Lỗi r!!");
            }
        }

        private void dgvLoaiPhong_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int r = dgvLoaiPhong.CurrentCell.RowIndex;
            this.txtLoaiPhong.Text =
            dgvLoaiPhong.Rows[r].Cells[0].Value.ToString().Trim();
            this.txtGiaPhong.Text =
            dgvLoaiPhong.Rows[r].Cells[1].Value.ToString().Trim();           
        }

        private void QLKieuPhong_Load(object sender, EventArgs e)
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
            this.txtGiaPhong.Clear();
            this.txtLoaiPhong.Clear();
            this.txtLoaiPhong.Enabled = true;
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
                    BLLoaiPhong blLp = new BLLoaiPhong();
                    blLp.ThemLoaiPhong(this.txtLoaiPhong.Text.Trim(), Convert.ToInt32(this.txtGiaPhong.Text.Trim()), ref err);
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
                BLLoaiPhong blLp = new BLLoaiPhong();
                blLp.CapNhatLoaiPhong(this.txtLoaiPhong.Text.Trim(), Convert.ToInt32(this.txtGiaPhong.Text.Trim()),  ref err);
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
            dgvLoaiPhong_CellClick(null, null);
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            Them = false;
            this.panel1.Enabled = true;
            dgvLoaiPhong_CellClick(null, null);

            this.btnLuu.Enabled = true;
            this.btnHuy.Enabled = true;
            this.panel1.Enabled = true;

            this.txtLoaiPhong.Enabled = false;
            this.btnThem.Enabled = false;
            this.btnSua.Enabled = false;
            this.btnXoa.Enabled = false;
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            try
            {
                int r = dgvLoaiPhong.CurrentCell.RowIndex;
                string strLOAIPHONG = dgvLoaiPhong.Rows[r].Cells[0].Value.ToString();

                DialogResult traloi;
                traloi = MessageBox.Show("Chắc xóa mẫu tin này ko?", "Trả lời",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (traloi == DialogResult.Yes)
                {
                    dbLP.XoaLoaiPhong(ref err, strLOAIPHONG);
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
