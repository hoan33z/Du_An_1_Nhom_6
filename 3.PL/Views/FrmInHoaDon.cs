using _1.DAL.Models;
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
        ICTSanPhamService _cTSanPhamService;
        Guid _idnv;
        Guid _idhd;
        public FrmInHoaDon(Guid idnv)
        {
            InitializeComponent();
            _khachHangService = new KhachHangService();
            _cTHoaDonService = new CTHoaDonService();
            _hoaDonService = new HoaDonService();
            _cTSanPhamService = new CTSanPhamService();
            _idnv = idnv;
            _idhd = _hoaDonService.GetEdit(_idnv).IdHoaDon;
            LoadCTHD();
            LoadGioHang();
        }
        public void LoadCTHD()
        {
            var kh = _khachHangService.GetEdit(_hoaDonService.GetEdit(_idnv).IdKhachHang);
            var hd = _hoaDonService.GetAll().FirstOrDefault(c => c.IdHoaDon == _idhd);
            lblDiaChi.Text = kh.DiaChi;
            lblSDT.Text = kh.SDT;
            lblTenKH.Text = kh.TenKh;
            lblNVTT.Text = hd.TenNhanVien;
            lblNgayTao.Text = hd.NgayTao.ToString("dd/MM/yyyy");
            lblNgayTT.Text = hd.NgayThanhToan.ToString("dd/MM/yyyy");
        }

        public void LoadGioHang()
        {
            List<CTHoaDonView> lstcthd = (from a in _cTHoaDonService.GetAll()
                                          where a.IdHoaDon == _idhd
                                          select new CTHoaDonView()
                                          {
                                              IdChiTietSP = a.IdChiTietSP,
                                              TenSp = a.TenSp,
                                              DonGia = a.DonGia,
                                              SoLuongMua = a.SoLuongMua
                                          }).ToList();
            this.tableLayoutPanel1.RowCount = lstcthd.Count + 1;
            for (int i = 0; i < lstcthd.Count; i++)
            {
                var od = lstcthd[i];
                Label lbFood = new Label { Text = _cTSanPhamService.GetAll().FirstOrDefault(c => c.IdChiTietSP == od.IdChiTietSP).TenSp };
                Label lbQuantity = new Label { Text = od.SoLuongMua.ToString() };
                Label lbPrice = new Label { Text = string.Format("{0:0}", _cTSanPhamService.GetAll().FirstOrDefault(c => c.IdChiTietSP == od.IdChiTietSP).GiaBan) + "đ" };
                this.tableLayoutPanel1.RowStyles.Add(new RowStyle());
                this.tableLayoutPanel1.Controls.Add(lbFood, 0, i + 1);
                this.tableLayoutPanel1.Controls.Add(lbQuantity, 1, i + 1);
                this.tableLayoutPanel1.Controls.Add(lbPrice, 2, i + 1);
            }

            decimal tong = 0;
            foreach (var x in lstcthd)
            {
                tong += x.SoLuongMua * x.DonGia;
                lblTongTien.Text = tong.ToString()+ "VNĐ";
            }
            var TT = Utility.NumberToText(tong);
            lblThanhChu.MaximumSize = new Size(266, 0);
            lblThanhChu.Text = TT;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            this.pageSetupDialog1.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.printPreviewDialog1.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.printDialog1.ShowDialog();
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            float x = e.MarginBounds.Left;
            float y = e.MarginBounds.Top;
            Bitmap bmp = new Bitmap(this.panelPrint.Width, this.panelPrint.Height);
            this.panelPrint.DrawToBitmap(bmp, new Rectangle(0, 0, this.panelPrint.Width, this.panelPrint.Height));
            Rectangle recSource = new Rectangle(0, 0, (int)this.panelPrint.Width, (int)this.panelPrint.Height);
            Rectangle recDest = new Rectangle((int)x, (int)y, (int)this.panelPrint.Width * 2, (int)this.panelPrint.Height * 2);
            e.Graphics.DrawImage((Image)bmp, recDest, recSource, GraphicsUnit.Pixel);
        }
    }
}
