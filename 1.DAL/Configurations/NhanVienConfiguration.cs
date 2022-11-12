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
            builder.HasKey(c => c.IdNhanVien);

            builder.Property(c => c.TenNv).HasColumnName("Tên Nhân Viên").HasColumnType("nvarchar(100)").IsRequired();
            builder.Property(c => c.NamSinh).HasColumnName("Năm Sinh").HasColumnType("datetime").IsRequired();
            builder.Property(c => c.GioiTinh).HasColumnName("Giới Tính").HasColumnType("int").IsRequired();
            builder.Property(c => c.Email).HasColumnName("Email").HasColumnType("nvarchar(50)").IsRequired();
            builder.Property(c => c.DiaChi).HasColumnName("Địa Chỉ").HasColumnType("nvarchar(100)").IsRequired();
            builder.Property(c => c.SDT).HasColumnName("Số Điện Thoại").HasColumnType("nvarchar(10)").IsRequired();

        }
    }
}
