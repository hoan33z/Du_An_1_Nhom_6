using _1.DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.BUS.IServices
{
    public interface ISanPhamService
    {
        public string Add(SanPham obj);
        public string Update(SanPham obj);
        public string Delete(SanPham obj);
        public List<SanPham> GetAll();
    }
}
