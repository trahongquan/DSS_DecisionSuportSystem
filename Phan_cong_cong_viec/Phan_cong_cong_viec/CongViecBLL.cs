using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Phan_cong_cong_viec
{
    class CongViecBLL
    {
        DAL dal = new DAL();

        public bool them(CongViec CV)
        {
            string sql = "insert into Cong_Viec(Ma_CV, Ten_CV,Tai_CV, Ghi_chu)" +
                " values (N'" + CV.ma_CV + "', N'" + CV.ten_CV + "', '" + CV.tai_CV + "', '" + CV.ghi_chu + "')";
            return dal.excuteNonQuery(sql);
        }

        public bool sua(CongViec CV)
        {
            string sql = "update Cong_Viec set Ten_CV = N'" + CV.ten_CV + "', Tai_CV = N'" + CV.tai_CV + "',  Ghi_chu = N'" + CV.ghi_chu + "' where Ma_CV = N'" + CV.ma_CV + "' ";
            return dal.excuteNonQuery(sql);
        }

        public bool xoa(string ma_cv)
        {
            string sql = "delete Cong_Viec where Ma_CV = '" + ma_cv + "'";
            return dal.excuteNonQuery(sql);
        }

        public DataTable timKiem(string dieuKien)
        {
            string sql = "select * from Cong_Viec where Ma_CV = '" + dieuKien + "'";
            return dal.getTable(sql);
        }

        public DataTable HienThi()
        {
            string sql = "select * from Cong_Viec ";
            return dal.getTable(sql);
        }
    }
}
