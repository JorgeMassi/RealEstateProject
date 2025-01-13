using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RealEstate.Application.Interfaces.Generic
{
    public interface IRepository<TEntity, TPrimaryKey>
    {
        Task<IEnumerable<TEntity>> GetAll();
        Task<TEntity> GetById(TPrimaryKey id);
        Task<TEntity> Create(TEntity entity);
        TEntity Update(TEntity entity);
        TEntity Delete(TEntity entity);
        Task<TEntity> Delete(TPrimaryKey id);
    }
}
