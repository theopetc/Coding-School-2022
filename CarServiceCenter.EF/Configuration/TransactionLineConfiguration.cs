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
    public class TransactionLineConfiguration : IEntityTypeConfiguration<TransactionLine>
    {
        public void Configure(EntityTypeBuilder<TransactionLine> builder)
        {
            builder.ToTable("TransactionLines");

            builder.HasKey(transactionLine => transactionLine.ID);
            builder.Property(transactionLine => transactionLine.TransactionID);
            builder.Property(transactionLine => transactionLine.ServiceTaskID);
            builder.Property(transactionLine => transactionLine.EngineerID);
            builder.Property(transactionLine => transactionLine.Hours).HasColumnType("decimal(18,2)");
            builder.Property(transactionLine => transactionLine.PRICE_PER_HOUR).HasColumnType("decimal(18,2)");
            builder.Property(transactionLine => transactionLine.Price).HasColumnType("decimal(18,2)");
        }
    }
}
