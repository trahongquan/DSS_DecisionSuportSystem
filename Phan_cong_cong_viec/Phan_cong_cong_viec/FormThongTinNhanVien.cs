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
    public partial class FormThongTinNhanVien : Form
    {
        NhanVien nv = new NhanVien();
        NhanvienBLL nvbll = new NhanvienBLL();
        int index;
        public FormThongTinNhanVien()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            dtgrvNV.DataSource = nvbll.timKiem(txtTimKiem.Text.Trim());
        }

        private void FormThongTinNhanVien_Load(object sender, EventArgs e)
        {
            txtMaNV.ReadOnly = true;
            txtTenNV.ReadOnly = true;
            DTPNgaySinh.Enabled = false;
            RBNam.Enabled = false;
            RBNu.Enabled = false;
            txtDiaChi.ReadOnly = true;
            txtSoDienThoai.ReadOnly = true;
            RBQuanLy.Enabled = false;
            RBNhanvien.Enabled = false;
            dtgrvNV.DataSource = nvbll.HienThi();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            FormTraCuuThongTin formTCTT = new FormTraCuuThongTin();
            this.Close();
            this.Hide();
            formTCTT.ShowDialog();
        }

        private void dtgrvNV_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            index = e.RowIndex;
            if (index >= 0)
            {
                try
                {
                    txtMaNV.Text = dtgrvNV.Rows[index].Cells["Ma_NV"].Value.ToString();
                    txtTenNV.Text = dtgrvNV.Rows[index].Cells["Ten_NV"].Value.ToString();
                    DTPNgaySinh.Value = DateTime.Parse(dtgrvNV.Rows[index].Cells["Ngay_Sinh"].Value.ToString());
                    String gioitinh = dtgrvNV.Rows[index].Cells["Gioi_Tinh"].Value.ToString();
                    if (String.Compare(gioitinh, "Nam") == 0)
                    {
                        RBNam.Checked = true;
                    }
                    else
                    {
                        RBNu.Checked = true;
                    }
                    txtDiaChi.Text = dtgrvNV.Rows[index].Cells["Dia_Chi"].Value.ToString();
                    txtSoDienThoai.Text = dtgrvNV.Rows[index].Cells["So_Dien_Thoai"].Value.ToString();
                    String chucvu = dtgrvNV.Rows[index].Cells["Chuc_Vu"].Value.ToString();
                    if (String.Compare(gioitinh, "Quản lý") == 0)
                    {
                        RBQuanLy.Checked = true;
                    }
                    else
                    {
                        RBNhanvien.Checked = true;
                    }
                }
                catch (Exception)
                {
                    MessageBox.Show("Bạn chưa chọn nhân viên");
                }
            }
        }

        private void FormThongTinNhanVien_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
