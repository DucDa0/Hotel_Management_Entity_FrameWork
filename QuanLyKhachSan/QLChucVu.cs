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
    public partial class QLChucVu : Form
    {
        BLChucVu dbCV = new BLChucVu();
        public QLChucVu()
        {
            InitializeComponent();
        }
        void LoadData()
        {
            try
            {
                dgvChucVu.DataSource = dbCV.LayChucVu();
            }
            catch (SqlException)
            {
                MessageBox.Show("Ko lấy đc dữ liệu. Lỗi r!!");
            }
        }

        private void QLChucVu_Load(object sender, EventArgs e)
        {
            LoadData();
        }
    }
}
