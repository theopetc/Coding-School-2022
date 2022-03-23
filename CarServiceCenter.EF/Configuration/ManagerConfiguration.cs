using CarServiceCenterLibrary;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarServiceCenter.EF.Configuration
{
    public class ManagerConfiguration : IEntityTypeConfiguration<Manager>
    {
        public void Configure(EntityTypeBuilder<Manager> builder)
        {
            builder.ToTable("Manager");

            //builder.HasKey(manager => manager.ID);
            builder.Property(manager => manager.Name).HasMaxLength(20);
            builder.Property(manager => manager.Surname).HasMaxLength(20);
            builder.Property(manager => manager.SallaryPerMonth).HasColumnType("decimal(18,2)");
        }
    }
}
