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
    public partial class FormChonNhanVien : Form
    {
        public FormChonNhanVien()
        {
            InitializeComponent();
        }

        private void FormPhanCongCongViec_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void btnTiep_Click(object sender, EventArgs e)
        {
            FormChonCongViec formCCV = new FormChonCongViec();
            this.Hide();
            formCCV.ShowDialog();
        }

        private void btnQuayLai_Click(object sender, EventArgs e)
        {
            FormGiaoDienQuanLy formGDQL = new FormGiaoDienQuanLy();
            this.Close();
            this.Hide();
            formGDQL.ShowDialog();
        }
    }
}
