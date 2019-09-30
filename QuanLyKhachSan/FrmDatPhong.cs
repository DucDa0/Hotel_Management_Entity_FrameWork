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
    public partial class FrmDatPhong : Form
    {
        BLLoaiPhong dbLP = new BLLoaiPhong();
        QuanLyKhachSanEntities qlksEntity = new QuanLyKhachSanEntities();
        public FrmDatPhong()
        {
            InitializeComponent();

        }
        void LoadData()
        {
            try
            {

                // đưa dữ liệu lên DGV
                dgvLoaiPhong.DataSource = dbLP.LayLoaiPhong();


                var tps = from p in qlksEntity.KIEUPHONGs select p.LoaiPhong;

                cbxLoaiPhong.DisplayMember = "LoaiPhong";
                cbxLoaiPhong.ValueMember = "LoaiPhong";
                cbxLoaiPhong.DataSource = tps.ToList();
            }
            catch (SqlException)
            {
                MessageBox.Show("Ko lấy đc dữ liệu. Lỗi r!!");
            }
        }
        private void btnThemKH_Click(object sender, EventArgs e)
        {
            QLKhachHang frmQLKH = new QLKhachHang();
            frmQLKH.Show();
        }

        private void btnDatPhong_Click(object sender, EventArgs e)
        {
            QLPhongThue frmQLPT = new QLPhongThue();
            frmQLPT.Show();
        }

        private void FrmDatPhong_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {

            if (rBTheoGT.Checked == true)
            {
                int gia1 = Convert.ToInt32(txtTien1.Text);
                int gia2 = Convert.ToInt32(txtTien2.Text);
                var list = (from s in qlksEntity.KIEUPHONGs
                            where s.GiaPhong >= gia1 &&
                            s.GiaPhong <= gia2
                            select new { s.LoaiPhong, s.GiaPhong }).ToList();
                dgvLoaiPhong.DataSource = list;
            }
            if (rBTheoLP.Checked == true)
            {
                var list = (from s in qlksEntity.KIEUPHONGs
                            where s.LoaiPhong == cbxLoaiPhong.SelectedValue.ToString()
                            select new { s.LoaiPhong, s.GiaPhong }).ToList();
                dgvLoaiPhong.DataSource = list;
            }
        }

        private void btnReload_Click(object sender, EventArgs e)
        {
            LoadData();
        }

        private void btnLoc_Click(object sender, EventArgs e)
        {
            FrmHienTrangPhong frmHTP = new FrmHienTrangPhong();
            frmHTP.Show();
        }
    }
}
