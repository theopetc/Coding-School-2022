using CarServiceCenterLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarServiceCenter.EF.Repositories
{
    public class MockCustomerRepo : IEntityRepo<Customer>
    {
        private List<Customer> _customers = new List<Customer>()
        {
            new Customer { Name = "Pelatis1", Surname = "sPelatis1", Phone="1234567890", TIN="123456780"},
            new Customer { Name = "Pelatis2", Surname = "sPelatis2", Phone="2234567890", TIN="223456780"}
        };

        public Task Create(Customer entity)
        {
            _customers.Add(entity);
            return Task.CompletedTask;
        }

        public Task Delete(Guid ID)
        {
            var foundCustomer = _customers.SingleOrDefault(customer => customer.ID == ID);
            if (foundCustomer is null)
                return Task.CompletedTask;
            _customers.Remove(foundCustomer);
            return Task.CompletedTask;
        }

        public List<Customer> GetAll()
        {
            return _customers;
        }

        public Customer? GetById(Guid ID)
        {
            return _customers.SingleOrDefault(customer => customer.ID == ID);
        }

        public Task Update(Guid ID, Customer entity)
        {
            var foundCustomer = _customers.SingleOrDefault(customer => customer.ID == ID);
            if (foundCustomer is null)
                return Task.CompletedTask;
            foundCustomer = entity;
            return Task.CompletedTask;
        }
    }
}
