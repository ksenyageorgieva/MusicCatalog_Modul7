using Ksenya_Modul7.Models;
using Microsoft.EntityFrameworkCore;

namespace MusicCatalog.Models
{

    public class MyDbContext : DbContext

    {
        public DbSet<Song> Songs { get; set; }
        public DbSet<Person> People { get; set; }

        //// protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        // {
        // //    optionsBuilder.UseInMemoryDatabase("MyDb");
        // }

        public MyDbContext(DbContextOptions<MyDbContext> options)
          : base(options)
        {

        }


        protected MyDbContext()
        {
        }


    }
   
}
