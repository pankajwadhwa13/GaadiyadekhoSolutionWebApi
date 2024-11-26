using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Interfaces.Repositories.Common
{
    public interface IBaseRepository<T> where T : class
    {
        // Get all entities
        Task<IEnumerable<T>> GetAllAsync();

        // Get entities by condition
        Task<IEnumerable<T>> GetAsync(Expression<Func<T, bool>> predicate);

        // Get a single entity by ID
        Task<T> GetByIdAsync(object id);

        // Add a single entity
        Task AddAsync(T entity);

        // Add multiple entities
        Task AddRangeAsync(IEnumerable<T> entities);

        // Update an entity
        void Update(T entity);

        // Delete an entity by ID
        Task DeleteAsync(object id);

        // Count all entities
        Task<int> CountAsync();

        // Check if any entities match a condition
        Task<bool> ExistsAsync(Expression<Func<T, bool>> predicate);
    }
}
