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
    public partial class frmChiTietHoaDon : Form
    {
        ICTHoaDonService _cTHoaDonService;
        IHoaDonService _hoaDonService;
        ICTSanPhamService _cTSanPhamService;
        public frmChiTietHoaDon()
        {
            InitializeComponent();
            _cTHoaDonService = new CTHoaDonService();
            _cTSanPhamService =new  CTSanPhamService();
            _hoaDonService = new HoaDonService();
            loadcacloai();
            LoadGioHang();
        }
        public void LoadGioHang()
        {
            dgridGioHang.ColumnCount = 5;
            dgridGioHang.Columns[0].Name = "ID";
            dgridGioHang.Columns[1].Name = "Tên Sản Phẩm";
            dgridGioHang.Columns[2].Name = "Giá Bán";
            dgridGioHang.Columns[3].Name = "Số Lượng";
            dgridGioHang.Columns[4].Name = "Thành Tiền";
            dgridGioHang.Rows.Clear();
            foreach (var x in _cTHoaDonService.GetAll())
            {
                dgridGioHang.Rows.Add(
                    x.IdCTHoaDon,
                    x.TenSp,
                    x.DonGia,
                    x.SoLuongMua,
                    x.SoLuongMua*x.DonGia
                    );
            }
        }
        public void loadcacloai()
        {
            foreach (var x in _hoaDonService.GetAll())
            {
                cmbhd.Items.Add(x.IdHoaDon);
            }
            foreach (var x in _cTSanPhamService.GetAll())
            {
                cmbctsp.Items.Add(x.IdChiTietSP);
            }
        }
        public EditCTHoaDonView Getdata()
        {
            var idhd = _cTHoaDonService.GetAll().FirstOrDefault(c => c.IdCTHoaDon == Guid.Parse(cmbhd.Text));
            var idctsp = _cTSanPhamService.GetAll().FirstOrDefault(c => c.IdChiTietSP == Guid.Parse(cmbctsp.Text));
            return new EditCTHoaDonView() { IdHoaDon = idhd.IdCTHoaDon  , IdChiTietSP =idctsp.IdChiTietSP, DonGia =decimal.Parse( gia.Text), SoLuongMua =int.Parse( sl.Text) };
        }
        private void button1_Click(object sender, EventArgs e)
        {
            _cTHoaDonService.Add(Getdata());
        }
    }
}
