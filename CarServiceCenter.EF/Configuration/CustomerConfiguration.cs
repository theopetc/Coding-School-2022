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
    public class CustomerConfiguration: IEntityTypeConfiguration<Customer>
    {
        public void Configure(EntityTypeBuilder<Customer> builder)
        {
            builder.ToTable("Customer");

            //builder.HasKey(customer => customer.ID);
            builder.Property(customer => customer.Name).HasMaxLength(20);
            builder.Property(customer => customer.Surname).HasMaxLength(20);
            builder.Property(customer => customer.TIN).HasMaxLength(9);
            builder.Property(customer => customer.Phone).HasMaxLength(15);

            //builder.HasOne(customer => customer.ID).WithOne(person => person.ID).HasForeignKey<Person>(person => person.ID);

        }
    }
}
