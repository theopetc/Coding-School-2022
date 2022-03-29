using CarServiceCenter.EF.Context;
using CarServiceCenterLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarServiceCenter.EF.Repositories
{
    public class CarRepo : IEntityRepo<Car>
    {
        public async Task Create(Car entity)
        {
            using var context = new CarServiceCenterContext();
            context.Car.Add(entity);
            await context.SaveChangesAsync();
        }

        public async Task Delete(Guid ID)
        {
            using var context = new CarServiceCenterContext();
            var foundCar = context.Car.SingleOrDefault(x => x.ID == ID);
            if (foundCar is null)
                return;

            context.Car.Remove(foundCar);
            await context.SaveChangesAsync();
        }

        public List<Car> GetAll()
        {
            using var context = new CarServiceCenterContext();
            return context.Car.ToList();
        }

        public Car? GetById(Guid ID)
        {
            using var context = new CarServiceCenterContext();
            return context.Car.Where(car => car.ID == ID).SingleOrDefault();
        }

        public async Task Update(Guid ID, Car entity)
        {
            using var context = new CarServiceCenterContext();
            var foundCar = context.Car.SingleOrDefault(x => x.ID == ID);
            if (foundCar is null)
                return;

            foundCar.Brand = entity.Brand;
            foundCar.Model = entity.Model;
            foundCar.RegistrationNumber = entity.RegistrationNumber;
            
            await context.SaveChangesAsync();
        }
    }
}
