using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TravelerAPI.Models.Repositories
{
    public interface IServiceRepository<TEntity>
    {
        public IList<TEntity> List();

        public TEntity GetById(int Id);

        public TEntity Add(TEntity entity);

        public TEntity Update(int Id, TEntity entity);

        public TEntity DeleteById(int Id);
    }
}
