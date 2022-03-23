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
    public class PersonConfiguration: IEntityTypeConfiguration<Person>
    {        
        public void Configure(EntityTypeBuilder<Person> builder)
        {
            builder.ToTable("Person");

            builder.HasKey(person => person.ID);
            builder.Property(person => person.Name).HasMaxLength(25);
            builder.Property(person => person.Surname).HasMaxLength(20);            
        }
    }
}
