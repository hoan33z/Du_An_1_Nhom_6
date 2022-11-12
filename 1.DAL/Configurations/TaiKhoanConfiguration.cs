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
    internal class TaiKhoanConfiguration : IEntityTypeConfiguration<TaiKhoan>
    {
        public void Configure(EntityTypeBuilder<TaiKhoan> builder)
        {
            builder.HasKey(c => c.IdTaiKhoan);

            builder.Property(c => c.TenTaiKhoan).HasColumnName("TenTaiKhoan").HasColumnType("nvarchar(100)").IsRequired();
            builder.Property(c => c.MatKhau).HasColumnName("MatKhau").HasColumnType("nvarchar(100)").IsRequired();
            builder.Property(c => c.LoaiTk).HasColumnName("LoaiTK").HasColumnType("int").IsRequired();
            builder.Property(c => c.TrangThai).HasColumnName("TrangThai").HasColumnType("int").IsRequired();

        }
    }
}
