using Microsoft.EntityFrameworkCore;
using Movies.Core.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Movies.Core.DataAccess.EntityFramework
{
    public class EfRepositoryBase<TEntity, TContext> : IEntityRepository<TEntity>
        where TEntity : class, IEntity
        where TContext : DbContext
    {
        public EfRepositoryBase(TContext context)
        {
            Context = context;
        }
        protected TContext Context { get; }

        public TEntity Add(TEntity entity)
        {
         
         
            Context.Add(entity);
            Context.SaveChanges();
            return entity;
        }

        public void Delete(TEntity entity)
        {
            Context.Remove(entity);
            Context.SaveChanges();
        }

        public TEntity Get(Expression<Func<TEntity, bool>> expression)
        {
            return Context.Set<TEntity>().FirstOrDefault(expression);
        }

        public List<TEntity> GetAll(Expression<Func<TEntity, bool>> filter = null)
        {
           
            
                return filter == null ?
                      Context.Set<TEntity>().ToList() :
                      Context.Set<TEntity>().Where(filter).ToList();
            
        }

        public async Task<TEntity> GetAsync(Expression<Func<TEntity, bool>> expression)
        {
            return await Context.Set<TEntity>().AsQueryable().FirstOrDefaultAsync(expression);
        }

        public async Task<IEnumerable<TEntity>> GetList(Expression<Func<TEntity, bool>> expression = null)
        {
            return expression == null ?
                 await Context.Set<TEntity>().ToListAsync() :
                 await Context.Set<TEntity>().Where(expression).ToListAsync();

        }

        public int saveChanges()
        {
            return Context.SaveChanges();
        }

        public async Task<int> SaveChanges()
        {
            return await  Context.SaveChangesAsync();
        }

        public TEntity Update(TEntity entity)
        {
            Context.Update(entity);
            Context.SaveChanges();
            return entity;
        }
    }

}

