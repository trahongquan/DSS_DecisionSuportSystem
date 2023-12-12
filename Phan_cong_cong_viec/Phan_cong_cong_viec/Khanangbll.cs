using System;
using System.Data;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Phan_cong_cong_viec
{
    
    class Khanangbll
    {
        DAL dal = new DAL();
        //NhanVien nv = new NhanVien();
        //CongViec cv = new CongViec();
       // List<NhanVien> listnv = new List<NhanVien>();
        //List<CongViec> listcv = new List<CongViec>();
        String sql,sql1,sql2;

        public DataTable Hienthichonkhanang(List<NhanVien> listnv, List<CongViec> listcv)
        {
            sql1 = "create table [dbo].[kha_nang2](Ten_Cong_Viec nvarchar(50) NULL";
            for(int i=0;i<listnv.Count;i++){                 
                 sql1 = sql1 + ",[" + listnv[i].ten_NV + "] bit NULL";
            }
            sql1 = sql1 + ")";
            dal.excuteNonQuery(sql1);

            for (int i = 0; i < listcv.Count; i++)
            {
                sql2 = "insert into kha_nang2(Ten_Cong_Viec) values ( N'" + listcv[i].ten_CV + "')";
                dal.excuteNonQuery(sql2);
            }
            sql = "select * from kha_nang2";
            return dal.getTable(sql);
        }

        public void Xoadata(){
            String sql3 = "drop table [dbo].[kha_nang2]";
            dal.excuteNonQuery(sql3);
        }
        
    }
}
