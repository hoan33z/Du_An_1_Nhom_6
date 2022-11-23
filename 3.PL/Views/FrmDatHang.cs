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
    public partial class FrmDatHang : Form
    {
        ICTSanPhamService _cTSanPhamService;
        public FrmDatHang()
        {
            InitializeComponent();
            _cTSanPhamService = new CTSanPhamService();
            LoadDSSanPham();
        }
        public void LoadDSSanPham()
        {
            dgridDSSanPham.ColumnCount = 9;
            dgridDSSanPham.Columns[0].Name = "ID";
            dgridDSSanPham.Columns[0].Visible = false;
            dgridDSSanPham.Columns[1].Name = "Tên Sản Phẩm";
            dgridDSSanPham.Columns[2].Name = "Loại Sản Phẩm";
            dgridDSSanPham.Columns[3].Name = "Giá Bán";
            dgridDSSanPham.Columns[4].Name = "Số Lượng";
            dgridDSSanPham.Columns[5].Name = "Giá Nhập";
            dgridDSSanPham.Columns[6].Name = "Nhà Cung Cấp";
            dgridDSSanPham.Columns[7].Name = "Danh Mục";
            dgridDSSanPham.Columns[8].Name = "Đơn Vị";
            dgridDSSanPham.Rows.Clear();
            foreach (var x in _cTSanPhamService.GetAll())
            {
                dgridDSSanPham.Rows.Add(
                    x.ChiTietSanPhams.IdChiTietSP,
                    x.SanPhams.TenSp,
                    x.LoaiSps.TenLoaiSp,
                    x.ChiTietSanPhams.GiaBan,
                    x.ChiTietSanPhams.SoLuong,
                    x.ChiTietSanPhams.GiaNhap,
                    x.NhaCungCaps.TenNhaCungCap,
                    x.DanhMucs.TenDanhMuc,
                    x.DonVis.TenDonVi
                    );
            }
        }
    }
}
