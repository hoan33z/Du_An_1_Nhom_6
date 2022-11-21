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
    internal class DonViConfiguration : IEntityTypeConfiguration<DonVi>
    {

        public void Configure(EntityTypeBuilder<DonVi> builder)
        {
            builder.ToTable("DonVi");

            builder.HasKey(c => c.IdDonVi);
            builder.Property(c => c.TenDonVi).HasColumnName("TenDonVi").HasColumnType("nvarchar(50)");
        }

    }
}
