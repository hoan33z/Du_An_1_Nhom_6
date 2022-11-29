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
    public partial class FrmThongKeTonKho : Form
    {
        ICTSanPhamService _IcTSanPhamService;
        public FrmThongKeTonKho()
        {
            InitializeComponent();
            _IcTSanPhamService = new CTSanPhamService();
            dgrid_TonKho.Enabled = false;
            LoadData();
        }
        private void LoadData()
        {
            dgrid_TonKho.ColumnCount = 5;
            dgrid_TonKho.Columns[0].Name = "Tên Sản Phẩm";
            dgrid_TonKho.Columns[1].Name = "Danh Mục";
            dgrid_TonKho.Columns[2].Name = "Thể Loại";
            dgrid_TonKho.Columns[3].Name = "Nhà Cung Cấp";
            dgrid_TonKho.Columns[4].Name = "Số lượng hàng tồn ";
            dgrid_TonKho.Rows.Clear();
            foreach (var x in _IcTSanPhamService.GetAll())
            {
                dgrid_TonKho.Rows.Add(x.TenSp, x.TenDanhMuc, x.TenLoaiSp, x.TenNhaCungCap, x.SoLuong);
            }
        }

    }
}
