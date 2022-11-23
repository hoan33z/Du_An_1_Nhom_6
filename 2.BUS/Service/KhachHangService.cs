using _1.DAL.IRepositories;
using _1.DAL.Models;
using _1.DAL.Repositories;
using _2.BUS.IServices;
using _2.BUS.ViewModels;
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
        public string Add(EditKhachHangView obj)
        {
            if (obj == null) return " thêm không thành công";
            var tempobj = obj.KhachHangs;
           if(_IkhachHangRepository.Add(tempobj)) return"thêm thành công";
            return "ok";
        }

        public string Delete(EditKhachHangView obj)
        {
            if (obj == null) return " xóa không thành công";
            var tempobj = _IkhachHangRepository.GetAll().FirstOrDefault(c => c.IdKhachHang == obj.KhachHangs.IdKhachHang);
            if (_IkhachHangRepository.Delete(tempobj)) return "xóa thành công";
            return "ok";
        }

        public List<KhachHangView> GetAll()
        {
           List<KhachHangView> lstKhView = new List<KhachHangView>();
            lstKhView = (from a in _IkhachHangRepository.GetAll() select new KhachHangView() { KhachHangs= a }).ToList();
            return lstKhView;
        }

        public string Update(EditKhachHangView obj)
        {
            if (obj == null) return " sửa không thành công";
            var tempobj = _IkhachHangRepository.GetAll().FirstOrDefault(c => c.IdKhachHang == obj.KhachHangs.IdKhachHang);
            if (_IkhachHangRepository.Update(tempobj)) return "sửa thành công";
            return "ok";
        }
    }
}

