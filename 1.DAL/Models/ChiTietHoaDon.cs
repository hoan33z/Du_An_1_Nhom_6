using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.DAL.Models
{
    public class ChiTietHoaDon
    {
        public Guid IdCTHoaDon { get; set; }
        public Guid IdHoaDon { get; set; }
        public Guid IdChiTietSP { get; set; }


        public decimal DonGia { get; set; }
        public int SoLuongMua { get; set; }
        public virtual ChiTietSanPham? ChiTietSanPham { get; set; }
        public virtual HoaDon? HoaDon { get; set; }
    }
}
