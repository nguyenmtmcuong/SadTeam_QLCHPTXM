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
    public partial class frmKhachHang : Form
    {
        ConnectToSQL cn = new ConnectToSQL();
        KhachHangControl khCtrl = new KhachHangControl();
        KhachHangModel khmod = new KhachHangModel();
        KhachHang kh = new KhachHang();
        int flag = 0;

        public frmKhachHang()
        {
            InitializeComponent();
        }

        private void frmKhachHang_Load(object sender, EventArgs e)
        {
            DataTable dtKhachHang = new DataTable();
            dtKhachHang = khCtrl.GetData();
            dgvKhachHang.DataSource = dtKhachHang;
            bingding();
            dis_en(false);
        }

        void bingding()
        {
            txtMaKH.DataBindings.Clear();
            txtMaKH.DataBindings.Add("Text", dgvKhachHang.DataSource, "MaKH");
            txtTenKH.DataBindings.Clear();
            txtTenKH.DataBindings.Add("Text", dgvKhachHang.DataSource, "TenKH");
            txtLoaiXe.DataBindings.Clear();
            txtLoaiXe.DataBindings.Add("Text", dgvKhachHang.DataSource, "MaLoaiXe");
            txtBienSo.DataBindings.Clear();
            txtBienSo.DataBindings.Add("Text", dgvKhachHang.DataSource, "BienSo");
            txtSoLanSuaChua.DataBindings.Clear();
            txtSoLanSuaChua.DataBindings.Add("Text", dgvKhachHang.DataSource, "SolanSuaChua");
            txtDiemTichLuy.DataBindings.Clear();
            txtDiemTichLuy.DataBindings.Add("Text", dgvKhachHang.DataSource, "DiemTichLuy");
            txtSDT.DataBindings.Clear();
            txtSDT.DataBindings.Add("Text", dgvKhachHang.DataSource, "SDT");
            txtGhiChu.DataBindings.Clear();
            txtGhiChu.DataBindings.Add("Text", dgvKhachHang.DataSource, "GhiChu");
        }


        void dis_en(bool e)
        {
            txtMaKH.Enabled = e;
            txtTenKH.Enabled = e;
            txtSoLanSuaChua.Enabled = e;
            txtLoaiXe.Enabled = e;
            txtSDT.Enabled = e;
            txtDiemTichLuy.Enabled = e;
            txtSoLanSuaChua.Enabled = e;
            txtGhiChu.Enabled = e;
            txtBienSo.Enabled = e;
            btnLuu.Enabled = e;
            btnHuy.Enabled = e;
            btnThem.Enabled = !e;
            btnSua.Enabled = !e;
            btnXoa.Enabled = !e;
        }

        void GanDuLieu(KhachHang kh)
        {
            kh.Ma = txtMaKH.Text.Trim();
            kh.Ten = txtTenKH.Text.Trim();
            kh.MaLoaiXe = txtLoaiXe.Text.Trim();
            kh.BienSo = txtBienSo.Text.Trim();
            kh.DiemTichLuy = int.Parse(txtDiemTichLuy.Text.Trim());
            kh.SoLanSuaChua = int.Parse(txtSoLanSuaChua.Text.Trim());
            kh.SDT = int.Parse(txtSDT.Text.Trim());
            kh.GhiChu = txtGhiChu.Text.Trim();
        }

        void cleardata()
        {
            txtMaKH.Text = "";
            txtTenKH.Text = "";
            txtLoaiXe.Text = "";
            txtBienSo.Text = "";
            txtDiemTichLuy.Text = "";
            txtSoLanSuaChua.Text = "";
            txtSDT.Text = "";
            txtGhiChu.Text = "";
        }



        private void btnThem_Click(object sender, EventArgs e)
        {
            flag = 0;
            cleardata();
            dis_en(true);
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            flag = 1;
            dis_en(true);
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Bạn chắc chắn muốn xóa?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                if (khCtrl.XoaKhachHang(txtMaKH.Text.Trim()))
                    MessageBox.Show("Xóa thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                else
                    MessageBox.Show("Xóa thất bại", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
                return;
            frmKhachHang_Load(sender, e);
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            GanDuLieu(kh);
            if (flag == 0)
            {
                if (khCtrl.ThemKhachHang(kh))
                    MessageBox.Show("Thêm thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                else
                    MessageBox.Show("Thêm thất bại", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (khCtrl.SuaKhachHang(kh))
                    MessageBox.Show("Sửa thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                else
                    MessageBox.Show("Sửa thất bại", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            frmKhachHang_Load(sender, e);
            dis_en(false);
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            frmKhachHang_Load(sender, e);
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            DialogResult h = MessageBox.Show
                ("Bạn chắc chắn muốn thoát?", "Error", MessageBoxButtons.OKCancel);
            if (h == DialogResult.OK)
            {
                frmKhachHang fnv = new frmKhachHang();
                this.Close();
            }
        }

        //public void txtNhap_TextChanged(object sender, EventArgs e)
        //{
        //    string sql = " select * from KhachHang where";
        //    if (rdnBienSo.Checked == true)
        //    {
        //        sql += " BienSo LIKE ' 	% " + txtNhap.Text + "%'";

        //    }
        //    dgvKhachHang.DataSource = khmod.GetData_Tim(sql);

            
        //}


    }
    
}
