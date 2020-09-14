using System;
using Business.Abstract;
using Entities.Concrete;
using System.Linq.Expressions;
using System.Collections.Generic;
using Entities.Concreate.EntityFramework;
using Entities.Concreate.EntityFramework.Context;

namespace Business.Concreate
{
    public class MovieManager : IBusinessService<Movie>
    {
        private EfMovieDal _efMovieDal;

        public MovieManager(Context context)
        {
            _efMovieDal = new EfMovieDal(context);
        }

        public void Add(Movie entity)
        {
            _efMovieDal.Add(entity);
        }

        public void Delete(Guid id, Guid userId)
        {
            var entity = Get(x => x.Id == id);
            entity.isActive = false;
            entity.EditedBy = userId;
            entity.EditedDate = DateTime.Now;
            _efMovieDal.Update(entity);
        }

        public Movie Get(Expression<Func<Movie, bool>> filter)
        {
            return _efMovieDal.Get(filter);
        }

        public IList<Movie> Gets(Expression<Func<Movie, bool>> filter = null)
        {
            return _efMovieDal.Gets(filter);
        }

        public void Update(Movie entity)
        {
            _efMovieDal.Update(entity);
        }
    }
}
