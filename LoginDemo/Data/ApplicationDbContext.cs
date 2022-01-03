using LoginDemo.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace LoginDemo.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }

        public DbSet<UserTest> UserTests { set; get; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder); //Es necesasrio para identity que sepa construir el model builder 
            modelBuilder.Entity<UserTest>(entity =>
            {
                //entity.HasData(
                //    new UserTest
                //    {
                //        Id = 1,
                //        Name = "a",
                //        Email = "a.yahoo.com",
                //        Password = "b"
                //    }
                //    );
            });
            modelBuilder.Seed();
        }
    }
}
