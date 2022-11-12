using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.DAL.Models
{
    public class ChiTietGioHang
    {
        public Guid IdChiTietSp { get; set; }
        public Guid IdGioHang { get; set; }

        public decimal DonGia { get; set; }
        public int SoLuongMua { get; set; }

        public virtual ChiTietSanPham? ChiTietSanPham { get; set; }
        public virtual GioHang? GioHang { get; set; }
    }
}
