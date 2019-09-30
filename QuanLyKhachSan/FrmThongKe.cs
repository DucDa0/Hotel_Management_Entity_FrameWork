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
    public partial class FrmThongKe : Form
    {
        string err;
        QuanLyKhachSanEntities qlksEntity = new QuanLyKhachSanEntities();
        public FrmThongKe()
        {
            InitializeComponent();
        }

        private void btnThongKe_Click(object sender, EventArgs e)
        {

            BLThongKe fTK = new BLThongKe();
            fTK.ThemTK(Convert.ToInt32(this.txtSLKH.Text.Trim()), Convert.ToInt32(this.txtSLDV.Text.Trim()), this.dtpNgayTK.Value, Convert.ToInt32(this.txtDoanhThu.Text.Trim()), ref err);


            FrmThongKeRePort frmTKR = new FrmThongKeRePort();
            frmTKR.ShowDialog();
        }
        public string Getdate1()
        {
            return dateTimePicker1.Value.ToShortDateString();
        }
        public string Getdate2()
        {
            return dateTimePicker2.Value.ToShortDateString();
        }

        private void btnLoc_Click(object sender, EventArgs e)
        {
            // Số Lượng KH đăng kí

            var list1 = (from s in qlksEntity.PHONGTHUEs where s.NgayDK >= dateTimePicker1.Value && s.NgayDK <= dateTimePicker2.Value select s).ToList();
            int SLKH = list1.Count;
            txtSLKH.Text = SLKH.ToString();

            // Số Lượng Dv đăng kí

            var list2 = (from s in qlksEntity.HOADONs where s.NgayLapHD >= dateTimePicker1.Value && s.NgayLapHD <= dateTimePicker2.Value select s).ToList();
            int SLDV = list2.Count;
            txtSLDV.Text = SLDV.ToString();

            // Tổng Doanh Thu                               
            listView1.Items.Clear();
            listView1.View = View.Details;
            listView1.GridLines = true;
            listView1.FullRowSelect = true;

            var list3 = (from s in qlksEntity.DULIEUx where s.NgayDi >= dateTimePicker1.Value && s.NgayDi <= dateTimePicker2.Value select s).ToList();

            int i = 0;
            foreach (var p in list3)
            {
                listView1.Items.Add(p.MaKH);
                listView1.Items[i].SubItems.Add(p.NgayDi.ToString());
                listView1.Items[i].SubItems.Add(p.TongGiaHD.ToString());
                i++;
            }
            int TongTien = 0;
            for (int j = 0; j < listView1.Items.Count; j++)
            {
                TongTien += Convert.ToInt32(listView1.Items[j].SubItems[2].Text);
            }
            txtDoanhThu.Text = TongTien.ToString();
        }

        private void FrmThongKe_Load(object sender, EventArgs e)
        {
            dateTimePicker1.Value = new DateTime(dateTimePicker1.Value.Year, dateTimePicker1.Value.Month, 1);
        }
    }
}
