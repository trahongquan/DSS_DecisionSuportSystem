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
    public partial class FormGiaoDienNhanVien : Form
    {
        public FormGiaoDienNhanVien()
        {
            InitializeComponent();
        }

        private void btnXLPCCV_Click(object sender, EventArgs e)
        {
            FormXemLichPCCV formXLPCCV = new FormXemLichPCCV();
            this.Hide();
            formXLPCCV.ShowDialog();
        }

        private void btnTCTTCN_Click(object sender, EventArgs e)
        {
            FormTraCuuThongTin formTCTT = new FormTraCuuThongTin();
            this.Hide();
            formTCTT.ShowDialog();
        }

        private void FormGiaoDienNhanVien_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FormDangNhap formDangNhap = new FormDangNhap();
            this.Close();
            this.Hide();
            formDangNhap.ShowDialog();
        }
    }
}
