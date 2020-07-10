using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace SICOFDataAccess.Infraestructure
{
    public interface IGenericRepository<T> where T : class
    {
        IQueryable<T> FindBy(Expression<Func<T, bool>> predicate);
        IQueryable<T> GetAll();
        bool Insert(T entity);
        bool Update(T entity);
        bool Update(object id, T entity);
        bool DeleteEntity(T entity);
        T Get(object id);
        IQueryable<T> Table { get; }
        bool Delete(object id);
        bool SaveAll(List<T> list);
        bool UpdateAll(List<T> list);
    }
}
