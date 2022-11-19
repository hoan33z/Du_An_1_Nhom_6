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
    public class NhanVienService : INhanVienService
    {
        INhanVienRepository _nhanVienRepository;
        public NhanVienService()
        {
            _nhanVienRepository = new NhanVienRepository();
        }
        public string Add(NhanVien obj)
        {
            if (obj == null) return "Thêm Khong Thanh Cong";
            if (_nhanVienRepository.Add(obj)) return "Them thanh cong";
            return "ok";
        }

        public string Delete(NhanVien obj)
        {
            if (obj == null) return "Xóa Khong Thanh Cong";
            if (_nhanVienRepository.Delete(obj)) return "Xóa thanh cong";
            return "ok";
        }

        public List<NhanVien> GetAll()
        {
            return _nhanVienRepository.GetAll().ToList();
        }

        public string Update(NhanVien obj)
        {

            if (obj == null) return "Sửa Khong Thanh Cong";
            if (_nhanVienRepository.Update(obj)) return "Sửa thanh cong";
            return "ok";
        }
    }
}
