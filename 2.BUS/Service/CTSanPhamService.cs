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
        IChiTietSanPhamRepository _IchiTietSanPhamRepository;
        ISanPhamRepository _IsanPhamRepository;
        ILoaiSpRepository _IloaiSpRepository;
        INhaCungCapRepository _InhaCungCapRepository;
        IDonViRepository _IdonViRepository;
        IDanhMucRepository _IdanhMucRepository;
        public CTSanPhamService()
        {
            _IchiTietSanPhamRepository = new ChiTietSanPhamRepository();
            _IsanPhamRepository = new SanPhamRepository();
            _IloaiSpRepository= new LoaiSpRepository();
            _InhaCungCapRepository = new NhaCungCapRepository();
            _IdonViRepository = new DonViRepository();
            _IdanhMucRepository = new DanhMucRepository();
        }
        public string Add(CTSanPhamView obj)
        {
            if (obj == null) return "them khong thanh cong";
            var ctSanPham = obj.ChiTietSanPhams;
            if (_IchiTietSanPhamRepository.Add(ctSanPham)) return "Them thanh cong";
            return "ok";
        }


        public string Delete(CTSanPhamView obj)
        {
            if (obj == null) return "xoa khong thanh cong";
            var ctSanPham = obj.ChiTietSanPhams;
            if (_IchiTietSanPhamRepository.Delete(ctSanPham)) return "xoa thanh cong";
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
                     ChiTietSanPhams = a,
                     SanPhams = b,
                     LoaiSps =c,
                     NhaCungCaps = d,
                     DanhMucs = e,
                     DonVis = f
                 }
                 ).ToList();
            return LstcTSanPham;
        }

        public string Update(CTSanPhamView obj)
        {
            if (obj == null) return "sua khong thanh cong";
            var ctSanPham = obj.ChiTietSanPhams;
            if (_IchiTietSanPhamRepository.Update(ctSanPham)) return "sua thanh cong";
            return "ok";
        }
    }
}
