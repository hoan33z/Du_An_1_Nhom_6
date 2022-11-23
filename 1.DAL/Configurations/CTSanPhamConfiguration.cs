using _1.DAL.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.DAL.Configurations
{
    internal class CTSanPhamConfiguration : IEntityTypeConfiguration<ChiTietSanPham>
    {
        public void Configure(EntityTypeBuilder<ChiTietSanPham> builder)
        {
            builder.ToTable("ChiTietSP");

            builder.HasKey(c => c.IdChiTietSP);
            builder.Property(c => c.IdLoaiSp).IsRequired();
            builder.Property(c => c.IdNhaCungCap).IsRequired();
            builder.Property(c => c.IdSp).IsRequired();
            builder.Property(c => c.IdDonVi).IsRequired();
            builder.Property(c => c.IdDanhMuc).IsRequired();
            builder.Property(c => c.GiaBan).HasColumnName("GiaBan").HasColumnType("decimal");
            builder.Property(c => c.GiaNhap).HasColumnName("GiaNhap").HasColumnType("decimal");
            builder.Property(c => c.SoLuong).HasColumnName("SoLuong").HasColumnType("int");
            builder.Property(c => c.HinhAnh).HasColumnName("HinhAnh").HasColumnType("image");
            builder.HasOne(c => c.LoaiSp).WithMany().HasForeignKey(c => c.IdLoaiSp);
            builder.HasOne(c => c.NhaCungCap).WithMany().HasForeignKey(c => c.IdNhaCungCap);
            builder.HasOne(c => c.SanPham).WithMany().HasForeignKey(c => c.IdSp);
            builder.HasOne(c => c.DanhMuc).WithMany().HasForeignKey(c => c.IdDanhMuc);
            builder.HasOne(c => c.DonVi).WithMany().HasForeignKey(c => c.IdDonVi);
        }
    }
}
