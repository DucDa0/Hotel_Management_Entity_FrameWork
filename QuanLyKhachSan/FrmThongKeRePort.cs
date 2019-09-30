using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyKhachSan
{
    public partial class FrmThongKeRePort : Form
    {
        public FrmThongKeRePort()
        {
            InitializeComponent();
        }

        private void FrmThongKeRePort_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'DataSet1.THONGKE' table. You can move, or remove it, as needed.
            FrmThongKe f = new FrmThongKe();
            this.THONGKETableAdapter.Fill(this.DataSet1.THONGKE,f.Getdate1(),f.Getdate2());

            this.reportViewer1.RefreshReport();
        }

        private void reportViewer1_Load(object sender, EventArgs e)
        {

        }
    }
}
