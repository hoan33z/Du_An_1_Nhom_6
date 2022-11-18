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
            if (obj == null) return "Thêm Khong Thanh Cong";
            if (_sanPhamRepository.Add(obj)) return "Them thanh cong";
            return "ok";
        }

        public string Delete(SanPham obj)
        {
            if (obj == null) return "Xóa Khong Thanh Cong";
            if (_sanPhamRepository.Delete(obj)) return "Xóa thanh cong";
            return "ok";
        }

        public List<SanPham> GetAll()
        {
            return _sanPhamRepository.GetAll().ToList();
        }

        public string Update(SanPham obj)
        {
            if (obj == null) return "Sửa không thàmh công";
            if (_sanPhamRepository.Update(obj)) return "Sửa thành công";
            return "ok";
        }
    }
}
