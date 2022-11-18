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
    internal class DanhMucConfiguration : IEntityTypeConfiguration<DanhMuc>
    {
        public void Configure(EntityTypeBuilder<DanhMuc> builder)
        {
            builder.ToTable("DanhMuc");

            builder.HasKey(c => c.IdDanhMuc);
            builder.Property(c => c.TenDanhMuc).HasColumnName("TenDanhMuc").HasColumnType("nvarchar(100)").IsRequired();
        }
    }

}
