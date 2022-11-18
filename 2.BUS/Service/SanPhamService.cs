using _1.DAL.IRepositories;
using _1.DAL.Models;
using _1.DAL.Repositories;
using _2.BUS.IServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.BUS.Service
{
    public class SanPhamService : ISanPhamService
    {
        ISanPhamRepository _sanPhamRepository;

        public SanPhamService()
        {
            _sanPhamRepository = new SanPhamRepository();
        }
        public string Add(SanPham obj)
        {
            if (_sanPhamRepository.Add(obj)) return "Them thanh cong";
            return "ok";
        }

        public string Delete(SanPham obj)
        {
            throw new NotImplementedException();
        }

        public List<SanPham> GetAll()
        {
            throw new NotImplementedException();
        }

        public string Update(SanPham obj)
        {
            throw new NotImplementedException();
        }
    }
}
