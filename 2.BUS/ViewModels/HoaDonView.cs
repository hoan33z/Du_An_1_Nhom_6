using _1.DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.BUS.ViewModels
{
    public class HoaDonView
    {
        public Guid IdHoaDon { get; set; }
        public string TenKhachHang { get; set; }
        public string TenNhanVien { get; set; }
        public decimal TongTien { get; set; }
        public DateTime NgayThanhToan { get; set; }
        public int TrangThai { get; set; }
        public DateTime NgayTao { get; set; }
    }
}
