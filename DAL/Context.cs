using Microsoft.EntityFrameworkCore;
using Select_Option_Relations.Models;

namespace Select_Option_Relations.DAL
{
    public class Context:DbContext
    {
        public Context(DbContextOptions<Context> options) : base(options)
        {

        }

        public DbSet<Brands> Brands { get; set; }
        public DbSet<Modelss> Models { get; set; }
       
    }
}
