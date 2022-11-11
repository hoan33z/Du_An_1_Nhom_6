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
        public Guid IdChiTietSP { get; set; }

        public decimal DonGia { get; set; }
        public int SoLuongMua { get; set; }
    }
}
