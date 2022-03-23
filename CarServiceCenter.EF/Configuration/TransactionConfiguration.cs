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
    public class TransactionConfiguration : IEntityTypeConfiguration<Transaction>
    {
        public void Configure(EntityTypeBuilder<Transaction> builder)
        {
            builder.ToTable("Transaction");

            builder.HasKey(transaction => transaction.ID);
            builder.Property(transaction => transaction.Date);
            builder.Property(transaction => transaction.CustomerID);
            builder.Property(transaction => transaction.CarID);
            builder.Property(transaction => transaction.ManagerID);
            builder.Property(transaction => transaction.TotalPrice).HasColumnType("decimal(18,2)");
            //builder.Property(transaction => transaction.TransactionLines);

        }
    }
}
