using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using UdemyAuthServer.Core.Repository;

namespace UdemyAuthServer.Data.Repositories
{
    public class GenericRepository<T> : IGenericRepository<T> where T : class
    {
        private readonly DbContext _context;
        private readonly DbSet<T> _dbSet;

        public GenericRepository(AppDbContext context)
        {
            _dbSet = context.Set<T>();
            _context = context;
        }

        async Task IGenericRepository<T>.AddAsync(T entity)
        {
            await _dbSet.AddAsync(entity);
        }

        async Task<IEnumerable<T>> IGenericRepository<T>.GetAllAsync()
        {
            return await _dbSet.ToListAsync();
        }

        async Task<T> IGenericRepository<T>.GetByIdAsync(int id)
        {
            var entity = await _dbSet.FindAsync(id);
            if (entity != null)
            {
                _context.Entry(entity).State = EntityState.Detached;
            }
            return entity;
        }

        void IGenericRepository<T>.Remove(T entity)
        {
            _dbSet.Remove(entity);
        }

        T IGenericRepository<T>.Update(T entity)
        {
            _context.Entry(entity).State |= EntityState.Modified;
            return entity;
        }

        IQueryable<T> IGenericRepository<T>.Where(Expression<Func<T, bool>> predicate)
        {
            return _dbSet.Where(predicate);
        }
    }
}
