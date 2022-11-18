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
    public class LoaiTKService : ILoaiTKService
    {
        ILoaiTKRepository _loaiTKRepository;
        public LoaiTKService()
        {
            _loaiTKRepository = new LoaiTkRepository();
        }
        public string Add(LoaiTK obj)
        {
            if (obj == null) return "Thêm Khong Thanh Cong";
            if (_loaiTKRepository.Add(obj)) return "Them thanh cong";
            return "ok";
        }

        public string Delete(LoaiTK obj)
        {

            if (obj == null) return "Xóa Khong Thanh Cong";
            if (_loaiTKRepository.Delete(obj)) return "Xóa thanh cong";
            return "ok";
        }

        public List<LoaiTK> GetAll()
        {
            return _loaiTKRepository.GetAll().ToList();
        }

        public string Update(LoaiTK obj)
        {
            if (obj == null) return "Sửa Khong Thanh Cong";
            if (_loaiTKRepository.Update(obj)) return "Sửa thanh cong";
            return "ok";
        }
    }
}
