using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.DAL.Models
{
    public class NhanVien
    {
        public Guid IdNhanVien { get; set; }
        public string TenNv { get; set; }
        public DateTime NamSinh { get; set; }
        public int GioiTinh { get; set; }
        public string Email { get; set; }
        public string DiaChi { get; set; }
        public string SDT { get; set; }
        public virtual TaiKhoan? TaiKhoan { get; set; }
    }
}
