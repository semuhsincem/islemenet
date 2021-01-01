using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace Core
{
    public interface IRepository<T> where T:BaseEntity,IEntity,new()
    {
        T Get(int id);
        T Add(T entity);
        T Delete(int id);
        T Update(T entity);

        List<T> GetList(Expression<Func<T,bool>> expression = null);
        IQueryable<T> GetListQueryable(Expression<Func<T, bool>> expression = null);
        
    }
}
