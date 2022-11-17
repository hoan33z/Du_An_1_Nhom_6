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
    internal class KhachHangConfiguration : IEntityTypeConfiguration<KhachHang>
    {
        public void Configure(EntityTypeBuilder<KhachHang> builder)
        {
            builder.HasKey(c => c.IdKhachHang);
            builder.Property(c => c.Email).IsRequired();
            builder.Property(c => c.TenKh).HasColumnName("TenKhachHang").HasColumnType("nvarchar(100)").IsRequired();
            builder.Property(c => c.SDT).HasColumnName("SDT").HasColumnType("nvarchar(10)").IsRequired();
            builder.Property(c => c.DiaChi).HasColumnName("ĐiaChi").HasColumnType("nvarchar(100)").IsRequired();
            builder.Property(c => c.Email).HasColumnName("Email").HasColumnType("nvarchar(50)").IsRequired();
        }
    }
}
