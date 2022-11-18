﻿using _1.DAL.IRepositories;
using _1.DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.DAL.Repositories
{
    public class TaiKhoanRepository : ITaiKhoan
    {
        VatLieuDbContext _vatLieuDbContext;
        public TaiKhoanRepository()
        {
            _vatLieuDbContext = new VatLieuDbContext();
        }
        public bool Add(TaiKhoan obj)
        {
            if (obj == null) return false;
            _vatLieuDbContext.TaiKhoans.Add(obj);
            _vatLieuDbContext.SaveChanges();
            return true;
        }

        public bool Delete(TaiKhoan obj)
        {
            if (obj == null) return false;
            var tempobj = _vatLieuDbContext.TaiKhoans.FirstOrDefault(c => c.IdLoaiTk == obj.IdLoaiTk);
            _vatLieuDbContext.TaiKhoans.Remove(tempobj);
            _vatLieuDbContext.SaveChanges();
            return true;
        }

        public List<TaiKhoan> GetAll()
        {
            return _vatLieuDbContext.TaiKhoans.ToList();
        }

        public bool Update(TaiKhoan obj)
        {
            if (obj == null) return false;
            var tempobj = _vatLieuDbContext.TaiKhoans.FirstOrDefault(c => c.IdLoaiTk == obj.IdLoaiTk);
            tempobj.TenTaiKhoan = obj.TenTaiKhoan;
            _vatLieuDbContext.TaiKhoans.Update(tempobj);
            _vatLieuDbContext.SaveChanges();
            return true;
        }
    }
}
