using CarServiceCenterLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarServiceCenter.EF.Repositories
{
    public interface IEntityRepo<TEntity> where TEntity : Person
    {
        List<TEntity> GetAll();
        TEntity? GetById(Guid ID);
        Task Create(TEntity entity);
        Task Update(Guid ID, TEntity entity);
        Task Delete(Guid ID);
    }
}
