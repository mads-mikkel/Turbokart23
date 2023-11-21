using Microsoft.EntityFrameworkCore;

using Turbokart.Infrastructure.Persistence.Interfaces;

namespace Turbokart.Infrastructure.Persistence.Repositories
{
    public abstract class RepositoryBase<T>: IRepository<T> where T : class
    {
        protected DbSet<T> set;

        protected RepositoryBase(DbContext dbContext)
        {
            this.set = dbContext.Set<T>();
        }

        public virtual IEnumerable<T> GetAll()
        {
            return set.ToList();
        }

        public T GetBy(object id)
        {
            return set.Find(id);
        }

        public void Save(T entity)
        {
            set.Add(entity);
        }
    }
}