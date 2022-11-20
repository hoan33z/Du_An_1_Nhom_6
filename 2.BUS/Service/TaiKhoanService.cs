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
    public class TaiKhoanService : ITaiKhoanService
    {
        ITaiKhoanRepository _taiKhoanRepository;
        public TaiKhoanService()
        {
            _taiKhoanRepository = new TaiKhoanRepository();
        }
        public string Add(TaiKhoan obj)
        {
            if (obj == null) return "Thêm Khong Thanh Cong";
            if (_taiKhoanRepository.Add(obj)) return "Them thanh cong";
            return "ok";
        }

        public string Delete(TaiKhoan obj)
        {
            if (obj == null) return "Xóa Khong Thanh Cong";
            if (_taiKhoanRepository.Delete(obj)) return "Xóa thanh cong";
            return "ok";
        }

        public List<TaiKhoan> GetAll()
        {
            return _taiKhoanRepository.GetAll().ToList();
        }

        public string Update(TaiKhoan obj)
        {
            if (obj == null) return "Sửa Khong Thanh Cong";
            if (_taiKhoanRepository.Update(obj)) return "Sửa thanh cong";
            return "ok";
        }
    }
}
