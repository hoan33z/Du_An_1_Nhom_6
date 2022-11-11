using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.DAL.Models
{
    public class GioHang
    {
        public Guid IdGioHang { get; set; }
        public Guid IdKhachHang { get; set; }
        public string DiaChi { get; set; }
        public string SDT { get; set; }
        public DateTime NgayThanhToan { get; set; }
        public int TrangThai { get; set; }
    }
}
