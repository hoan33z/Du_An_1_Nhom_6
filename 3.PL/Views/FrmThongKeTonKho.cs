using _2.BUS.IServices;
using _2.BUS.Service;
using _2.BUS.ViewModels;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _3.PL.Views
{
    public partial class FrmThongKeTonKho : Form
    {
        ICTSanPhamService _IcTSanPhamService;
        public FrmThongKeTonKho()
        {
            InitializeComponent();
            _IcTSanPhamService = new CTSanPhamService();
            dgrid_TonKho.Enabled = false;
            LoadData();
            LoadLoc();
        }
        public void LoadLoc()
        {
            cbx_danhMuc.Items.Add("Lọc Theo Danh Mục");
            cbx_loaiSp.Items.Add("Lọc Theo Loại Sản Phẩm");
            foreach (var x in _IcTSanPhamService.GetAll())
            {
                cbx_danhMuc.Items.Add(x.TenDanhMuc);
                cbx_loaiSp.Items.Add(x.TenLoaiSp);
            }
            cbx_danhMuc.SelectedIndex = 0;
            cbx_loaiSp.SelectedIndex = 0;
        }
        private void LoadData()
        {
            dgrid_TonKho.Columns[0].Name = "IdSp";
            dgrid_TonKho.Columns[0].Visible = false;
            dgrid_TonKho.Columns[1].Name = "Tên Sản Phẩm";
            dgrid_TonKho.Columns[2].Name = "Danh Mục";
            dgrid_TonKho.Columns[3].Name = "Thể Loại";
            dgrid_TonKho.Columns[4].Name = "Nhà Cung Cấp";
            dgrid_TonKho.Columns[5].Name = "Đơn vị";
            dgrid_TonKho.Columns[6].Name = "Số lượng hàng tồn ";
            dgrid_TonKho.Rows.Clear();
            foreach (var x in _IcTSanPhamService.GetAll())
            {
                dgrid_TonKho.Rows.Add(x.IdChiTietSP, x.TenSp, x.TenDanhMuc, x.TenLoaiSp, x.TenNhaCungCap, x.TenDonVi, x.SoLuong);
            }
        }

        private void txt_timKiem_TextChanged(object sender, EventArgs e)
        {
            dgrid_TonKho.Rows.Clear();
            foreach (var x in _IcTSanPhamService.GetAll().Where(c => c.TenSp.Contains(txt_timKiem.Text)))
            {
                dgrid_TonKho.Rows.Add(x.IdChiTietSP, x.TenSp, x.TenDanhMuc, x.TenLoaiSp, x.TenNhaCungCap, x.TenDonVi, x.SoLuong);
            }
        }

        private void cbx_danhMuc_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbx_danhMuc.Text == "Lọc Theo Danh Mục")
            {
                LoadData();
            }
            else if (cbx_danhMuc.Text != "Lọc Theo Danh Mục" && cbx_loaiSp.Text != "Lọc Theo Loại Sản Phẩm")
            {
                dgrid_TonKho.Rows.Clear();
                List<CTSanPhamView> lstctsp = (from a in _IcTSanPhamService.GetAll()
                                               where a.TenDanhMuc == cbx_danhMuc.Text && a.TenLoaiSp == cbx_loaiSp.Text
                                               select new CTSanPhamView()
                                               {
                                                   IdChiTietSP = a.IdChiTietSP,
                                                   TenSp = a.TenSp,
                                                   TenLoaiSp = a.TenLoaiSp,
                                                   GiaBan = a.GiaBan,
                                                   SoLuong = a.SoLuong,
                                                   GiaNhap = a.GiaNhap,
                                                   TenNhaCungCap = a.TenNhaCungCap,
                                                   TenDanhMuc = a.TenDanhMuc,
                                                   TenDonVi = a.TenDonVi
                                               }).ToList();
                foreach (var x in lstctsp)
                {
                    dgrid_TonKho.Rows.Add(
                             x.IdChiTietSP, x.TenSp, x.TenDanhMuc, x.TenLoaiSp, x.TenNhaCungCap, x.TenDonVi, x.SoLuong
                        );
                }
            }
            else
            {
                dgrid_TonKho.Rows.Clear();
                foreach (var x in _IcTSanPhamService.GetAll().Where(c => c.TenDanhMuc == cbx_danhMuc.Text))
                {
                    dgrid_TonKho.Rows.Add(
                        x.IdChiTietSP, x.TenSp, x.TenDanhMuc, x.TenLoaiSp, x.TenNhaCungCap, x.TenDonVi, x.SoLuong
                        );
                }
            }
        }

        private void cbx_loaiSp_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbx_loaiSp.Text == "Lọc Theo Loại Sản Phẩm")
            {
                LoadData();
            }
            else if (cbx_danhMuc.Text != "Lọc Theo Danh Mục" && cbx_loaiSp.Text != "Lọc Theo Loại Sản Phẩm")
            {
                dgrid_TonKho.Rows.Clear();
                List<CTSanPhamView> lstctsp = (from a in _IcTSanPhamService.GetAll()
                                               where a.TenDanhMuc == cbx_danhMuc.Text && a.TenLoaiSp == cbx_danhMuc.Text
                                               select new CTSanPhamView()
                                               {
                                                   IdChiTietSP = a.IdChiTietSP,
                                                   TenSp = a.TenSp,
                                                   TenLoaiSp = a.TenLoaiSp,
                                                   GiaBan = a.GiaBan,
                                                   SoLuong = a.SoLuong,
                                                   GiaNhap = a.GiaNhap,
                                                   TenNhaCungCap = a.TenNhaCungCap,
                                                   TenDanhMuc = a.TenDanhMuc,
                                                   TenDonVi = a.TenDonVi
                                               }).ToList();
                foreach (var x in lstctsp)
                {
                    dgrid_TonKho.Rows.Add(
                       x.IdChiTietSP, x.TenSp, x.TenDanhMuc, x.TenLoaiSp, x.TenNhaCungCap, x.TenDonVi, x.SoLuong
                        );
                }
            }
            else
            {
                dgrid_TonKho.Rows.Clear();
                foreach (var x in _IcTSanPhamService.GetAll().Where(c => c.TenLoaiSp == cbx_danhMuc.Text))
                {
                    dgrid_TonKho.Rows.Add(
                        x.IdChiTietSP, x.TenSp, x.TenDanhMuc, x.TenLoaiSp, x.TenNhaCungCap, x.TenDonVi, x.SoLuong
                        );
                }
            }
        }
    }
}
