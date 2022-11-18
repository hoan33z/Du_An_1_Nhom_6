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
        ILoaiTKRepository _IloaiTKRepository;
        public LoaiTKService()
        {
            _IloaiTKRepository = new LoaiTkRepository();
        }
        public string Add(LoaiTK obj)
        {
            if (obj == null) return "Thêm Khong Thanh Cong";
            if (_IloaiTKRepository.Add(obj)) return "Them thanh cong";
            return "ok";
        }

        public string Delete(LoaiTK obj)
        {

            if (obj == null) return "Xóa Khong Thanh Cong";
            if (_IloaiTKRepository.Delete(obj)) return "Xóa thanh cong";
            return "ok";
        }

        public List<LoaiTK> GetAll()
        {
            return _IloaiTKRepository.GetAll().ToList();
        }

        public string Update(LoaiTK obj)
        {
            if (obj == null) return "Sửa Khong Thanh Cong";
            if (_IloaiTKRepository.Update(obj)) return "Sửa thanh cong";
            return "ok";
        }
    }
}
