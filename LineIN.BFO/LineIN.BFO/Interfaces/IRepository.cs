using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace LineIN.BFO.Interfaces
{
    public interface IRepository<TEntity>: IDisposable where TEntity : class
    {
        Task<TEntity> GetByIdAsync(int Id);
        TEntity GetById(int Id);
        Task<TEntity> GetByAsync(Expression<Func<TEntity, bool>> predicate);
        TEntity GetBy(Expression<Func<TEntity, bool>> predicate);
        Task<IEnumerable<TEntity>> GetAllByAsync(Expression<Func<TEntity, bool>> predicate);
        IEnumerable<TEntity> GetAllBy(Expression<Func<TEntity, bool>> predicate);
        Task<List<TEntity>> GetAllAsync();
        List<TEntity> GetAll();
        void Insert(TEntity entity);
        void Update(TEntity entity);
        void Delete(TEntity entity);
        int SaveChanges();

        Task InsertAsync(TEntity entity);
        Task UpdateAsync(TEntity entity);
        Task DeleteAsync(TEntity entity);
        Task<int> SaveChangesAsync();
    }
}
