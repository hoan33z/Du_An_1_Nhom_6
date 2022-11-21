using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.DAL.Models
{
    public class HoaDon
    {
        public Guid IdHoaDon { get; set; }
        public Guid IdKhachHang { get; set; }
        public Guid IdNhanVien { get; set; }

        public decimal TongTien { get; set; }
        public DateTime NgayThanhToan { get; set; }
        public virtual KhachHang? KhachHang { get; set; }
        public virtual NhanVien?  NhanVien { get; set; }
    }
}
