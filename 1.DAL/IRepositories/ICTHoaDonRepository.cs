using _1.DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.DAL.IRepositories
{
    public interface ICTHoaDonRepository
    {
        public bool Add(ChiTietHoaDon obj);
        public bool Update(ChiTietHoaDon obj);
        public bool Delete(ChiTietHoaDon obj);
        public List<ChiTietHoaDon> GetAll();
    }
}
