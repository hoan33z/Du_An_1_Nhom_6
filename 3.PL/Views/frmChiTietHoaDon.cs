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
    public partial class frmChiTietHoaDon : Form
    {
        ICTHoaDonService _cTHoaDonService;
        public frmChiTietHoaDon()
        {
            InitializeComponent();
            _cTHoaDonService = new CTHoaDonService();
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
                    x.IdHoaDon,
                    x.TenSp,
                    x.DonGia,
                    x.SoLuongMua,
                    x.ThanhTien
                    );
            }
        }
    }
}
