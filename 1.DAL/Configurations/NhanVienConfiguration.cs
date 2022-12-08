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
    internal class NhanVienConfiguration : IEntityTypeConfiguration<NhanVien>
    {
        public void Configure(EntityTypeBuilder<NhanVien> builder)
        {
            builder.ToTable("NhanVien");
            builder.HasKey(c => c.IdNhanVien);
            builder.HasData(
                new NhanVien()
                {
                    Email = "1",
                    MatKhau = "1"
                });
            builder.Property(c => c.Email).IsRequired();
            builder.Property(c => c.TenNv).HasColumnName("TenNhanVien").HasColumnType("nvarchar(100)").IsRequired();
            builder.Property(c => c.NamSinh).HasColumnName("NamSinh").HasColumnType("datetime").IsRequired();
            builder.Property(c => c.GioiTinh).HasColumnName("GioiTinh").HasColumnType("bit").IsRequired();
            builder.Property(c => c.Email).HasColumnName("Email").HasColumnType("nvarchar(50)").IsRequired();
            builder.Property(c => c.DiaChi).HasColumnName("ĐiaChi").HasColumnType("nvarchar(100)").IsRequired();
            builder.Property(c => c.SDT).HasColumnName("SĐT").HasColumnType("nvarchar(10)").IsRequired();
            builder.Property(c => c.MatKhau).HasColumnName("MatKhau").HasColumnType("nvarchar(50)").IsRequired();
            builder.Property(c => c.IdLoaiTk).HasColumnName("IdLoaiTk").HasColumnType("bit").IsRequired();
            builder.Property(c => c.TrangThai).HasColumnName("TrangThaiTK").HasColumnType("bit").IsRequired();
            builder.Property(c => c.TrangThaiPass).HasColumnName("TrangThaiPass").HasColumnType("bit").IsRequired();

        }
    }
}
