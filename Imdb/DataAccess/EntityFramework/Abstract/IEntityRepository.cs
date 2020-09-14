using System;
using Entities.Entities;
using System.Linq.Expressions;
using System.Collections.Generic;

namespace Entities.EntityFramework.Abstract
{
    public interface IEntityRepository<T> where T : class, IEntity, new()
    {
        void Add(T entity);
        void Update(T entity);
        void Delete(T entity);
        T Get(Expression<Func<T, bool>> filter);
        IList<T> Gets(Expression<Func<T, bool>> filter = null);
    }
}