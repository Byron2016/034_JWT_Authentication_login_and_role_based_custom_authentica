using Microsoft.EntityFrameworkCore;

namespace LoginDemo.Models
{
    public static class ModelBuilderExtensions
    {
        public static void Seed(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<UserTest>(entity =>
            {
                entity.HasData(
                    new UserTest
                    {
                        Id = 11,
                        Name = "a11",
                        Email = "a11.yahoo.com",
                        Password = "b"
                    },
                    new UserTest
                    {
                        Id = 12,
                        Name = "a2",
                        Email = "a212.yahoo.com",
                        Password = "b2"
                    }
                    );
            });
        }
    }
}
