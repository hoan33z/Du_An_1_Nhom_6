using _1.DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.DAL.IRepositories
{
    public interface IChiTietSanPhamRepository
    {
        public bool Add(ChiTietSanPham obj);
        public bool Update(ChiTietSanPham obj);
        public bool Delete(ChiTietSanPham obj);
        public List<ChiTietSanPham> GetAll();
    }
}
