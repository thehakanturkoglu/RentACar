using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;


namespace Core.DataAccess
{
    public interface IEntityRepository<TEntity> where TEntity: class, IEntity, new()
    {
        TEntity Get(Expression<Func<TEntity, bool>> filter);
        List<TEntity> GetAll(Expression<Func<TEntity,bool>> filter = null);
        void Add(TEntity entity);
        void Update(TEntity entity);
        void Delete(TEntity entity);
    }
}
