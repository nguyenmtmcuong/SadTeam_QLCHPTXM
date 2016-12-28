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
            cbbLoai.DataBindings.Clear();
            cbbLoai.DataBindings.Add("Text", dgvLoaiXe.DataSource, "Loai");
            cbbHangXe.DataBindings.Clear();
            cbbHangXe.DataBindings.Add("Text", dgvLoaiXe.DataSource, "HangXe");
            cbbPhanKhoi.DataBindings.Clear();
            cbbPhanKhoi.DataBindings.Add("Text", dgvLoaiXe.DataSource, "PhanKhoi");
            txtNamSanXuat.DataBindings.Clear();
            txtNamSanXuat.DataBindings.Add("Text", dgvLoaiXe.DataSource, "NamSanXuat");
            cbbNguonNhap.DataBindings.Clear();
            cbbNguonNhap.DataBindings.Add("Text", dgvLoaiXe.DataSource, "NguonNhap");
        }

        void dis_en(bool e)
        {
            txtMaLX.Enabled = e;
            txtTenThuongGoi.Enabled = e;
            cbbLoai.Enabled = e;
            cbbHangXe.Enabled = e;
            cbbPhanKhoi.Enabled = e;
            txtNamSanXuat.Enabled = e;
            cbbNguonNhap.Enabled = e;
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
            lx.Loai = cbbLoai.SelectedValue.ToString();
            lx.Hang = cbbHangXe.SelectedValue.ToString();
            lx.PhanKhoi = int.Parse(cbbPhanKhoi.SelectedValue.ToString());
            lx.NamSX = int.Parse(txtNamSanXuat.Text.Trim());
            lx.NguonNhap = cbbNguonNhap.SelectedValue.ToString();
        }

        private void LoadcmbNguonNhap()
        {
            LoaiXeControl lxctr = new LoaiXeControl();
            cbbNguonNhap.DataSource = lxctr.GetData();
            cbbNguonNhap.DisplayMember = "NguonNhap";
            cbbNguonNhap.ValueMember = "NguonNhap";
            cbbNguonNhap.SelectedIndex = 0;
        }

        private void LoadcmbPhanKhoi()
        {
            LoaiXeControl lxctr = new LoaiXeControl();
            cbbPhanKhoi.DataSource = lxctr.GetData();
            cbbPhanKhoi.DisplayMember = "PhanKhoi";
            cbbPhanKhoi.ValueMember = "PhanKhoi";
            cbbPhanKhoi.SelectedIndex = 0;
        }

        private void LoadcmbHang()
        {
            LoaiXeControl lxctr = new LoaiXeControl();
            cbbHangXe.DataSource = lxctr.GetData();
            cbbHangXe.DisplayMember = "HangXe";
            cbbHangXe.ValueMember = "HangXe";
            cbbHangXe.SelectedIndex = 0;
        }

        private void LoadcmbLoai()
        {
            LoaiXeControl lxctr = new LoaiXeControl();
            cbbLoai.DataSource = lxctr.GetData();
            cbbLoai.DisplayMember = "Loai";
            cbbLoai.ValueMember = "Loai";
            cbbLoai.SelectedIndex = 0;
        }

        void cleardata()
        {
            txtMaLX.Text = "";
            txtTenThuongGoi.Text = "";
            cbbLoai.Text = "";
            cbbHangXe.Text = "";
            cbbPhanKhoi.Text = "";
            txtNamSanXuat.Text = "";
            cbbNguonNhap.Text = "";
            LoadcmbHang();
            LoadcmbLoai();
            LoadcmbPhanKhoi();
            LoadcmbNguonNhap();
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

        private void btnTim_Click(object sender, EventArgs e)
        {
            dgvLoaiXe.DataSource = lxCtrl.GetDataTim(txtTim.Text);
        }
    }
}
