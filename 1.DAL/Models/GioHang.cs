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
        public DateTime NgayThanhToan { get; set; }
        public DateTime NgayMuaHang { get; set; }
        public int TrangThai { get; set; }
        public virtual KhachHang? KhachHang { get; set; }
    }
}
