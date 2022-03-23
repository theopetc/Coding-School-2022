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
    public class MonthlyLedgerConfiguration : IEntityTypeConfiguration<MonthlyLedger>
    {
        public void Configure(EntityTypeBuilder<MonthlyLedger> builder)
        {
            builder.ToTable("MonthlyLedger");

            builder.HasKey(monthlyLedger => monthlyLedger.Year);
            //builder.Property(monthlyLedger => monthlyLedger.Month);
            builder.Property(monthlyLedger => monthlyLedger.Income).HasColumnType("decimal(18,2)");
            builder.Property(monthlyLedger => monthlyLedger.Expenses).HasColumnType("decimal(18,2)");
            builder.Property(monthlyLedger => monthlyLedger.Total).HasColumnType("decimal(18,2)");
        }
    }
}
