using _1.DAL.Models;
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
    public partial class FrmThongKeDoanhThu : Form
    {
        ICTHoaDonService _ICtHoaDon;
        ISanPhamService _ISanPhamService;
        IHoaDonService _IHoaDonService;
        private VatLieuDbContext _db;
        public FrmThongKeDoanhThu()
        {
            InitializeComponent();
            _ICtHoaDon = new CTHoaDonService();
            dgrid_doanhThu.Enabled = false;
            _ISanPhamService = new SanPhamService();
            _IHoaDonService = new HoaDonService();
            _db = new VatLieuDbContext();
            LoadCBB();
            LoadData();
            LoadAll();
        }
        private void LoadCBB()
        {
            comboBox1.Items.Add("Tất cả");
            foreach (var x in _ISanPhamService.GetAll())
            {
                comboBox1.Items.Add(x.TenSp);
            }
        }
        public void LoadAll()
        {
            dgrid_doanhThu.ColumnCount = 4;
            dgrid_doanhThu.Columns[0].Name = "Tên Sản Phẩm";
            dgrid_doanhThu.Columns[1].Name = "Giá Bán";
            dgrid_doanhThu.Columns[2].Name = "Số Lượng Đã bán";
            dgrid_doanhThu.Columns[3].Name = "Tổng Thu";
            dgrid_doanhThu.Rows.Clear();
            int tong = 0;
            foreach (var x in _ICtHoaDon.GetAll())
            {
                for (int i = 0; i <= _ICtHoaDon.GetAll().Count-1; i++)
                {
                    tong += x.SoLuongMua;
                }
                dgrid_doanhThu.Rows.Add(x.TenSp, x.DonGia,tong,x.DonGia*x.SoLuongMua);
                return;
            }
        }
        private void LoadData()
        {
            try
            {
                var data =
                (from hd in _db.HoaDons.Where(c => c.NgayThanhToan.Date >= dt_tuNgay.Value.Date && c.NgayThanhToan <= dt_denNgay.Value.Date && c.TrangThai == true)
                 join ct in _db.ChiTietHoaDons on hd.IdHoaDon equals ct.IdHoaDon
                 join ctsp in _db.ChiTietSanPhams on ct.IdChiTietSP equals ctsp.IdChiTietSP
                 join sp in _db.SanPhams on ctsp.IdSp equals sp.IdSp
                 select new
                 {
                     tenSp = sp.TenSp,
                     DonGia = ct.DonGia,
                     SoLuong = ct.SoLuongMua,
                     Tong = ct.DonGia * ct.SoLuongMua
                 }).ToList();

                dgrid_doanhThu.ColumnCount = 4;
                dgrid_doanhThu.Columns[0].Name = "Tên Sản Phẩm";
                dgrid_doanhThu.Columns[1].Name = "Giá Bán";
                dgrid_doanhThu.Columns[2].Name = "Số Lượng Đã bán";
                dgrid_doanhThu.Columns[3].Name = "Tổng Thu";
                dgrid_doanhThu.Rows.Clear();
                foreach (var x in data)
                {
                    dgrid_doanhThu.Rows.Add(x.tenSp, x.DonGia, x.SoLuong, x.Tong);
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        private void btn_thongKe_Click(object sender, EventArgs e)
        {
            try
            {
                if (comboBox1.Text == "Tất cả")
                {
                    LoadData();
                }
                else
                {
                    try
                    {
                        var data =
                        (from hd in _db.HoaDons.Where(c => c.NgayThanhToan.Date >= dt_tuNgay.Value.Date && c.NgayThanhToan <= dt_denNgay.Value.Date)
                         join ct in _db.ChiTietHoaDons on hd.IdHoaDon equals ct.IdHoaDon
                         join ctsp in _db.ChiTietSanPhams on ct.IdChiTietSP equals ctsp.IdChiTietSP
                         join sp in _db.SanPhams on ctsp.IdSp equals sp.IdSp
                         select new
                         {
                             tenSp = sp.TenSp,
                             DonGia = ct.DonGia,
                             SoLuong = ct.SoLuongMua,
                             Tong = ct.DonGia * ct.SoLuongMua
                         }).ToList();

                        dgrid_doanhThu.DataSource = data;
                    }
                    catch (Exception)
                    {
                        throw;
                    }
                }
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void dt_tuNgay_ValueChanged(object sender, EventArgs e)
        {
            if (dt_tuNgay.Value > dt_denNgay.Value)
            {
                MessageBox.Show("Ngày không hợp lệ!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                dt_tuNgay.Select();
                return;
            }
        }

        private void dt_tuNgay_Leave(object sender, EventArgs e)
        {
            if (dt_tuNgay.Value > dt_denNgay.Value)
            {
                MessageBox.Show("Ngày không hợp lệ!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                dt_tuNgay.Select();
                return;
            }
        }

        private void dt_denNgay_ValueChanged(object sender, EventArgs e)
        {
            if (dt_tuNgay.Value > dt_denNgay.Value)
            {
                MessageBox.Show("Ngày không hợp lệ!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                dt_tuNgay.Select();
                return;
            }
        }

        private void dt_denNgay_Leave(object sender, EventArgs e)
        {
            if (dt_tuNgay.Value > dt_denNgay.Value)
            {
                MessageBox.Show("Ngày không hợp lệ!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                dt_tuNgay.Select();
                return;
            }
        }

        private void FrmThongKeDoanhThu_Load(object sender, EventArgs e)
        {
            dt_tuNgay.Value = new DateTime(DateTime.Now.Year, DateTime.Now.Month, 1);
            dt_denNgay.Value = DateTime.Now;
        }
    }
}
