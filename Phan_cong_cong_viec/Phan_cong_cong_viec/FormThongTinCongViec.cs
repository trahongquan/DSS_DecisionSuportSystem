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
    public partial class FormThongTinCongViec : Form
    {
        CongViec cv = new CongViec();
        CongViecBLL cvbll = new CongViecBLL();
        int index;
        public FormThongTinCongViec()
        {
            InitializeComponent();          
        }
        

        private void btnThoat_Click(object sender, EventArgs e)
        {
            FormTraCuuThongTin formTCTT = new FormTraCuuThongTin();
            this.Close();
            this.Hide();
            formTCTT.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            dtgrvCV.DataSource = cvbll.timKiem(txtTimKiem.Text.Trim());
        }

        private void FormThongTinCongViec_Load(object sender, EventArgs e)
        {
            txtMaCV.ReadOnly = true;
            txtTenCV.ReadOnly = true;
            txtTaiCV.ReadOnly = true;
            txtGhiChu.ReadOnly = true;
            dtgrvCV.DataSource = cvbll.HienThi();
        }

        private void FormThongTinCongViec_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void dtgrvCV_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            index = e.RowIndex;
            if (index >= 0)
            {
                try
                {
                    txtMaCV.Text = dtgrvCV.Rows[index].Cells["Ma_CV"].Value.ToString();
                    txtTenCV.Text = dtgrvCV.Rows[index].Cells["Ten_CV"].Value.ToString();
                    txtTaiCV.Text = dtgrvCV.Rows[index].Cells["Tai_CV"].Value.ToString();
                    txtGhiChu.Text = dtgrvCV.Rows[index].Cells["Ghi_Chu"].Value.ToString();
                }
                catch (Exception)
                {
                    MessageBox.Show("Bạn chưa chọn công việc");
                }
            }
        }
    }
}
