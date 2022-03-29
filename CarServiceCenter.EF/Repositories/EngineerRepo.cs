using CarServiceCenter.EF.Context;
using CarServiceCenterLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarServiceCenter.EF.Repositories
{
    internal class EngineerRepo : IEntityRepo<Engineer> 
    {
        public async Task Create(Engineer entity)
        {
            using var context = new CarServiceCenterContext();
            context.Engineer.Add(entity);
            await context.SaveChangesAsync();
        }

        public async Task Delete(Guid ID)
        {
            using var context = new CarServiceCenterContext();
            var foundEngineer = context.Engineer.SingleOrDefault(x => x.ID == ID);
            if (foundEngineer is null)
                return;

            context.Engineer.Remove(foundEngineer);
            await context.SaveChangesAsync();
        }

        public List<Engineer> GetAll()
        {
            using var context = new CarServiceCenterContext();
            return context.Engineer.ToList();
        }

        public Engineer? GetById(Guid ID)
        {
            using var context = new CarServiceCenterContext();
            return context.Engineer.Where(engineer => engineer.ID == ID).SingleOrDefault();
        }

        public async Task Update(Guid ID, Engineer entity)
        {
            using var context = new CarServiceCenterContext();
            var foundEngineer = context.Engineer.SingleOrDefault(x => x.ID == ID);
            if (foundEngineer is null)
                return;
            
            foundEngineer.Name = entity.Name;
            foundEngineer.Surname = entity.Surname;
            foundEngineer.SallaryPerMonth = entity.SallaryPerMonth;
            foundEngineer.ManagerID = entity.ManagerID; 

            await context.SaveChangesAsync(); 
        }
    }
}
