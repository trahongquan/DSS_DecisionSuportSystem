using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Phan_cong_cong_viec
{
    public partial class FormGiaoDienQuanLy : Form
    {
        public FormGiaoDienQuanLy()
        {
            InitializeComponent();
        }

        private void btnPCCV_Click(object sender, EventArgs e)
        {
            FormPhanCongCongViec formKN = new FormPhanCongCongViec();
            this.Hide();
            formKN.ShowDialog();
        }

        private void btnQLNV_Click(object sender, EventArgs e)
        {
            FormNhanVien formNV = new FormNhanVien();
            this.Hide();
            formNV.ShowDialog();
        }

        private void btnQLCV_Click(object sender, EventArgs e)
        {
            FormCongViec formCV = new FormCongViec();
            this.Hide();
            formCV.ShowDialog();
        }

        private void FormGiaoDienQuanLy_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();   
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            FormDangNhap formdangnhap = new FormDangNhap();
            this.Close();
            this.Hide();
            formdangnhap.ShowDialog();
        }
    }
}
