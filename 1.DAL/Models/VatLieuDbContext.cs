﻿using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace _1.DAL.Models
{
    public class VatLieuDbContext : DbContext
    {
        public VatLieuDbContext()
        {
        }

        public VatLieuDbContext(DbContextOptions<VatLieuDbContext> options) : base(options)
        {
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder.
                UseSqlServer("Data Source=DESKTOP-884QEIL\\SQLEXPRESS;Initial Catalog=Du_An_1_Nhom_6;" +
                "Persist Security Info=True;User ID=hoanltph24402;Password=123456"));
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
        }
        public DbSet<ChiTietGioHang> ChiTietGioHangs { get; set; } 
        public DbSet<ChiTietHoaDon> ChiTietHoaDons { get; set; } 
        public DbSet<ChiTietSanPham> ChiTietSanPhams { get; set; }         
        public DbSet<DanhMuc> DanhMucs { get; set; }
        public DbSet<DonVi> DonVis { get; set; }
        public DbSet<GioHang> GioHangs { get; set; }
        public DbSet<HoaDon> HoaDons { get; set; }
        public DbSet<KhachHang> KhachHangs { get; set; }
        public DbSet<LoaiSp> LoaiSps { get; set; }
        public DbSet<LoaiTK> LoaiTKs { get; set; }
        public DbSet<NhaCungCap> NhaCungCaps { get; set; }
        public DbSet<NhanVien> NhanViens { get; set; }
        public DbSet<SanPham> SanPhams { get; set; }
        public DbSet<TaiKhoan> TaiKhoans { get; set; }
       
    }
}
