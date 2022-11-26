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
            builder.ToTable("HoaDon");

            builder.HasKey(c => c.IdHoaDon);
            builder.Property(c => c.IdKhachHang).IsRequired();
            builder.Property(c => c.IdNhanVien).IsRequired();
            builder.Property(c => c.TongTien).HasColumnName("TongTien").HasColumnType("decimal").IsRequired();
            builder.Property(c => c.NgayThanhToan).HasColumnName("NgayThanhToan").HasColumnType("datetime").IsRequired();
            builder.Property(c => c.TrangThai).HasColumnName("TrangThai").HasColumnType("bit").IsRequired();
            builder.HasOne(c => c.KhachHang).WithMany().HasForeignKey(c => c.IdKhachHang);
            builder.HasOne(c => c.NhanVien).WithMany().HasForeignKey(c => c.IdNhanVien);
        }
    }
}
