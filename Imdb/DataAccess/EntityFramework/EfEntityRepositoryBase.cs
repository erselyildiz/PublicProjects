using System;
using System.Linq;
using Entities.Entities;
using System.Linq.Expressions;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Entities.EntityFramework.Abstract;
using Entities.Concreate.EntityFramework.Context;

namespace Core.DataAccess.EntityFramework
{
    public class EfEntityRepositoryBase<TEntity> : IEntityRepository<TEntity> where TEntity : class, IEntity, new()
    {
        private Context _context;

        public EfEntityRepositoryBase(Context context)
        {
            _context = context;
        }

        public void Add(TEntity entity)
        {
            var thisEntity = _context.Entry(entity);
            thisEntity.State = EntityState.Added;
            _context.SaveChanges();
            _context.Dispose();
        }

        public void Delete(TEntity entity)
        {
            var thisEntity = _context.Entry(entity);
            thisEntity.State = EntityState.Deleted;
            _context.SaveChanges();
            _context.Dispose();
        }

        public void Update(TEntity entity)
        {
            var thisEntity = _context.Entry(entity);
            thisEntity.State = EntityState.Modified;
            _context.SaveChanges();
            _context.Dispose();
        }

        public TEntity Get(Expression<Func<TEntity, bool>> filter)
        {
            var entity = _context.Set<TEntity>().SingleOrDefault(filter);
            _context.Dispose();
            return entity;
        }

        public IList<TEntity> Gets(Expression<Func<TEntity, bool>> filter = null)
        {
            var entities = filter == null ? _context.Set<TEntity>().ToList() : _context.Set<TEntity>().Where(filter).ToList();
            _context.Dispose();
            return entities;
        }
    }
}