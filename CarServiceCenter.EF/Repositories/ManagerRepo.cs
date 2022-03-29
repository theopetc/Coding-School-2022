using CarServiceCenter.EF.Context;
using CarServiceCenterLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarServiceCenter.EF.Repositories
{
    internal class ManagerRepo : IEntityRepo<Manager>
    {
        public async Task Create(Manager entity)
        {
            using var context = new CarServiceCenterContext();
            context.Manager.Add(entity);
            await context.SaveChangesAsync();
        }

        public async Task Delete(Guid ID)
        {
            using var context = new CarServiceCenterContext();
            var foundManager = context.Manager.SingleOrDefault(x => x.ID == ID);
            if (foundManager is null)
                return;

            context.Manager.Remove(foundManager);
            await context.SaveChangesAsync();
        }

        public List<Manager> GetAll()
        {
            using var context = new CarServiceCenterContext();
            return context.Manager.ToList();
        }

        public Manager? GetById(Guid ID)
        {
            using var context = new CarServiceCenterContext();
            return context.Manager.Where(manager => manager.ID == ID).SingleOrDefault();
        }

        public async Task Update(Guid ID, Manager entity)
        {
            using var context = new CarServiceCenterContext();
            var foundManager = context.Manager.SingleOrDefault(x => x.ID == ID);
            if (foundManager is null)
                return;
            
            foundManager.Name = entity.Name;
            foundManager.Surname = entity.Surname;
            foundManager.SallaryPerMonth = entity.SallaryPerMonth;
            
            await context.SaveChangesAsync();
        }
    }
}
