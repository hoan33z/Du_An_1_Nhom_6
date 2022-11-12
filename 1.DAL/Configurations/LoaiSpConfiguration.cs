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
    internal class LoaiSpConfiguration : IEntityTypeConfiguration<LoaiSp>
    {
        public void Configure(EntityTypeBuilder<LoaiSp> builder)
        {
            builder.HasKey(c => c.IdLoaiSp);

            builder.Property(c => c.TenLoaiSp).HasColumnName("TenLoaiSp").HasColumnType("nvarchar(100)").IsRequired();
        }
    }
}
