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
    public partial class FormNhanVien : Form
    {
        NhanVien nv = new NhanVien();
        NhanvienBLL nvbll = new NhanvienBLL();
        DangnhapBLL dnbll = new DangnhapBLL();
        int index;
        public FormNhanVien()
        {
            InitializeComponent();
        }
        private void layThongTinNV()
        {
            nv.ma_NV = txtMaNV.Text.Trim();
            nv.ten_NV = txtTenNV.Text.Trim();
            nv.ngay_sinh = DTPNgaySinh.Value;
            if(RBNam.Checked){
                nv.gioi_tinh = "Nam";
            }
            else{
                nv.gioi_tinh = "Nữ";
            }
            nv.dia_chi = txtDiaChi.Text.Trim();
            nv.kha_nang = txtKhaNang.Text.Trim();
            nv.so_dien_thoai = txtSoDienThoai.Text.Trim();
            if (ckbQuanLy.Checked)
            {
                nv.chuc_vu = "Quản lý";
            }
            else
            {
                nv.chuc_vu = "Nhân viên";
            }
        }

        private void FormNhanVien_Load(object sender, EventArgs e)
        {
            dtgrvNV.DataSource = nvbll.HienThi();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            txtMaNV.ReadOnly = true;
            layThongTinNV();
            if (txtMaNV.Text == string.Empty)
            {
                MessageBox.Show("Mã nhân viên không được trống");
            }
            else if (txtTenNV.Text == string.Empty)
            {
                MessageBox.Show("Tên nhân viên không được trống");
            }
            else if (nv.gioi_tinh == string.Empty)
            {
                MessageBox.Show("Chưa chọn giới tính");
            }
            else if (nv.dia_chi == string.Empty)
            {
                MessageBox.Show("Chưa nhập địa chỉ");
            }
            else if (nv.so_dien_thoai == string.Empty)
            {
                MessageBox.Show("Chưa nhập số điện thoại");
            }
            else if (nv.chuc_vu == string.Empty)
            {
                MessageBox.Show("Chưa chọn chức vụ");
            }
            else
            {
                if (nvbll.them(nv) && dnbll.ThemTaiKhoan(nv))
                {
                    MessageBox.Show("Thêm thành công");
                    dtgrvNV.DataSource = nvbll.timKiem(nv.ma_NV);
                }
                else
                    MessageBox.Show("Thêm không thành công");
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            txtMaNV.ReadOnly = true;
            layThongTinNV();
            if (txtTenNV.Text == string.Empty)
            {
                MessageBox.Show("Tên nhân viên không được trống");
            }
            else if (nv.ngay_sinh == null)
            {
                MessageBox.Show("Chưa chọn ngày sinh");
            }
            else if (nv.gioi_tinh == string.Empty)
            {
                MessageBox.Show("Chưa chọn giới tính");
            }
            else if (nv.dia_chi == string.Empty)
            {
                MessageBox.Show("Chưa nhập địa chỉ");
            }
            else if (nv.so_dien_thoai == string.Empty)
            {
                MessageBox.Show("Chưa nhập số điện thoại");
            }
            else if (nv.chuc_vu == string.Empty)
            {
                MessageBox.Show("Chưa chọn chức vụ");
            }
            else
            {
                if (nvbll.sua(nv))
                {
                    MessageBox.Show("Sửa thành công");
                    dtgrvNV.DataSource = nvbll.timKiem(nv.ma_NV);
                }
                else
                    MessageBox.Show("Sửa không thành công");
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            txtMaNV.ReadOnly = true;
            DialogResult chon = MessageBox.Show("Bạn có chắc xóa công việc: " + txtTenNV.Text, "Thông báo", MessageBoxButtons.YesNo);
            if (chon == DialogResult.Yes)
            {
                if (nvbll.xoa(txtMaNV.Text))
                {
                    MessageBox.Show("Xóa thành công");
                    btnHienThi_Click(sender, e);
                }
                else
                    MessageBox.Show("Xóa không thành công");
            }
        }

        private void btnHienThi_Click(object sender, EventArgs e)
        {
            txtMaNV.ReadOnly = true;
            dtgrvNV.DataSource = nvbll.HienThi();
        }

        private void btnDatLai_Click(object sender, EventArgs e)
        {
            txtMaNV.ReadOnly = false;
            txtMaNV.Text = "";
            txtTenNV.Text = "";
            txtDiaChi.Text = "";
            txtKhaNang.Text = "";
            txtSoDienThoai.Text = "";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            txtMaNV.ReadOnly = true;
            dtgrvNV.DataSource = nvbll.timKiem(txtTimKiem.Text.Trim());
        }

        private void dtgrvKH_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtMaNV.ReadOnly = true;
            index = e.RowIndex;
            if (index >= 0)
            {
                try
                {
                    txtMaNV.Text = dtgrvNV.Rows[index].Cells["Ma_NV"].Value.ToString();
                    txtTenNV.Text = dtgrvNV.Rows[index].Cells["Ten_NV"].Value.ToString();
                    DTPNgaySinh.Value = DateTime.Parse(dtgrvNV.Rows[index].Cells["Ngay_Sinh"].Value.ToString());
                    String gioitinh = dtgrvNV.Rows[index].Cells["Gioi_Tinh"].Value.ToString();
                    if(String.Compare(gioitinh,"Nam")==0)
                    {
                        RBNam.Checked = true;
                    }
                    else
                    {
                        RBNu.Checked = true;
                    }
                    txtDiaChi.Text = dtgrvNV.Rows[index].Cells["Dia_Chi"].Value.ToString();
                    txtKhaNang.Text = dtgrvNV.Rows[index].Cells["Kha_Nang"].Value.ToString();
                    txtSoDienThoai.Text = dtgrvNV.Rows[index].Cells["So_Dien_Thoai"].Value.ToString();
                    String chucvu = dtgrvNV.Rows[index].Cells["Chuc_Vu"].Value.ToString();
                    if (String.Compare(chucvu, "Quản lý") == 0)
                    {
                        ckbQuanLy.Checked = true;
                    }
                    else
                    {
                        ckbNhanVien.Checked = true;
                    }
                }
                catch (Exception)
                {
                    MessageBox.Show("Bạn chưa chọn khách hàng");
                }
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            FormGiaoDienQuanLy formGDQL = new FormGiaoDienQuanLy();
            this.Close();
            this.Hide();
            formGDQL.ShowDialog();
        }

        private void FormNhanVien_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
