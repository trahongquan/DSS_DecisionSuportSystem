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
    public partial class FormPhanCongCongViec : Form
    {      
        NhanvienBLL nvbll = new NhanvienBLL();
        CongViecBLL cvbll = new CongViecBLL();
        Khanangbll knbll = new Khanangbll();
        List<NhanVien> listnv = new List<NhanVien>();
        List<CongViec> listcv = new List<CongViec>();
        public FormPhanCongCongViec()
        {
            InitializeComponent();
        }

        public int[]  mahoamatrankhannang()
        {
           // List<int> listkn = new List<int>();
            int m = dtgvKhaNang.RowCount;
            int n = dtgvKhaNang.ColumnCount;
            int[] A = new int[m*n];
            for(int i =0; i<dtgvKhaNang.RowCount; i++)
                for (int j = 0; j < dtgvKhaNang.ColumnCount; j++)
                {
                    int kn;
                    if (Convert.ToBoolean(dtgrvNV.Rows[i].Cells[0].Value) == true)
                    {
                        A[m*i+j] = 1;
                    }
                    else
                    {
                        A[m * i + j] = 0;
                    }
                }
            return A;
        }

        public int pow(int x, int y)
        {
            int ketqua = 1;
            for (int i = 1; i <= y; i++)
            {
                ketqua = ketqua * x;
            }
            return ketqua;
        }

        public int[] chuyenthapphansangnhiphan(int number, int n)
        {
            int i,j;
            int[] numberArray = new int[n];
            int[] X = new int[n];
            for (i = 0; number > 0; i++)
            {
                //chia lấy dư và lấy nguyên sau đó lưu vào mảng
                numberArray[i] = number % 2;
                number = number / 2;
            }
            for (i = n - 1; i >= 0; i--)
            {
                for(j=0; j<n; j++){
                    X[j] = numberArray[i];
                }             
            }
            return X;
        }

        public void SinhNgauNhienNST()
        {
            int m = dtgvKhaNang.RowCount;
            int n = dtgvKhaNang.ColumnCount;
            int[] A,X = new int[m*n];
            int s=0,S = 0, rangbuoc1=1, rangbuoc2=1;
           // int[] v1, v2, v3, v4, v5, v6, v7, v8, v9, v10, v11, v12, v13, v14, v15, v16, v17, v18, v19, v20 = new int[m * n];
           // List<int[]> listv = new List<int[]>;
            A=mahoamatrankhannang();
            for(int i=0;i<m*n+1;i++){
                s = s + pow(2,i);
            }
            int u=0;
            while(u < 21){
                
                Random rd = new Random();
                int numr = rd.Next(1,s);
                X = chuyenthapphansangnhiphan(numr, m*n);
                for(int k=0;k<n;k++){
                    for(int t=0;t<m;t++){
                        S = 0;
                        S += (X[k*m+t]);
                    };
                    rangbuoc1 *= S;
                }
                for(int k=0;k<n;k++){
                    for(int t=0;t<m;t++){
                        S = 0;
                        S += (X[k*m+t]*A[k*m+t]);
                    }
                    rangbuoc2 *= S;
                }
                if(rangbuoc1==1 && rangbuoc2==1){
                    u++;
                    //listv.Add(X);
                }
            }
        }

        //public void BanhXeRuLet(int[] v, int[] T, int n, int m)
        //{
        //    v = new int[n * m];
        //    T = new int[m];
        //    double[] f,eval,p,q = new double[20];
        //    int[] Y = new int[20];
        //    double TB,temp = 0;
        //    for (int k = 0; k < n; k++)
        //    {
        //        Y[k] = 0;
        //    }
        //    //while(int p<21){
        //    for (int k = 0; k < n; k++)
        //    {
        //        for (int t = 0; t < m; t++)
        //        {
        //            Y[k] += T[t] * v[k * m + t];
        //        }
        //        temp += Y[k];
        //    }
        //    TB = temp / n;
        //     for (int k = 0; k < n; k++){
        //         for (int t = 0; t < m; t++)
        //        {
        //            temp += Math.Pow(Y[t]-TB,2);
        //        }
        //        f[k] = temp / n;
        //     }

        //     for (int k = 0; k < n; k++) {
        //         eval[k] = 1 / f[k];
        //     }
        //}

        public void chonkhanang()
        {
            for (int i = 0; i < dtgrvNV.RowCount; i++)
            {
                if (Convert.ToBoolean(dtgrvNV.Rows[i].Cells[0].Value) == true)
                {
                    NhanVien nv = new NhanVien();
                    nv.ma_NV = dtgrvNV.Rows[i].Cells["Ma_NV"].Value.ToString();
                    nv.ten_NV = dtgrvNV.Rows[i].Cells["Ten_NV"].Value.ToString();
                    nv.ngay_sinh = DateTime.Parse(dtgrvNV.Rows[i].Cells["Ngay_Sinh"].Value.ToString());
                    nv.gioi_tinh = dtgrvNV.Rows[i].Cells["Gioi_Tinh"].Value.ToString();
                    nv.dia_chi = dtgrvNV.Rows[i].Cells["Dia_Chi"].Value.ToString();
                    nv.kha_nang = dtgrvNV.Rows[i].Cells["Kha_Nang"].Value.ToString();
                    nv.so_dien_thoai = dtgrvNV.Rows[i].Cells["So_Dien_Thoai"].Value.ToString();
                    nv.chuc_vu = dtgrvNV.Rows[i].Cells["Chuc_Vu"].Value.ToString();
                    listnv.Add(nv);
                }
            }
            for (int j = 0; j < dtgrvCV.RowCount; j++)
            {
                if (Convert.ToBoolean(dtgrvCV.Rows[j].Cells[0].Value) == true)
                {
                    CongViec cv = new CongViec();
                    cv.ma_CV = dtgrvCV.Rows[j].Cells["Ma_CV"].Value.ToString();
                    cv.ten_CV = dtgrvCV.Rows[j].Cells["Ten_CV"].Value.ToString();
                    cv.tai_CV = int.Parse(dtgrvCV.Rows[j].Cells["Tai_CV"].Value.ToString());
                    cv.ghi_chu = dtgrvCV.Rows[j].Cells["Ghi_Chu"].Value.ToString();
                    listcv.Add(cv);
                }
            }
            dtgvKhaNang.DataSource = knbll.Hienthichonkhanang(listnv, listcv);
        }
        private void FormKhaNang_Load(object sender, EventArgs e)
        {
            dtgrvNV.DataSource =  nvbll.HienThi();
            dtgrvCV.DataSource = cvbll.HienThi();
 
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            knbll.Xoadata();
            FormGiaoDienQuanLy formGDQL = new FormGiaoDienQuanLy();
            this.Close();
            this.Hide();
            formGDQL.ShowDialog();
            
        }

        private void FormKhaNang_FormClosed(object sender, FormClosedEventArgs e)
        {
            knbll.Xoadata();
            Application.Exit();
            
        }

        private void btnTinhToan_Click(object sender, EventArgs e)
        {
            lb1.Text = "Bảng phân công công việc";
        }

        private void btnChon_Click(object sender, EventArgs e)
        {
            lb1.Text = "Lựa chọn khả năng";
            this.chonkhanang();
        }
    }
}
