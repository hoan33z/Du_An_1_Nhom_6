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
    internal class HoaDonConfiguration : IEntityTypeConfiguration<HoaDon>
    {
        public void Configure(EntityTypeBuilder<HoaDon> builder)
        {
            builder.HasKey(c => c.IdHoaDon);
            builder.Property(c => c.IdNhanVien).IsRequired();
            builder.Property(c => c.IdKhachHang).IsRequired();
            builder.Property(c => c.TongTien).HasColumnName("TongTien").HasColumnType("decimal").IsRequired();
            builder.Property(c => c.NgayThanhToan).HasColumnName("NgayThanhToan").HasColumnType("datetime").IsRequired();
            builder.Property(c => c.NgayNhan).HasColumnName("NgayNhan").HasColumnType("datetime").IsRequired();
            builder.Property(c => c.SDT).HasColumnName("SDT").HasColumnType("nvarchar(10)").IsRequired();
            builder.Property(c => c.DiaChi).HasColumnName("ĐiaChi").HasColumnType("nvarchar(100)").IsRequired();
            builder.HasOne(c => c.NhanVien).WithMany().HasForeignKey(c => c.IdNhanVien);
            builder.HasOne(c => c.KhachHang).WithMany().HasForeignKey(c => c.IdKhachHang);
            }
    }
}
