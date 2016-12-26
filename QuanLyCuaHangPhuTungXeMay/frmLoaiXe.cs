using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyCuaHangPhuTungXeMay
{
    public partial class frmLoaiXe : Form
    {
        LoaiXeControl lxCtrl = new LoaiXeControl();
        LoaiXe lx = new LoaiXe();
        int flag = 0;

        public frmLoaiXe()
        {
            InitializeComponent();
        }

        private void frmLoaiXe_Load(object sender, EventArgs e)
        {
            DataTable dtlx = new DataTable();
            dtlx = lxCtrl.GetData();
            dgvLoaiXe.DataSource = dtlx;
            bingding();
            dis_en(false);
        }

        void bingding()
        {
            txtMaLX.DataBindings.Clear();
            txtMaLX.DataBindings.Add("Text", dgvLoaiXe.DataSource, "MaLX");
            txtTenThuongGoi.DataBindings.Clear();
            txtTenThuongGoi.DataBindings.Add("Text", dgvLoaiXe.DataSource, "TenThuongGoi");
            txtLoai.DataBindings.Clear();
            txtLoai.DataBindings.Add("Text", dgvLoaiXe.DataSource, "Loai");
            txtHangXe.DataBindings.Clear();
            txtHangXe.DataBindings.Add("Text", dgvLoaiXe.DataSource, "HangXe");
            txtPhanKhoi.DataBindings.Clear();
            txtPhanKhoi.DataBindings.Add("Text", dgvLoaiXe.DataSource, "PhanKhoi");
            txtNamSanXuat.DataBindings.Clear();
            txtNamSanXuat.DataBindings.Add("Text", dgvLoaiXe.DataSource, "NamSanXuat");
            txtNguonNhap.DataBindings.Clear();
            txtNguonNhap.DataBindings.Add("Text", dgvLoaiXe.DataSource, "NguonNhap");
        }

        void dis_en(bool e)
        {
            txtMaLX.Enabled = e;
            txtTenThuongGoi.Enabled = e;
            txtLoai.Enabled = e;
            txtHangXe.Enabled = e;
            txtPhanKhoi.Enabled = e;
            txtNamSanXuat.Enabled = e;
            txtNguonNhap.Enabled = e;
            btnLuu.Enabled = e;
            btnHuy.Enabled = e;
            btnThem.Enabled = !e;
            //btnHuy.Enabled = !e;
            btnXoa.Enabled = !e;
        }

        void GanDuLieu(LoaiXe lx)
        {
            lx.Ma = txtMaLX.Text.Trim();
            lx.Ten = txtTenThuongGoi.Text.Trim();
            lx.Loai = txtLoai.Text.Trim();
            lx.Hang = txtHangXe.Text.Trim();
            lx.PhanKhoi = int.Parse(txtPhanKhoi.Text.Trim());
            lx.NamSX = int.Parse(txtNamSanXuat.Text.Trim());
            lx.NguonNhap = txtNguonNhap.Text.Trim();
        }

        void cleardata()
        {
            txtMaLX.Text = "";
            txtTenThuongGoi.Text = "";
            txtLoai.Text = "";
            txtHangXe.Text = "";
            txtPhanKhoi.Text = "";
            txtNamSanXuat.Text = "";
            txtNguonNhap.Text = "";
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            flag = 0;
            cleardata();
            dis_en(true);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            flag = 1;
            dis_en(true);
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Bạn chắc chắn muốn xóa?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                if (lxCtrl.XoaLoaiXe(txtMaLX.Text.Trim()))
                    MessageBox.Show("Xóa thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                else
                    MessageBox.Show("Xóa thất bại", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
                return;
            frmLoaiXe_Load(sender, e);
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            GanDuLieu(lx);
            if (flag == 0)
            {
                if (lxCtrl.ThemLoaiXe(lx))
                    MessageBox.Show("Thêm thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                else
                    MessageBox.Show("Thêm thất bại", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (lxCtrl.SuaLoaiXe(lx))
                    MessageBox.Show("Sửa thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                else
                    MessageBox.Show("Sửa thất bại", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            frmLoaiXe_Load(sender, e);
            dis_en(false);
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            frmLoaiXe_Load(sender, e);
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            DialogResult h = MessageBox.Show
    ("Bạn chắc chắn muốn thoát?", "Error", MessageBoxButtons.OKCancel);
            if (h == DialogResult.OK)
            {
                frmLoaiXe fnv = new frmLoaiXe();
                this.Close();
            }
        }








    }
}
