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
    public partial class FormDangNhap : Form
    {
        DangnhapBLL dnbll = new DangnhapBLL();
        public FormDangNhap()
        {
            InitializeComponent();
        }
        private void DangNhap_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void btnDangnhap_Click(object sender, EventArgs e)
        {
            DataTable dt = new DangnhapBLL().TimKiem(txtTaiKhoan.Text.Trim(), txtMatKhau.Text.Trim());
            try
            {
                if (txtTaiKhoan.Text.Trim() == String.Empty)
                {
                    MessageBox.Show("Bạn chưa nhập tài khỏa", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else if (txtMatKhau.Text.Trim() == String.Empty)
                {
                    MessageBox.Show("Bạn chưa nhập mật khẩu", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else if (dt.Rows.Count == 0)
                {
                    MessageBox.Show("tên đăng nhập hoặc mật khẩu không đúng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {

                    MessageBox.Show("Đăng nhập thành công");
                    string QuyenTruyCap = dt.Rows[0][2].ToString();
                    if (String.Compare(QuyenTruyCap, "Nhân viên", true)==0)
                    {
                        FormGiaoDienNhanVien formGDNV = new FormGiaoDienNhanVien();
                        this.Hide();
                        formGDNV.ShowDialog();
                    }
                    else
                    {
                        FormGiaoDienQuanLy formGDQL = new FormGiaoDienQuanLy();
                        this.Hide();
                        formGDQL.ShowDialog();
                    }
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi" + ex.Message, "lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void btnThoat_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
