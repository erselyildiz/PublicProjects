using Core.DataAccess;
using Entities.Concrete;
using Entities.EntityFramework.Abstract;

namespace Entities.Abstract
{
    public interface IMovieDal: IEntityRepository<Movie>
    {
    }
}
