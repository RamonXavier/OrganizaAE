using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace OrganizaAE.Infrastructure
{
    public interface IRepository<T>
    {
        Task<IReadOnlyList<T>> GetAllAsync();
        Task<IReadOnlyList<T>> GetAsync(Expression<Func<T, bool>> predicate);

        Task<IReadOnlyList<T>> GetAsync(Expression<Func<T, bool>> predicate = null,
            Func<IQueryable<T>, IOrderedQueryable<T>> orderBy = null,
            List<Expression<Func<T, object>>> includes = null,
            bool disableTracking = true);
        Task<T> GetByIdAsync(int id);
        Task<T> AddAndSaveAsync(T entity);
        Task AddRangeAndSaveAsync(IEnumerable<T> entities);
        Task AddAsync(T entity);
        Task Save();
        Task UpdateAsync(T entity);
        Task DeleteAsync(T entity);
    }
}
