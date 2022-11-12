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
    internal class ChiTietGioHangConfiguration : IEntityTypeConfiguration<ChiTietGioHang>
    {
        public void Configure(EntityTypeBuilder<ChiTietGioHang> builder)
        {
            builder.HasKey(c => c.IdCTGioHang);
            builder.Property(c => c.IdChiTietSp).IsRequired();
            builder.Property(c => c.IdGioHang).IsRequired();
            builder.Property(c => c.DonGia).HasColumnName("DonGia").HasColumnType("decimal");
            builder.Property(c => c.SoLuongMua).HasColumnName("SoLuongMua").HasColumnType("int");
            builder.HasOne(c => c.ChiTietSanPham).WithMany().HasForeignKey(c => c.IdChiTietSp);
            builder.HasOne(c => c.GioHang).WithMany().HasForeignKey(c => c.IdGioHang);
        }
    }
}
