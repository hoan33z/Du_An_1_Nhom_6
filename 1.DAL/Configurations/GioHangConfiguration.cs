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
    internal class GioHangConfiguration : IEntityTypeConfiguration<GioHang>
    {
        public void Configure(EntityTypeBuilder<GioHang> builder)
        {
            builder.HasKey(c => c.IdGioHang);
            builder.Property(c => c.IdKhachHang).IsRequired();
            builder.Property(c => c.DiaChi).HasColumnName("DiaChi").HasColumnType("nvarchar(100)").IsRequired();
            builder.Property(c => c.SDT).HasColumnName("SDT").HasColumnType("nvarchar(10)").IsRequired();
            builder.Property(c => c.NgayThanhToan).HasColumnName("NgayThanhToan").HasColumnType("datetime").IsRequired();
            builder.Property(c => c.TrangThai).HasColumnName("TrangThai").HasColumnType("int").IsRequired();
            builder.HasOne(c => c.KhachHang).WithMany().HasForeignKey(c => c.IdKhachHang);
        }
    }
}
