using DevFrameworkCore.Entities;
using System.Linq;

namespace DevFrameworkCore.DataAccess.NHibernate
{
    public class NhQueryableRepository<T> : IQueryableRepository<T> where T : class, IEntity, new()
    {
        private NHibernateHelper _nHibernateHelper;
        IQueryable<T> _entities;

        public NhQueryableRepository(NHibernateHelper nHibernateHelper)
        {
            _nHibernateHelper = nHibernateHelper;
        }

        public IQueryable<T> Table => this.Entities;
        public virtual IQueryable<T> Entities
        {
            get
            {
                if (_entities == null)
                {
                    _entities = _nHibernateHelper.OpenSession().Query<T>();
                }
                return _entities;
            }
        }
    }
}
