using CarServiceCenter.EF.Context;
using CarServiceCenterLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarServiceCenter.EF.Repositories
{
    public class CustomerRepo : IEntityRepo<Customer>
    {
        public async Task Create(Customer entity)
        {
            using var context = new CarServiceCenterContext();
            context.Customers.Add(entity);
            await context.SaveChangesAsync();   
        }

        public async Task Delete(Guid ID)
        {
            using var context = new CarServiceCenterContext();
            var foundCustomer = context.Customers.SingleOrDefault(x => x.ID == ID);
            if (foundCustomer is null)
                return;

            context.Customers.Remove(foundCustomer);
            await context.SaveChangesAsync();
        }

        public List<Customer> GetAll()
        {
            using var context = new CarServiceCenterContext();
            return context.Customers.ToList();
        }

        public Customer? GetById(Guid ID)
        {
            using var context = new CarServiceCenterContext();
            return context.Customers.Where(customer => customer.ID == ID).SingleOrDefault();
        }

        public async Task Update(Guid ID, Customer entity)
        {
            using var context = new CarServiceCenterContext();
            var foundCustomer = context.Customers.SingleOrDefault(x => x.ID == ID);
            if (foundCustomer is null)
                return;
            foundCustomer = entity;
            //context.Customers.Update(foundCustomer);
            await context.SaveChangesAsync();            
        }
    }
}
