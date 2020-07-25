using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace IQTest.Core.Interfaces
{
    public interface IGenericRepository<TEntity> where TEntity : class
    {
        TEntity GetById(int id);
        IEnumerable<TEntity> GetAll();
        IEnumerable<TEntity> Find(Expression<Func<TEntity, bool>> expression, string includeProperties = "");
        void Add(TEntity entity);
        void AddRange(IEnumerable<TEntity> entities);
        void Remove(TEntity entity);
        void RemoveRange(IEnumerable<TEntity> entities);

        //TEntity GetById(object id);
        //IEnumerable<TEntity> GetWithRawSql(string query, 
        //    params object[] parameters);
        //IEnumerable<TEntity> Get(
        //    Expression<Func<TEntity, bool>> filter = null,
        //    Func<IQueryable<TEntity>, IOrderedQueryable<TEntity>> orderBy = null,
        //    string includeProperties = "");
        //void Add(TEntity entity);
        //void Update(TEntity entityToUpdate);
        //void Delete(TEntity entityToDelete);
        //void Delete(object id);
    }
}
