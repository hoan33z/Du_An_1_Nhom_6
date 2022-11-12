using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.DAL.Models
{
    public class KhachHang
    {
        public Guid IdKhachHang { get; set; }
        public string TenKh { get; set; }
        public string DiaChi { get; set; }
        public string SDT { get; set; }
        public string Email { get; set; }
        public virtual TaiKhoan? TaiKhoan { get; set; }
    }
}
