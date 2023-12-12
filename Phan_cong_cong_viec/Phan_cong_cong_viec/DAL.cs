using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace Phan_cong_cong_viec
{
    class DAL
    {
        public SqlConnection getConnection()
        {
            try
            {
                return new SqlConnection("Data Source=ADMIN;Initial Catalog=QL_phan_cong_cong_viec;User ID=sa;Password=123456789");
            }
            catch (Exception)
            {
                MessageBox.Show("Lỗi kết nối với server", "Lỗi server", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
        }

        public DataTable getTable(string sql)
        {
            try
            {
                DataTable dt = new DataTable();
                SqlConnection conn = getConnection();
                SqlDataAdapter da = new SqlDataAdapter(sql, conn);
                da.Fill(dt);
                return dt;
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Lỗi: " + ex.ToString(), "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
        }

        public bool excuteNonQuery(string sql)
        {
            try
            {
                SqlConnection conn = getConnection();
                SqlCommand cmd = new SqlCommand(sql, conn);
                conn.Open();
                cmd.ExecuteNonQuery();
                cmd.Dispose();
                cmd.Clone();
                return true;
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Lỗi: " + ex.ToString(), "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }
    }
}

