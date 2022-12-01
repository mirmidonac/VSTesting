using Microsoft.EntityFrameworkCore;
using WebAPIApplication.Models.Domains;

namespace WebAPIApplication.Data
{
    public class WebAPIDBContext: DbContext
    {
       public WebAPIDBContext(DbContextOptions<WebAPIDBContext> options) : base(options) 
        {

        }
        public DbSet<Regions> Regions { get; set; }
        public DbSet <Walk> Walks { get; set; }
        public DbSet <WalkDifficulty> WalkDifficulty { get; set; }  

        public DbSet<Person> Person { get; set; }

    }
}
