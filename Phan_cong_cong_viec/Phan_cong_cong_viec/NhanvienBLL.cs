using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Phan_cong_cong_viec
{
    class NhanvienBLL
    {
         DAL dal = new DAL();

        public bool them(NhanVien NV)
        {
            string sql = "insert into Nhan_vien(Ma_NV, Ten_NV, Ngay_Sinh, Gioi_Tinh, Dia_Chi, Kha_Nang, So_Dien_Thoai, Chuc_Vu)" +
                " values (N'" + NV.ma_NV + "', N'" + NV.ten_NV + "', '" + NV.ngay_sinh + "', N'" + NV.gioi_tinh + "', N'" + NV.dia_chi + "', '" + NV.kha_nang + "', '" + NV.so_dien_thoai + "', N'" + NV.chuc_vu + "')";
            return dal.excuteNonQuery(sql);
        }

        public bool sua(NhanVien NV)
        {
            string sql = "update Nhan_vien set Ten_NV = N'" + NV.ten_NV + "', Ngay_Sinh = '" + NV.ngay_sinh + "',  Gioi_Tinh = N'" + NV.gioi_tinh + "', Dia_Chi = N'" + NV.dia_chi + "', Kha_Nang = '" + NV.kha_nang + "', So_Dien_Thoai = '" + NV.so_dien_thoai + "', Chuc_Vu = N'" + NV.chuc_vu + "' where Ma_NV = N'" + NV.ma_NV + "' ";
            return dal.excuteNonQuery(sql);
        }

        public bool xoa(string ma_nv)
        {
            string sql = "delete Nhan_vien where Ma_NV = '" + ma_nv + "'";
            return dal.excuteNonQuery(sql);
        }

        public DataTable timKiem(string dieuKien)
        {
            string sql = "select * from Nhan_vien where Ma_NV = '" + dieuKien + "'";
            return dal.getTable(sql);
        }

        public DataTable HienThi()
        {
            string sql = "select * from Nhan_vien ";
            return dal.getTable(sql);
        }
    }
}
