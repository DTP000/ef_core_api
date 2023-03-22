using ef_ktr_api.Data;
using ef_ktr_api.Repository.Interface;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;

namespace ef_ktr_api.Repository
{
    public class Repository<T> : IRepository<T> where T : class
    {
        private readonly AppDb _context;
        private readonly DbSet<T> _dbSet;

        public Repository(AppDb context)
        {
            _context = context;
            _dbSet = _context.Set<T>();
        }
        public ICollection<T> Get(Expression<Func<T, bool>> match)
        {
            return _context.Set<T>().Where(match).ToList();
        }
        public ICollection<T> Get(Expression<Func<T, bool>> match, int pageSize, int pageIndex, out int total)
        {
            var filteredElements = _context.Set<T>().Where(match.Compile());
            total = filteredElements.Count();
            var pageElements = filteredElements.Skip(pageSize * (pageIndex - 1)).Take(pageSize);
            return pageElements.ToList();
        }

        public T? Update(T t, object key)
        {
            T? entity = _context.Set<T>().Find(key);

            if (entity != null)
            {
                _context.Entry(entity).CurrentValues.SetValues(t);
                _context.SaveChanges();
            }

            return entity;
        }
        public T Create(T t)
        {
            _context.Set<T>().Add(t);
            _context.SaveChanges();
            return t;
        }

        public void Delete(T entity)
        {
            _context.Remove(entity);
            _context.SaveChanges();
        }

        public T? Get(int id)
        {
            return _context.Set<T>().Find(id);
        }
        
        public ICollection<T> GetAll()
        {
            return _context.Set<T>().ToList();
        }

    }
}
