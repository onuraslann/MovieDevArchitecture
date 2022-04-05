using Movies.Core.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Movies.Core.DataAccess
{
    public interface IEntityRepository<T> where T:class,IEntity
    {
   
        T Add(T entity);
        T Update(T entity);
        void Delete(T entity);
        int saveChanges();
        Task<int> SaveChanges();
        T Get(Expression<Func<T, bool>> expression);
        Task<IEnumerable<T>> GetList(Expression<Func<T, bool>> expression = null);
        Task<T> GetAsync(Expression<Func<T, bool>> expression);     
        List<T> GetAll(Expression<Func<T, bool>> filter = null);

    }
}
