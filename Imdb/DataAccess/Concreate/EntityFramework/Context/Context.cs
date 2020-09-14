using Entities.Concrete;
using Microsoft.EntityFrameworkCore;

namespace Entities.Concreate.EntityFramework.Context
{
    public class Context : DbContext
    {
        public Context(DbContextOptions<Context> options) : base(options) { }
        public DbSet<Movie> Movies { get; set; }
    }
}