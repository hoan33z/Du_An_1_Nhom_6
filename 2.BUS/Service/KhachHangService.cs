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
    public class KhachHangService : IKhachHangService
    {
        IKhachHangRepository _IkhachHangRepository;
        public KhachHangService()
        {
            _IkhachHangRepository = new KhachHangRepository();
        }
        public void Add(KhachHang obj)
        {
            if (obj == null) return;
            _IkhachHangRepository.Add(obj);
        }

        public void Delete(KhachHang obj)
        {
            if (obj == null) return;
            var tempobj = _IkhachHangRepository.GetAll().FirstOrDefault(c => c.IdKhachHang == obj.IdKhachHang);
            _IkhachHangRepository.Delete(tempobj);
        }

        public List<KhachHang> GetAll()
        {
           return _IkhachHangRepository.GetAll();
        }

        public void Update(KhachHang obj)
        {
            if (obj == null) return;
            var tempobj = _IkhachHangRepository.GetAll().FirstOrDefault(c => c.IdKhachHang == obj.IdKhachHang);
            _IkhachHangRepository.Update(tempobj);
        }
    }
}
