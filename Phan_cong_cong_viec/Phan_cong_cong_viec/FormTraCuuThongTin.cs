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
    public partial class FormTraCuuThongTin : Form
    {
        public FormTraCuuThongTin()
        {
            InitializeComponent();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            FormGiaoDienNhanVien formGDNV = new FormGiaoDienNhanVien();
            this.Close();
            this.Hide();
            formGDNV.ShowDialog();
        }

        private void btnTTNV_Click(object sender, EventArgs e)
        {
            FormThongTinNhanVien formTTNV = new FormThongTinNhanVien();
            this.Hide();
            formTTNV.ShowDialog();
        }

        private void btnTTCV_Click(object sender, EventArgs e)
        {
            FormThongTinCongViec formTTCV = new FormThongTinCongViec();
            this.Hide();
            formTTCV.ShowDialog();
        }

        private void FormTraCuuThongTin_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
