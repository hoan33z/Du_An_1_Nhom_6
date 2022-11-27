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
    public class CTHoaDonService : ICTHoaDonService
    {
        ICTHoaDonRepository _cTHoaDonRepository;
        ICTSanPhamRepository _cTSanPhamRepository;
        IHoaDonRepository _hoaDonRepository;
        ISanPhamService _sanPhamService;
        public CTHoaDonService()
        {
            _cTHoaDonRepository = new CTHoaDonRepository();
            _cTSanPhamRepository = new CTSanPhamRepository();
            _hoaDonRepository = new HoaDonRepository();
            _sanPhamService = new SanPhamService();
        }
        public string Add(EditCTHoaDonView CTHD)
        {
            if (CTHD == null) return "Thêm không thành công";
            ChiTietHoaDon obj = new ChiTietHoaDon()
            {
                IdChiTietSP = CTHD.IdChiTietSP,
                IdHoaDon = CTHD.IdHoaDon,
                SoLuongMua = CTHD.SoLuongMua,
                DonGia = CTHD.DonGia,
            };
            if (_cTHoaDonRepository.Add(obj)) return "Thêm thành công";
            return "Thêm không thành công";
        }

        public string Delete(EditCTHoaDonView CTHD)
        {
            if (CTHD == null) return "xoa không thành công";
            ChiTietHoaDon obj = new ChiTietHoaDon()
            {
                IdChiTietSP = CTHD.IdChiTietSP,
            };
            if (_cTHoaDonRepository.Delete(obj)) return "xoa thành công";
            return "xoa không thành công";
        }

        public List<CTHoaDonView> GetAll()
        {
            List<CTHoaDonView> lstCTHoaDon = new List<CTHoaDonView>();
            lstCTHoaDon = (from a in _cTHoaDonRepository.GetAll()
                           join b in _hoaDonRepository.GetAll() on a.IdHoaDon equals b.IdHoaDon
                           join c in _cTSanPhamRepository.GetAll() on a.IdChiTietSP equals c.IdChiTietSP
                           join d in _sanPhamService.GetAll() on c.IdSp equals d.IdSp
                           select new CTHoaDonView()
                           {
                               IdHoaDon = b.IdHoaDon,
                               TenSp = d.TenSp,
                               DonGia = c.GiaBan,
                               SoLuongMua = a.SoLuongMua,
                               IdCTSP=c.IdChiTietSP
                           }).ToList();
            return lstCTHoaDon;
        }
        public EditCTHoaDonView GetEdit(Guid id)
        {
            var editCTHD = _cTHoaDonRepository.GetAll().FirstOrDefault(c => c.IdChiTietSP == id);
            return new EditCTHoaDonView()
            {
                IdChiTietSP = editCTHD.IdChiTietSP,
                IdHoaDon = editCTHD.IdHoaDon,
                SoLuongMua = editCTHD.SoLuongMua,
                DonGia = editCTHD.DonGia,
            };

        }

        public string Update(EditCTHoaDonView CTHD)
        {
            if (CTHD == null) return "Thêm không thành công";
            ChiTietHoaDon obj = new ChiTietHoaDon()
            {
                IdChiTietSP = CTHD.IdChiTietSP,
                IdHoaDon = CTHD.IdHoaDon,
                SoLuongMua = CTHD.SoLuongMua,
                DonGia = CTHD.DonGia,
            };
            if (_cTHoaDonRepository.Update(obj)) return "Thêm thành công";
            return "Thêm không thành công";
        }
    }
}
