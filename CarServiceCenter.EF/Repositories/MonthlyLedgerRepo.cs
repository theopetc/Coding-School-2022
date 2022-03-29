using CarServiceCenter.EF.Context;
using CarServiceCenterLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarServiceCenter.EF.Repositories
{
    public class MonthlyLedgerRepo : IEntityRepo<MonthlyLedger>
    {
        public async Task Create(MonthlyLedger entity)
        {
            using var context = new CarServiceCenterContext();
            context.MonthlyLedger.Add(entity);
            await context.SaveChangesAsync();
        }

        public Task Delete(Guid ID)
        {
            throw null;
        }

        public List<MonthlyLedger> GetAll()
        {
            throw new NotImplementedException();
        }

        public MonthlyLedger? GetById(Guid ID)
        {
            throw new NotImplementedException();
        }

        public Task Update(Guid ID, MonthlyLedger entity)
        {
            throw new NotImplementedException();
        }
    }
}
