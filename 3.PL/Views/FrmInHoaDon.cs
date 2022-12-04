using _2.BUS.IServices;
using _2.BUS.Service;
using _2.BUS.ViewModels;
using _2_BUS_Layer.Utility;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace _3.PL.Views
{
    public partial class FrmInHoaDon : Form
    {
        IKhachHangService _khachHangService;
        ICTHoaDonService _cTHoaDonService;
        IHoaDonService _hoaDonService;
        Guid _idkh;
        Guid _idhd;
        public FrmInHoaDon(Guid idkh)
        {
            InitializeComponent();
            _khachHangService = new KhachHangService();
            _cTHoaDonService= new CTHoaDonService();
            _hoaDonService = new HoaDonService();
            _idkh = idkh;
            _idhd = _hoaDonService.GetEdit(_idkh).IdHoaDon;
            LoadCTHD();
            LoadGioHang();
        }
        public void LoadCTHD()
        {
            var kh = _khachHangService.GetEdit(_idkh);
            var hd = _hoaDonService.GetAll().FirstOrDefault(c=>c.IdHoaDon==_idhd);
            lblDiaChi.Text = kh.DiaChi;
            lblSDT.Text = kh.SDT;
            lblTenKH.Text = kh.TenKh;
            lblNVTT.Text = hd.TenNhanVien;
            lblNgayTao.Text=hd.NgayTao.ToString("dd/MM/yyyy");
            lblNgayTT.Text = hd.NgayThanhToan.ToString("dd/MM/yyyy");
        }
        
        public void LoadGioHang()
        {
            List<CTHoaDonView> lstcthd = (from a in _cTHoaDonService.GetAll()
                                          where a.IdHoaDon == _idhd
                                          select new CTHoaDonView()
                                          {
                                              TenSp = a.TenSp,
                                              DonGia = a.DonGia,
                                              SoLuongMua = a.SoLuongMua
                                          }).ToList();
            dgridGioHang.ColumnCount = 4;
            dgridGioHang.Columns[0].Name = "Tên Sản Phẩm";
            dgridGioHang.Columns[1].Name = "Giá Bán";
            dgridGioHang.Columns[2].Name = "Số Lượng";
            dgridGioHang.Columns[3].Name = "Thành Tiền";
            dgridGioHang.Rows.Clear();
            decimal tong = 0;
            foreach (var x in lstcthd)
            {
                tong += x.SoLuongMua * x.DonGia;
                dgridGioHang.Rows.Add(x.TenSp, x.DonGia, x.SoLuongMua, x.SoLuongMua * x.DonGia);  
                lblTongTien.Text = tong.ToString();
            }
            var TT = Utility.NumberToText(tong);
            lblThanhChu.MaximumSize = new Size(470, 0);
            lblThanhChu.Text = TT;
        }
    }
}
