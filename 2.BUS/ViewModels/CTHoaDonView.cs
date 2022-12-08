﻿using _1.DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.BUS.ViewModels
{
    public class CTHoaDonView
    {
        public Guid IdCTHoaDon { get; set; }
        public Guid IdHoaDon { get; set; }
        public Guid IdChiTietSP { get; set; }
        public string TenSp { get; set; }
        public decimal DonGia { get; set; }
        public decimal SoLuongMua { get; set; }
    }
}
