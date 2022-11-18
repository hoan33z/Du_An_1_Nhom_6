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
    public class DonViService : IDonViService
    {
        IDonViRepository _donViRepository;
        public DonViService()
        {
            _donViRepository = new DonViRepository();
        }
        public string Add(DonVi obj)
        {
            if (obj == null) return "Thêm Khong Thanh Cong";
            if (_donViRepository.Add(obj)) return "Them thanh cong";
            return "ok";
        }

        public string Delete(DonVi obj)
        {
            if (obj == null) return "Xóa Khong Thanh Cong";
            if (_donViRepository.Delete(obj)) return "Xóa thanh cong";
            return "ok";
        }

        public List<DonVi> GetAll()
        {
            return _donViRepository.GetAll().ToList();
        }

        public string Update(DonVi obj)
        {
            if (obj == null) return "Sửa Khong Thanh Cong";
            if (_donViRepository.Update(obj)) return "Sửa thanh cong";
            return "ok";
        }
    }
}
