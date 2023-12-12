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
    public partial class FormPhanCong : Form
    {
        DAL dal = new DAL();
        NhanVien nv = new NhanVien();

        public FormPhanCong()
        {
            InitializeComponent();
        }

        private void FormPhanCong_Load(object sender, EventArgs e)
        {

            // TODO: This line of code loads data into the 'qL_phan_cong_cong_viecDataSet.Kha_Nang' table. You can move, or remove it, as needed.
           // this.kha_NangTableAdapter.Fill(this.qL_phan_cong_cong_viecDataSet.Kha_Nang);

        }
    }
}
