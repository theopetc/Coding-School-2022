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
    public class EngineerConfiguration : IEntityTypeConfiguration<Engineer>
    {
        public void Configure(EntityTypeBuilder<Engineer> builder)
        {
            builder.ToTable("Engineer");

            //builder.HasKey(engineer => engineer.ID);
            builder.Property(engineer => engineer.Name).HasMaxLength(20);
            builder.Property(engineer => engineer.Surname).HasMaxLength(20);
            builder.Property(engineer => engineer.ManagerID);
            builder.Property(engineer => engineer.SallaryPerMonth).HasColumnType("decimal(18,2)");          
        }
    }
}
