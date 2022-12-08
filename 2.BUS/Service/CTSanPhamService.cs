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
    public class CTSanPhamService : ICTSanPhamService
    {
        ICTSanPhamRepository _IchiTietSanPhamRepository;
        ISanPhamRepository _IsanPhamRepository;
        ILoaiSpRepository _IloaiSpRepository;
        INhaCungCapRepository _InhaCungCapRepository;
        IDonViRepository _IdonViRepository;
        IDanhMucRepository _IdanhMucRepository;
        public CTSanPhamService()
        {
            _IchiTietSanPhamRepository = new CTSanPhamRepository();
            _IsanPhamRepository = new SanPhamRepository();
            _IloaiSpRepository= new LoaiSpRepository();
            _InhaCungCapRepository = new NhaCungCapRepository();
            _IdonViRepository = new DonViRepository();
            _IdanhMucRepository = new DanhMucRepository();
        }
        public string Add(EditCTSanPhamView SP)
        {
            if (SP == null) return "them khong thanh cong";
            ChiTietSanPham obj = new ChiTietSanPham()
            {
                IdSp = SP.IdSp,
                IdDanhMuc = SP.IdDanhMuc,
                IdDonVi = SP.IdDonVi,
                IdNhaCungCap = SP.IdNhaCungCap,
                IdLoaiSp = SP.IdLoaiSp,
                HinhAnh = SP.HinhAnh,
                GiaBan = SP.GiaBan,
                GiaNhap = SP.GiaNhap,
                SoLuong = SP.SoLuong,
            };
            if (_IchiTietSanPhamRepository.Add(obj)) return "Them thanh cong";
            return "ok";
        }
        public string Delete(EditCTSanPhamView SP)
        {
            if (SP == null) return "xoa khong thanh cong";
            ChiTietSanPham obj = new ChiTietSanPham()
            {
                IdChiTietSP=SP.IdChiTietSP
            };
            if (_IchiTietSanPhamRepository.Delete(obj)) return "xoa thanh cong";
            return "ok";
        }

        public List<CTSanPhamView> GetAll()
        {
            List<CTSanPhamView> LstcTSanPham = new List<CTSanPhamView>();
            LstcTSanPham = 
                (from a in _IchiTietSanPhamRepository.GetAll()
                 join b in _IsanPhamRepository.GetAll() on a.IdSp equals b.IdSp
                 join c in _IloaiSpRepository.GetAll() on a.IdLoaiSp equals c.IdLoaiSp
                 join d in _InhaCungCapRepository.GetAll() on a.IdNhaCungCap equals d.IdNhaCungCap
                 join e in _IdanhMucRepository.GetAll() on a.IdDanhMuc equals e.IdDanhMuc
                 join f in _IdonViRepository.GetAll() on a.IdDonVi equals f.IdDonVi
                 select new CTSanPhamView()
                 {
                     IdChiTietSP= a.IdChiTietSP,
                     TenDanhMuc=e.TenDanhMuc,
                     TenDonVi=f.TenDonVi,
                     TenLoaiSp=c.TenLoaiSp,
                     TenNhaCungCap=d.TenNhaCungCap,
                     TenSp=b.TenSp,
                     HinhAnh=a.HinhAnh,
                     GiaBan=a.GiaBan,
                     GiaNhap=a.GiaNhap,
                     SoLuong=a.SoLuong
                 }
                 ).ToList();
            return LstcTSanPham;
        }

        public EditCTSanPhamView GetEdit(Guid id)
        {
            if (id!=Guid.Empty)
            {
                var SP = _IchiTietSanPhamRepository.GetAll().FirstOrDefault(c => c.IdChiTietSP == id);
                return new EditCTSanPhamView()
                {
                    IdChiTietSP = SP.IdChiTietSP,
                    IdSp = SP.IdSp,
                    IdDanhMuc = SP.IdDanhMuc,
                    IdDonVi = SP.IdDonVi,
                    IdLoaiSp = SP.IdLoaiSp,
                    IdNhaCungCap = SP.IdNhaCungCap,
                    HinhAnh = SP.HinhAnh,
                    GiaBan = SP.GiaBan,
                    GiaNhap = SP.GiaNhap,
                    SoLuong = SP.SoLuong
                };
            }
            return null;
        }

        public string Update(EditCTSanPhamView SP)
        {
            if (SP == null) return "sua khong thanh cong";
            ChiTietSanPham obj = new ChiTietSanPham()
            {
                IdChiTietSP= SP.IdChiTietSP,
                IdSp = SP.IdSp,
                IdDanhMuc = SP.IdDanhMuc,
                IdDonVi = SP.IdDonVi,
                IdNhaCungCap = SP.IdNhaCungCap,
                IdLoaiSp = SP.IdLoaiSp,
                HinhAnh = SP.HinhAnh,
                GiaBan = SP.GiaBan,
                GiaNhap = SP.GiaNhap,
                SoLuong = SP.SoLuong,
            };
            if (_IchiTietSanPhamRepository.Update(obj)) return "sua thanh cong";
            return "ok";
        }
    }
}
