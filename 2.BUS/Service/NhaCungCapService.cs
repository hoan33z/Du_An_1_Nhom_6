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
    public class NhaCungCapService : INhaCungCapService
    {
        INhaCungCapRepository _nhaCungCapRepository;
        public NhaCungCapService()
        {
            _nhaCungCapRepository = new NhaCungCapRepository();
        }
        public string Add(NhaCungCap obj)
        {
            if (obj == null) return "Thêm Khong Thanh Cong";
            if (_nhaCungCapRepository.Add(obj)) return "Them thanh cong";
            return "ok";
        }

        public string Delete(NhaCungCap obj)
        {
            if (obj == null) return "Xóa Khong Thanh Cong";
            if (_nhaCungCapRepository.Delete(obj)) return "Xóa thanh cong";
            return "ok";
        }

        public List<NhaCungCap> GetAll()
        {
            return _nhaCungCapRepository.GetAll().ToList();
        }

        public string Update(NhaCungCap obj)
        {
            if (obj == null) return "Sửa Khong Thanh Cong";
            if (_nhaCungCapRepository.Update(obj)) return "Sửa thanh cong";
            return "ok";
        }
    }
}
