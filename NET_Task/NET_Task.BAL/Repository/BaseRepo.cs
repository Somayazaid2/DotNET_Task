using Microsoft.EntityFrameworkCore;
using NET_Task.DAL.BaseRepoInterface;
using NET_Task.DAL.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace NET_Task.BAL.Repository
{
    public class BaseRepo<T> : IAsyncRepository<T> where T : class
    {

        #region Injecting DbContext
        private readonly MainDbContext context;

        public BaseRepo(MainDbContext context)
        {
            this.context = context;
        }
        #endregion

        #region public methods
        public async Task AddAsync(T entity)
        {
            await context.AddAsync(entity);
            await context.SaveChangesAsync();
        }
        public async Task<int> CountAllAsync() => await context.Set<T>().CountAsync();
        public async Task<int> CountWhereAsync(Expression<Func<T, bool>> predicate) => await context.Set<T>().CountAsync(predicate);
        public async Task<T> FirstOrDefaultAsync(Expression<Func<T, bool>> where, params Expression<Func<T, object>>[] includeProperties)
        {
            var data = await GetWhereAsync(where, includeProperties);
            return data.FirstOrDefault();
        }
        public async Task<IEnumerable<T>> GetAllAsync() => await context.Set<T>().ToListAsync();
        public async Task<T> GetByIdAsync(int id) => await context.Set<T>().FindAsync(id);
        public async Task<IEnumerable<T>> GetWhereAsync(Expression<Func<T, bool>> predicate, params Expression<Func<T, object>>[] includeProperties)
        {
            var query = predicate == null ? context.Set<T>() : context.Set<T>().Where(predicate);
            var entities = includeProperties.Aggregate(query, (current, includeProperty) =>
                current.Include(includeProperty));
            return await entities.ToListAsync();
        }
        public async Task RemoveAsync(T entity)
        {
            context.Set<T>().Remove(entity);
            await context.SaveChangesAsync();
        }
        public async Task UpdateAsync(T entity)
        {
            // In case AsNoTracking is used
            context.Entry(entity).State = EntityState.Modified;
            await context.SaveChangesAsync();
        }


        #endregion
    }
}
