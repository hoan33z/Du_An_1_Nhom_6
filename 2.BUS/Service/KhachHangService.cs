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
        public string Add(EditKhachHangView KH)
        {
            if (KH == null) return " thêm không thành công";
            KhachHang obj = new KhachHang()
            {
                TenKh = KH.TenKh,
                DiaChi = KH.DiaChi,
                SDT = KH.SDT,
                GioiTinh = KH.GioiTinh,
                DCNhanHang = KH.DCNhanHang,
                NgayNhan = KH.NgayNhan
            };
            if (_IkhachHangRepository.Add(obj)) return "thêm thành công";
            return "ok";
        }

        public string Delete(EditKhachHangView KH)
        {
            if (KH == null) return " xóa không thành công";
            KhachHang obj = new KhachHang()
            {
                IdKhachHang = KH.IdKhachHang,
            };
            if (_IkhachHangRepository.Delete(obj)) return "xóa thành công";
            return "ok";
        }

        public List<KhachHangView> GetAll()
        {
            List<KhachHangView> lstKhView = new List<KhachHangView>();
            lstKhView = (from a in _IkhachHangRepository.GetAll() select new KhachHangView() { IdKhachHang = a.IdKhachHang, TenKh = a.TenKh, DiaChi = a.DiaChi, SDT = a.SDT, GioiTinh = a.GioiTinh, DCNhanHang = a.DCNhanHang, NgayNhan = a.NgayNhan }).ToList();
            return lstKhView;
        }

        public EditKhachHangView GetEdit(Guid id)
        {
            var kh = _IkhachHangRepository.GetAll().FirstOrDefault(c => c.IdKhachHang == id);
            return new EditKhachHangView()
            {
                DCNhanHang = kh.DCNhanHang,
                DiaChi = kh.DiaChi,
                GioiTinh = kh.GioiTinh,
                IdKhachHang = kh.IdKhachHang,
                NgayNhan = kh.NgayNhan,
                SDT = kh.SDT,
                TenKh = kh.TenKh
            };
        }

        public string Update(EditKhachHangView KH)
        {
            if (KH == null) return " sửa không thành công";
            KhachHang obj = new KhachHang()
            {
                IdKhachHang = KH.IdKhachHang,
                TenKh = KH.TenKh,
                DiaChi = KH.DiaChi,
                SDT = KH.SDT,
                GioiTinh = KH.GioiTinh,
                DCNhanHang = KH.DCNhanHang,
                NgayNhan = KH.NgayNhan
            };
            if (_IkhachHangRepository.Update(obj)) return "sửa thành công";
            return "ok";
        }
    }
}

