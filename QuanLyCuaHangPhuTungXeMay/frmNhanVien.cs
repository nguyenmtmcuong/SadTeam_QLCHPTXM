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
using QuanLyCuaHangPhuTungXeMay.Properties;

namespace QuanLyCuaHangPhuTungXeMay
{
    public partial class frmNhanVien : Form
    {
        ConnectToSQL cn = new ConnectToSQL();
        NhanVienControl nvCtrl = new NhanVienControl();
        NhanVien nv = new NhanVien();
        int flag = 0;
        public frmNhanVien()
        {
            InitializeComponent();
        }

        private void frmNhanVien_Load(object sender, EventArgs e)
        {
            DataTable dtNhanVien = new DataTable();
            dtNhanVien = nvCtrl.GetData();
            dgvNhanVien.DataSource = dtNhanVien;
            bingding();
            dis_en(false);
        }

        void bingding()
        {
            txtMaNV.DataBindings.Clear();
            txtMaNV.DataBindings.Add("Text", dgvNhanVien.DataSource, "MaNV");
            txtTenNV.DataBindings.Clear();
            txtTenNV.DataBindings.Add("Text", dgvNhanVien.DataSource, "TenNV");
            txtMatKhau.DataBindings.Clear();
            txtMatKhau.DataBindings.Add("Text", dgvNhanVien.DataSource, "MatKhau");
            cbbChucVu.DataBindings.Clear();
            cbbChucVu.DataBindings.Add("Text", dgvNhanVien.DataSource, "ChucVu");
            txtSDT.DataBindings.Clear();
            txtSDT.DataBindings.Add("Text", dgvNhanVien.DataSource, "SDT");
            txtGhiChu.DataBindings.Clear();
            txtGhiChu.DataBindings.Add("Text", dgvNhanVien.DataSource, "GhiChu");
        }      

        void dis_en(bool e)
        {
            txtMaNV.Enabled = e;
            txtTenNV.Enabled = e;
            cbbChucVu.Enabled = e;
            txtMatKhau.Enabled = e;
            txtDiaChi.Enabled = e;
            txtGhiChu.Enabled = e;
            txtSDT.Enabled = e;
            btnLuu.Enabled = e;
            btnHuy.Enabled = e;
            btnThem.Enabled = !e;
            btnSua.Enabled = !e;
            btnXoa.Enabled = !e;
        }

        void GanDuLieu(NhanVien nv)
        {
            nv.Ma = txtMaNV.Text.Trim();
            nv.Ten = txtTenNV.Text.Trim();
            nv.ChucVu = cbbChucVu.Text.Trim();
            nv.MatKhau = txtMatKhau .Text.Trim();
            nv.DiaChi = txtDiaChi.Text.Trim();
            nv.SDT = int.Parse(txtSDT.Text.Trim());
            nv.GhiChu = txtGhiChu.Text.Trim();
        }

        private void LoadcmbChucVu()
        {
            NhanVienControl nvctr = new NhanVienControl();
            cbbChucVu.DataSource = nvctr.GetData();
            cbbChucVu.DisplayMember = "ChucVu";
            cbbChucVu.ValueMember = "ChucVu";
            cbbChucVu.SelectedIndex = 0;
        }

        void cleardata()
        {
            txtMaNV.Text = "";
            txtTenNV.Text = "";
            cbbChucVu.Text = "";
            txtMatKhau.Text = "";
            txtDiaChi.Text = "";
            txtSDT.Text = "";
            txtGhiChu.Text = "";
            LoadcmbChucVu();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            cleardata();
            flag = 0;
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
                if (nvCtrl.XoaNhanVien(txtMaNV.Text.Trim()))
                    MessageBox.Show("Xóa thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                else
                    MessageBox.Show("Xóa thất bại", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
                return;
            frmNhanVien_Load(sender, e);
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            GanDuLieu(nv);
            if (flag == 0)
            {
                if (nvCtrl.ThemNhanVien(nv))
                    MessageBox.Show("Thêm thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                else
                    MessageBox.Show("Thêm thất bại", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (nvCtrl.SuaNhanVien(nv))
                    MessageBox.Show("Sửa thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                else
                    MessageBox.Show("Sửa thất bại", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            frmNhanVien_Load(sender, e);
            dis_en(false);
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            frmNhanVien_Load(sender, e);
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {    
           DialogResult h = MessageBox.Show
                ("Bạn chắc chắn muốn thoát?", "Error", MessageBoxButtons.OKCancel);
            if(h== DialogResult.OK)
            {
                frmNhanVien fnv = new frmNhanVien();
                this.Close();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            dgvNhanVien.DataSource = nvCtrl.GetDataTim(txtTim.Text);
            

        }

        




    }
}
