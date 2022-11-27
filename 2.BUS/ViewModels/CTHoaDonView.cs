using _1.DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.BUS.ViewModels
{
    public class CTHoaDonView
    {
        public Guid IdHoaDon { get; set; }
        public Guid IdCTHoaDon { get; set; }
        public Guid IdCTSP { get; set; }
        public string TenSp { get; set; }
        public decimal DonGia { get; set; }
        public int SoLuongMua { get; set; }
    }
}
