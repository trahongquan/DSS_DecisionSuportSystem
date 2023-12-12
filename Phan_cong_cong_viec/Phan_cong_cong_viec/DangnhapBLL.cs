using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Phan_cong_cong_viec
{
    class DangnhapBLL
    {
        DAL dal = new DAL();
        public DataTable TimKiem(string ma, string matKhau)
        {
            string sql = "select * from Tai_Khoan where Tai_Khoan = '" + ma + "' and Mat_Khau = '" + matKhau + "'";
            return dal.getTable(sql);
        }

        public bool ThemTaiKhoan(NhanVien nv)
        {
            string sql = "insert into Tai_Khoan(Tai_Khoan, Mat_Khau, Chuc_Vu)"+
                "value(N'" + nv.ma_NV + "', N'" + nv.ma_NV + "', N'" + nv.chuc_vu + "')";
            return dal.excuteNonQuery(sql);
        }

        public DataTable LayNV()
        {
            string sql = "select * from Nhan_vien";
            DataTable dt = new DataTable();
            dt = dal.getTable(sql);
            return dt;
        }
    }
}
