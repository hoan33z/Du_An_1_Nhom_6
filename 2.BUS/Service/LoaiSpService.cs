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
    public class LoaiSpService:ILoaiSpService
    {
        ILoaiSpRepository _IloaiSpRepository;
        public LoaiSpService()
        {
            _IloaiSpRepository = new LoaiSpRepository();
        }
        public string Add(LoaiSp obj)
        {
            if (obj == null) return "Thêm Khong Thanh Cong";
            if (_IloaiSpRepository.Add(obj)) return "Them thanh cong";
            return "ok";
        }

        public string Delete(LoaiSp obj)
        {
            if (obj == null) return "Xóa Khong Thanh Cong";
            if (_IloaiSpRepository.Delete(obj)) return "Xóa thanh cong";
            return "ok";
        }

        public List<LoaiSp> GetAll()
        {
            return _IloaiSpRepository.GetAll().ToList();
        }

        public string Update(LoaiSp obj)
        {
            if (obj == null) return "Sửa Khong Thanh Cong";
            if (_IloaiSpRepository.Update(obj)) return "Sửa thanh cong";
            return "ok";
        }
    }
}
