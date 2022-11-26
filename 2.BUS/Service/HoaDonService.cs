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
    public class HoaDonService : IHoaDonService
    {
        IHoaDonRepository _hoaDonRepository;
        IKhachHangRepository _khachHangRepository;
        INhanVienRepository _nhanVienRepository;
        public HoaDonService()
        {
            _hoaDonRepository = new HoaDonRepository();
            _khachHangRepository = new KhachHangRepository();
            _nhanVienRepository = new NhanVienRepository();
        }
        public string Add(EditHoaDonView HD)
        {
            if (HD == null) return "Thêm không thành công";
            HoaDon obj = new HoaDon()
            {
                IdKhachHang = HD.IdKhachHang,
                IdNhanVien = HD.IdNhanVien,
                TongTien = HD.TongTien,
                NgayThanhToan = HD.NgayThanhToan
            };
            if (_hoaDonRepository.Add(obj)) return "Thêm thành công";
            return "Thêm không thành công";
        }

        public string Delete(EditHoaDonView HD)
        {
            if (HD == null) return "xoa không thành công";
            HoaDon obj = new HoaDon()
            {
                IdHoaDon = HD.IdHoaDon
            };
            if (_hoaDonRepository.Add(obj)) return "xoa thành công";
            return "xoa không thành công";
        }

        public List<HoaDonView> GetAll()
        {
            List<HoaDonView> lstHoanDon = new List<HoaDonView>();
            lstHoanDon = (
                from a in _hoaDonRepository.GetAll()
                join b in _khachHangRepository.GetAll() on a.IdKhachHang equals b.IdKhachHang
                join c in _nhanVienRepository.GetAll() on a.IdNhanVien equals c.IdNhanVien
                select new HoaDonView()
                {
                    TenKhachHang = b.TenKh,
                    TenNhanVien = c.TenNv,
                    IdHoaDon = a.IdHoaDon,
                    TongTien = a.TongTien,
                    NgayThanhToan = a.NgayThanhToan,
                    TrangThai = a.TrangThai
                }
                ).ToList();
            return lstHoanDon;
        }

        public EditHoaDonView GetEdit(Guid id)
        {
            var HD = _hoaDonRepository.GetAll().FindLast(c => c.IdNhanVien == id);
            return new EditHoaDonView()
            {
                IdHoaDon = HD.IdHoaDon,
                IdNhanVien = HD.IdNhanVien,
                IdKhachHang = HD.IdKhachHang,
                NgayThanhToan = HD.NgayThanhToan,
                TongTien = HD.TongTien,
            };
        }

        public string Update(EditHoaDonView HD)
        {
            if (HD == null) return "sua không thành công";
            HoaDon obj = new HoaDon()
            {
                IdHoaDon = HD.IdHoaDon,
                IdKhachHang = HD.IdKhachHang,
                IdNhanVien = HD.IdNhanVien,
                TongTien = HD.TongTien,
                NgayThanhToan = HD.NgayThanhToan
            };
            if (_hoaDonRepository.Add(obj)) return "sua thành công";
            return "sua không thành công";
        }
    }
}
