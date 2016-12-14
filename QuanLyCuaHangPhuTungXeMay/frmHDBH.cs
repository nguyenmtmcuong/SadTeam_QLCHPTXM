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
    public partial class frmHDBH : Form
    {
        HDBHControl hdbhctr = new HDBHControl();
        public frmHDBH()
        {
            InitializeComponent();
        }

        private void frmHDBH_Load(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            dt = hdbhctr.GetData();
            dgvDanhSachHoaDon.DataSource=dt;
            bingding();
        }

        private void bingding()
        {
            txtMaHD.DataBindings.Clear();
            txtMaHD.DataBindings.Add("Text",dgvDanhSachHoaDon.DataSource,"MaHD");
            cbbBienSo.DataBindings.Clear();
            cbbBienSo.DataBindings.Add("Text",dgvDanhSachHoaDon.DataSource,"BienSo");
            cbbMaKH.DataBindings.Clear();
            cbbMaKH.DataBindings.Add("Text",dgvDanhSachHoaDon.DataSource,"MaKH");
            cbbMaNV.DataBindings.Clear();
            cbbMaNV.DataBindings.Add("Text",dgvDanhSachHoaDon.DataSource,"MaNV");
            txtNgay.DataBindings.Clear();
            txtNgay.DataBindings.Add("Text",dgvDanhSachHoaDon.DataSource,"NgayLap");
            txtKhuyenMai.DataBindings.Clear();
            txtKhuyenMai.DataBindings.Add("Text",dgvDanhSachHoaDon.DataSource,"KhuyenMai");
            txtThanhTien.DataBindings.Clear();
            txtThanhTien.DataBindings.Add("Text",dgvDanhSachHoaDon.DataSource,"ThanhTien");
            cbbMaPhuTung.DataBindings.Clear();
            cbbMaPhuTung.DataBindings.Add("Text",dgvDanhSachHoaDon.DataSource,"MaPT");
            cbbTenPhuTung.DataBindings.Clear();
            cbbTenPhuTung.DataBindings.Add("Text",dgvDanhSachHoaDon.DataSource,"TenPhuTung");
            txtSoLuong.DataBindings.Clear();
            txtSoLuong.DataBindings.Add("Text",dgvDanhSachHoaDon.DataSource,"SoLuong");
            txtDonGia.DataBindings.Clear();
            txtDonGia.DataBindings.Add("Text",dgvDanhSachHoaDon.DataSource,"DonGia");
        }

        private void dis_en(bool e)
        {
            txtMaHD.Enabled = e;
            cbbMaNV.Enabled = e;
            cbbMaKH.Enabled = e;
            cbbBienSo.Enabled = e;
            btnTao.Enabled = !e;
            btnXoa.Enabled = !e;
            btnIn.Enabled = !e;
            btnLuu.Enabled = e;
            btnHuy.Enabled = e;
            btnNgayLap.Enabled = e;
        }

        private void LoadcbbMaKH()
        {
            KhachHangControl khctr = new KhachHangControl();
            cbbMaKH.DataSource = hdbhctr.GetData();
            cbbMaKH.DisplayMember = "MaKH";
            cbbMaKH.ValueMember = "MaKH";
        }

        private void cleardata()
        {
            txtMaHD.Text = "";
            txtNgay.Text = "";
            txtKhuyenMai.Text = "";
            txtThanhTien.Text = "";
            txtNgay.Text = DateTime.Now.Date.ToShortDateString();
            LoadcbbMaKH();
        }

        //private void adddata(HDBH hd)
        //{
        //    hd.MaHD = txtMaHD.Text.Trim();
        //    hd.MaKH = cbbMaKH.SelectedValue.ToString();
        //    hd.MaNV = cbbMaNV.SelectedValue.ToString();
        //    hd.KhuyenMai = txtKhuyenMai.Text.Trim();
        //    hd.MaPT = cbbMaPhuTung.SelectedValue.ToString();
        //    hd.Ngay=


        //}
        private void btnTao_Click(object sender, EventArgs e)
        {
            dis_en(true);
            cleardata();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {

        }

        private void btnIn_Click(object sender, EventArgs e)
        {

        }

        private void btnLuu_Click(object sender, EventArgs e)
        {

        }

        private void btnHuy_Click(object sender, EventArgs e)
        {

        }

        private void btnThem_Click(object sender, EventArgs e)
        {

        }

        private void btnBot_Click(object sender, EventArgs e)
        {

        }

        private void dgvDanhSachPhuTung_DataSourceChanged(object sender, EventArgs e)
        {
            bingding();
        }


    }
}
