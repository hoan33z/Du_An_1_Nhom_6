using _1.DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.DAL.IRepositories
{
    public interface IChiTietGioHangRepository
    {
        public bool Add(ChiTietGioHang obj);
        public bool Update(ChiTietGioHang obj);
        public bool Delete(ChiTietGioHang obj);
        public List<ChiTietGioHang> GetAll();
    }
}
