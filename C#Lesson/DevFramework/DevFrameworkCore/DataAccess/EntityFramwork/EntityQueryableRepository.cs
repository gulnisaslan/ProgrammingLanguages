using DevFrameworkCore.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevFrameworkCore.DataAccess.EntityFramwork
{
    public class EntityQueryableRepository<T> : IQueryableRepository<T> where T : class, IEntity, new()
    {
      private  DbContext _dbContext;
      private  IDbSet<T> _entities;

        public EntityQueryableRepository(DbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public IQueryable<T> Table => this.Entities;
        protected virtual IDbSet<T> Entities
        {
            get
            {
                if (_entities==null)
                {
                    _entities = _dbContext.Set<T>();
                }
                return _entities;
            }
        }
    }
}
