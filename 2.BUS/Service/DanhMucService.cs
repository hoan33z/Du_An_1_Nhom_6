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
    public class DanhMucService : IDanhMucService
    {
        IDanhMucRepository _danhMucRepository;
        public DanhMucService()
        {
            _danhMucRepository = new DanhMucRepository();
        }
        public string Add(DanhMuc obj)
        {
            if (obj == null) return "Xoa Khong Thanh Cong";
            if (_danhMucRepository.Add(obj)) return "Them thanh cong";
            return "ok";
        }

        public string Delete(DanhMuc obj)
        {
            if (_danhMucRepository.Delete(obj)) return "Xoa thanh cong";
            return "ok";
        }

        public List<DanhMuc> GetAll()
        {
            return _danhMucRepository.GetAll().ToList();
        }

        public string Update(DanhMuc obj)
        {
            if (_danhMucRepository.Update(obj)) return "sua thanh cong";
            return "ok";
        }
    }
}
