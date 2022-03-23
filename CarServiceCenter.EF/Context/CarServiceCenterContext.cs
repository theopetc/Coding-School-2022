using CarServiceCenter.EF.Configuration;
using CarServiceCenterLibrary;
using Microsoft.EntityFrameworkCore;
using Session_11;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarServiceCenter.EF.Context
{
    public class CarServiceCenterContext : DbContext
    {
        public virtual DbSet<Person> Persons { get; set; }
        public virtual DbSet<Customer> Customers { get; set; }
        public virtual DbSet<Manager> Manager { get; set; }
        public virtual DbSet<Engineer> Engineer { get; set; }
        public virtual DbSet<Car> Car { get; set; }
        public virtual DbSet<MonthlyLedger> MonthlyLedger { get; set; }
        public virtual DbSet<ServiceTask> ServiceTask { get; set; }
        public virtual DbSet<Transaction> Transaction { get; set; }
        public virtual DbSet<TransactionLine> TransactionLine { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.ApplyConfiguration(new PersonConfiguration());
            modelBuilder.ApplyConfiguration(new CustomerConfiguration());
            modelBuilder.ApplyConfiguration(new ManagerConfiguration());
            modelBuilder.ApplyConfiguration(new EngineerConfiguration());
            modelBuilder.ApplyConfiguration(new CarConfiguration());
            modelBuilder.ApplyConfiguration(new MonthlyLedgerConfiguration());
            modelBuilder.ApplyConfiguration(new ServiceTaskConfiguration());            
            modelBuilder.ApplyConfiguration(new TransactionConfiguration());
            modelBuilder.ApplyConfiguration(new TransactionLineConfiguration());
        }        

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            string connString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=DbCarServiceCenter;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
            optionsBuilder.UseSqlServer(connString);            
        }
    }
}
