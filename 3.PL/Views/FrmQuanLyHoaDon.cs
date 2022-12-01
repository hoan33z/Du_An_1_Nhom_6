using _1.DAL.Models;
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
    public partial class FrmQuanLyHoaDon : Form
    {
        private VatLieuDbContext _db;

        public FrmQuanLyHoaDon()
        {
            InitializeComponent();
            loadData();
            _db = new VatLieuDbContext();
        }
        public void loadData()
        {
            try
            {
                var data =
                (from hd in _db.HoaDons
                 join ct in _db.ChiTietHoaDons on hd.IdHoaDon equals ct.IdHoaDon
                 join kh in _db.KhachHangs on hd.IdKhachHang equals kh.IdKhachHang
                 join nv in _db.NhanViens on hd.IdNhanVien equals nv.IdNhanVien
                 select new
                 {
                     tenKh = kh.TenKh,
                     nhanVien = nv.TenNv,
                     ngayThanhToan = hd.NgayThanhToan,
                     ngayTao = hd.NgayTao,
                     tongTien = hd.TongTien,
                 }).ToList();

                dgrid_hoaDon.DataSource = data;
            }
            catch (Exception)
            {
                throw;
            }
        }
        public void loadDataTimKiem()
        {

        }

        private void FrmQuanLyHoaDon_Load(object sender, EventArgs e)
        {

        }
    }
}
