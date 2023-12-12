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
    public partial class FormCongViec : Form
    {
        CongViec cv = new CongViec();
        CongViecBLL cvbll = new CongViecBLL();
        int index;
        public FormCongViec()
        {
            InitializeComponent();
        }

        private void layThongTinCV()
        {
            cv.ma_CV = txtMaCV.Text.Trim();
            cv.ten_CV = txtTenCV.Text.Trim();
            cv.tai_CV = int.Parse(txtTaiCV.Text.Trim());
            cv.ghi_chu = txtGhiChu.Text.Trim();
        }

        private void dtgrvCV_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtMaCV.ReadOnly = true;
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
                    MessageBox.Show("Bạn chưa chọn khách hàng");
                }
            }
        }

        private void btnHienThi_Click(object sender, EventArgs e)
        {
            txtMaCV.ReadOnly = true;
            dtgrvCV.DataSource = cvbll.HienThi();
        }


        private void FormCongViec_Load_1(object sender, EventArgs e)
        {
            dtgrvCV.DataSource = cvbll.HienThi();
        }

        private void btnXoa_Click_1(object sender, EventArgs e)
        {
            txtMaCV.ReadOnly = true;
            DialogResult chon = MessageBox.Show("Bạn có chắc xóa công việc: " + txtTenCV.Text, "Thông báo", MessageBoxButtons.YesNo);
            if (chon == DialogResult.Yes)
            {
                if (cvbll.xoa(txtMaCV.Text))
                {
                    MessageBox.Show("Xóa thành công");
                    btnHienThi_Click(sender, e);
                }
                else
                    MessageBox.Show("Xóa không thành công");

            }
        }

        private void btnDatLai_Click_1(object sender, EventArgs e)
        {
            txtMaCV.ReadOnly = false;
            txtMaCV.Text = "";
            txtTenCV.Text = "";
            txtTaiCV.Text = "";
            txtGhiChu.Text = "";
        }

        private void btnThem_Click_1(object sender, EventArgs e)
        {
            txtMaCV.ReadOnly = true;
            layThongTinCV();
            if (txtMaCV.Text == string.Empty)
            {
                MessageBox.Show("Mã công việc không được trống");
            }
            else if (txtTenCV.Text == string.Empty)
            {
                MessageBox.Show("Tên công việc không được trống");
            }
            else if (txtTaiCV.Text == string.Empty)
            {
                MessageBox.Show("Tải công việc không được trống");
            }

            else
            {
                if (cvbll.them(cv))
                {
                    MessageBox.Show("Thêm thành công");
                    dtgrvCV.DataSource = cvbll.timKiem(cv.ma_CV);
                }
                else
                    MessageBox.Show("Thêm không thành công");
            }
        }

        private void btnSua_Click_1(object sender, EventArgs e)
        {
            txtMaCV.ReadOnly = true;
            layThongTinCV();
            if (txtMaCV.Text == string.Empty)
            {
                MessageBox.Show("Mã công việc không được trống");
            }
            else if (txtTenCV.Text == string.Empty)
            {
                MessageBox.Show("Tên công việc không được trống");
            }
            else if (txtTaiCV.Text == string.Empty)
            {
                MessageBox.Show("Tải công việc không được trống");
            }
            else
            {
                if (cvbll.sua(cv))
                {
                    MessageBox.Show("Sửa thành công");
                    dtgrvCV.DataSource = cvbll.timKiem(cv.ma_CV);
                }
                else
                    MessageBox.Show("Sửa không thành công");
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            txtMaCV.ReadOnly = true;
            dtgrvCV.DataSource = cvbll.timKiem(txtTimKiem.Text.Trim());
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            FormGiaoDienQuanLy formGDQL = new FormGiaoDienQuanLy();
            this.Close();
            this.Hide();
            formGDQL.ShowDialog();
        }

        private void FormCongViec_FormClosed_1(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}