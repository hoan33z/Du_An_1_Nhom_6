using _1.DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.BUS.ViewModels
{
    public class EditCTHoaDonView
    {
        public Guid IdHoaDon { get; set; }
        public Guid IdChiTietSP { get; set; }
        public decimal DonGia { get; set; }
        public int SoLuongMua { get; set; }
        public decimal ThanhTien { get; set; }

    }
}
