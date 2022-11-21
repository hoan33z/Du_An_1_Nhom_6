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
    internal class NhaCCConfiguration : IEntityTypeConfiguration<NhaCungCap>
    {
        public void Configure(EntityTypeBuilder<NhaCungCap> builder)
        {
            builder.ToTable("NhaCungCap");

            builder.HasKey(c => c.IdNhaCungCap);

            builder.Property(c => c.TenNhaCungCap).HasColumnName("TenNhaCC").HasColumnType("nvarchar(100)").IsRequired();
        }
    }
}
