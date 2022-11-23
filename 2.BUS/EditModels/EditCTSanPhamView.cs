using _1.DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.BUS.ViewModels
{
    public class EditCTSanPhamView
    {
        public SanPham SanPhams { get; set; }
        public LoaiSp LoaiSps { get; set; }
        public NhaCungCap NhaCungCaps { get; set; }
        public DonVi DonVis { get; set; }
        public DanhMuc DanhMucs { get; set; }
        public ChiTietSanPham ChiTietSanPhams { get; set; }
    }
}
