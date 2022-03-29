using CarServiceCenter.EF.Context;
using CarServiceCenterLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarServiceCenter.EF.Repositories
{
    public class ServiceTaskRepo : IEntityRepo<ServiceTask>
    {
        public async Task Create(ServiceTask entity)
        {
            using var context = new CarServiceCenterContext();
            context.ServiceTask.Add(entity);
            await context.SaveChangesAsync();
        }

        public async Task Delete(Guid ID)
        {
            using var context = new CarServiceCenterContext();
            var foundServiceTask = context.ServiceTask.SingleOrDefault(x => x.ID == ID);
            if (foundServiceTask is null)
                return;

            context.ServiceTask.Remove(foundServiceTask);
            await context.SaveChangesAsync();
        }

        public List<ServiceTask> GetAll()
        {
            using var context = new CarServiceCenterContext();
            return context.ServiceTask.ToList();
        }

        public ServiceTask? GetById(Guid ID)
        {
            using var context = new CarServiceCenterContext();
            return context.ServiceTask.Where(x => x.ID == ID).SingleOrDefault();
        }

        public async Task Update(Guid ID, ServiceTask entity)
        {
            using var context = new CarServiceCenterContext();
            var foundServiceTask = context.ServiceTask.SingleOrDefault(x => x.ID == ID);
            if (foundServiceTask is null)
                return;

            foundServiceTask.Hours = entity.Hours;  
            foundServiceTask.Code = entity.Code;    
            foundServiceTask.Description = entity.Description;  

            await context.SaveChangesAsync();
            
        }
    }
}
