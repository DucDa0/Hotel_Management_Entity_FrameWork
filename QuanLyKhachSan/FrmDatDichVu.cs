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
    public partial class FrmDatDichVu : Form
    {
        BLDichVu dbDV = new BLDichVu();
        QuanLyKhachSanEntities qlksEntity = new QuanLyKhachSanEntities();
        public FrmDatDichVu()
        {
            InitializeComponent();
        }
        void LoadData()
        {
            try
            {
                // đưa dữ liệu lên DGV
                dgvDichVu.DataSource = dbDV.LayDichVu();

                var tps = from p in qlksEntity.DICHVUs select p.MaDV;

                cbxMaDV.DisplayMember = "MaDV";
                cbxMaDV.ValueMember = "MaDV";
                cbxMaDV.DataSource = tps.ToList();

                var tps1 = from p in qlksEntity.DICHVUs select p.TenDV;

                cbxTenDV.DisplayMember = "TenDV";
                cbxTenDV.ValueMember = "TenDV";
                cbxTenDV.DataSource = tps1.ToList();
            }
            catch (SqlException)
            {
                MessageBox.Show("Ko lấy đc dữ liệu. Lỗi r!!");
            }
        }

        private void FrmDatDichVu_Load(object sender, EventArgs e)
        {
            LoadData();

        }

        private void btnReload_Click(object sender, EventArgs e)
        {
            LoadData();
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {

            if (rBMaDV.Checked == true)
            {
                var list = (from s in qlksEntity.DICHVUs
                            where s.MaDV == cbxMaDV.SelectedValue.ToString()
                            select new { s.MaDV, s.TenDV, s.GiaDV, s.MaNV }).ToList();
                dgvDichVu.DataSource = list;
            }
            if (rBTenDV.Checked == true)
            {
                var list = (from s in qlksEntity.DICHVUs
                            where s.TenDV == cbxTenDV.SelectedValue.ToString()
                            select new { s.MaDV, s.TenDV, s.GiaDV, s.MaNV }).ToList();
                dgvDichVu.DataSource = list;
            }

            if (rBGiaDV.Checked == true)
            {
                int gia1 = Convert.ToInt32(txtGiaDV1.Text.Trim());
                int gia2 = Convert.ToInt32(txtGiaDV2.Text.Trim());
                var list = (from s in qlksEntity.DICHVUs
                            where s.GiaDV >= gia1 && s.GiaDV <= gia2
                            select new { s.MaDV, s.TenDV, s.GiaDV, s.MaNV }).ToList();
                dgvDichVu.DataSource = list;
            }
        }
    }
}
