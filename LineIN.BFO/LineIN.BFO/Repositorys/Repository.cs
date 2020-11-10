using LineIN.BFO.Data;
using LineIN.BFO.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace LineIN.BFO.Repositorys
{
    public class Repository<TEntity> : IRepository<TEntity> where TEntity : class
    {
        protected readonly DbContextBFO _ctx;
        protected readonly DbSet<TEntity> _dbSet;

        public Repository(DbContextBFO context)
        {
            _ctx = context;
            _dbSet = _ctx.Set<TEntity>();
        }


        public async Task<IEnumerable<TEntity>> GetAllByAsync(Expression<Func<TEntity, bool>> predicate)
        {
            return await _dbSet.AsNoTracking().Where(predicate).ToListAsync();
        }

        public IEnumerable<TEntity> GetAllBy(Expression<Func<TEntity, bool>> predicate)
        {
            return _dbSet.Where(predicate).AsEnumerable();
        }

        public virtual async Task<List<TEntity>> GetAllAsync()
        {
            return await _dbSet.ToListAsync();
        }

        public virtual List<TEntity> GetAll()
        {
            return _dbSet.ToList();
        }

        public virtual async Task<TEntity> GetByAsync(Expression<Func<TEntity, bool>> predicate)
        {
            return await _dbSet.Where(predicate).SingleOrDefaultAsync();
        }

        public virtual TEntity GetBy(Expression<Func<TEntity, bool>> predicate)
        {
            return _dbSet.Where(predicate).FirstOrDefault();
        }

        public virtual async Task<TEntity> GetByIdAsync(int Id)
        {
            return await _dbSet.FindAsync(Id);
        }

        public virtual TEntity GetById(int Id)
        {
            return _dbSet.Find(Id);
        }

        public virtual void Insert(TEntity entity)
        {

            _dbSet.Add(entity);
            SaveChanges();
        }

        public virtual void Update(TEntity entity)
        {
            _dbSet.Update(entity);
            SaveChanges();
        }

        public virtual void Delete(TEntity entity)
        {
            _dbSet.Remove(entity);
            SaveChanges();
        }

        public int SaveChanges()
        {
            return _ctx.SaveChanges();
        }

        public virtual async Task InsertAsync(TEntity entity)
        {
            _dbSet.Add(entity);
            await SaveChangesAsync();
        }

        public virtual async Task UpdateAsync(TEntity entity)
        {
            _dbSet.Update(entity);
            await SaveChangesAsync();
        }

        public virtual async Task DeleteAsync(TEntity entity)
        {
            _dbSet.Remove(entity);
            await SaveChangesAsync();
        }

        public async Task<int> SaveChangesAsync()
        {
            return await _ctx.SaveChangesAsync();
        }

        public void Dispose()
        {
            _ctx?.Dispose();
        }

    }
}
