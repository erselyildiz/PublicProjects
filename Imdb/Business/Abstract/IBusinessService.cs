using System;
using Entities.Entities;
using System.Linq.Expressions;
using System.Collections.Generic;
using Microsoft.AspNetCore.Identity;

namespace Business.Abstract
{
    public interface IBusinessService<T> where T : class, IEntity
    {
        void Add(T entity);
        void Update(T entity);
        void Delete(Guid id, Guid userId);
        T Get(Expression<Func<T, bool>> filter);
        IList<T> Gets(Expression<Func<T, bool>> filter = null);
    }
}