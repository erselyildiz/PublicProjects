using Entities.Concrete;
using Entities.Abstract;
using Core.DataAccess.EntityFramework;

namespace Entities.Concreate.EntityFramework
{
    public class EfMovieDal : EfEntityRepositoryBase<Movie>, IMovieDal
    {
        public EfMovieDal(Context.Context context) : base(context)
        {

        }
    }
}