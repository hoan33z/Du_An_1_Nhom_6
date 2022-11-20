using _2.BUS.IServices;
using _2.BUS.Service;
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
        ICTSanPhamService  _IcTSanPhamService;
        public FrmDatHang()
        {
            InitializeComponent();
            _IcTSanPhamService = new CTSanPhamService();
            LoadSanPham();
        }
        public void LoadSanPham()
        {
            dgridTTSanPham.ColumnCount = 10;
            dgridTTSanPham.Columns[0].Name = "ID";
            dgridTTSanPham.Columns[0].Visible = false;
            dgridTTSanPham.Columns[1].Name = "Tên Sản Phẩm";
            dgridTTSanPham.Columns[2].Name = "Loại Sản Phẩm";
            dgridTTSanPham.Columns[3].Name = "Nhà Cung Cấp";
            dgridTTSanPham.Columns[4].Name = "Danh Mục";
            dgridTTSanPham.Columns[5].Name = "Đơn Vị";
            dgridTTSanPham.Columns[6].Name = "Giá Nhập";
            dgridTTSanPham.Columns[7].Name = "Giá Bán";
            dgridTTSanPham.Columns[8].Name = "Số Lượng";
            dgridTTSanPham.Columns[9].Name = "Hình Ảnh";
            dgridTTSanPham.Rows.Clear();
            foreach (var x in _IcTSanPhamService.GetAll())
            {
                dgridTTSanPham.Rows.Add(x.ChiTietSanPhams.IdChiTietSP, x.SanPhams.TenSp, x.LoaiSps.TenLoaiSp, x.NhaCungCaps.TenNhaCungCap, x.DanhMucs.TenDanhMuc, x.DonVis.TenDonVi, x.ChiTietSanPhams.GiaNhap, x.ChiTietSanPhams.GiaBan, x.ChiTietSanPhams.SoLuong,x.ChiTietSanPhams.HinhAnh);
            }
        }
    }
}
