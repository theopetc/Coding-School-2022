using CarServiceCenter.EF.Context;
using CarServiceCenterLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarServiceCenter.EF.Repositories
{
    public class TransactionRepo : IEntityRepo<Transaction>
    {
        public async Task Create(Transaction entity)
        {
            using var context = new CarServiceCenterContext();
            context.Transaction.Add(entity);
            await context.SaveChangesAsync();
        }

        public async Task Delete(Guid ID)
        {
            using var context = new CarServiceCenterContext();
            var foundTransaction = context.Transaction.SingleOrDefault(x => x.ID == ID);
            if (foundTransaction is null)
                return;

            context.Transaction.Remove(foundTransaction);
            await context.SaveChangesAsync();
        }

        public List<Transaction> GetAll()
        {
            using var context = new CarServiceCenterContext();
            return context.Transaction.ToList();
        }

        public Transaction? GetById(Guid ID)
        {
            using var context = new CarServiceCenterContext();
            return context.Transaction.Where(x => x.ID == ID).SingleOrDefault();
        }

        public async Task Update(Guid ID, Transaction entity)
        {
            using var context = new CarServiceCenterContext();
            var foundTransaction = context.Transaction.SingleOrDefault(x => x.ID == ID);
            if (foundTransaction is null)
                return;

            foundTransaction.ManagerID = entity.ID;
            foundTransaction.CarID = entity.CarID;
            foundTransaction.CustomerID = entity.CustomerID;    
            foundTransaction.TotalPrice = entity.TotalPrice;    
            foundTransaction.TransactionLines = entity.TransactionLines;
            foundTransaction.Date = entity.Date;

            await context.SaveChangesAsync();
        }
    }
}
