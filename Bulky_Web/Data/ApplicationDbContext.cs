using Bulky_Web.Models;
using Microsoft.EntityFrameworkCore;

namespace Bulky_Web.Data
{
    public class ApplicationDbContext:DbContext
    {
        //ctor
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options):base(options)
        {
            
        }

        public DbSet<Category> Categories { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Category>().HasData(
                new Category { Id=1,Name="Action",DisplayOrder= "1"},
                new Category { Id=2, Name="Scifi", DisplayOrder= "2" },
                new Category { Id=3, Name="History", DisplayOrder= "3" }



                );

        }

    }
}
