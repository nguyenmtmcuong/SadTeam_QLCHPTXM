using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Configuration;

namespace QuanLyCuaHangPhuTungXeMay
{
    public partial class frmMain : Form
    {
        string cnStr;
        SqlConnection cn;

        public frmMain()
        {
            InitializeComponent();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            cnStr = "Server = .; Database = DatabaseQLCHPTXM; Integrated Security = true";
            cn = new SqlConnection(cnStr);
        }

        private void kháchHàngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmKhachHang formkh = new frmKhachHang();
            formkh.Show();
        }

        private void asdasdToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmPhuTung formpt = new frmPhuTung();
            formpt.Show();
        }

        private void asdasdToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmLoaiXe formlx = new frmLoaiXe();
            formlx.Show();
        }

        private void nhânViênToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmNhanVien formnv = new frmNhanVien();
            formnv.Show();
        }

        private void hóaĐơnBánHàngToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }


    }
}
