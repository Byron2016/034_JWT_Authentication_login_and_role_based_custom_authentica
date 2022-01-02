using LoginDemo.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LoginDemo.Models
{
    public class MySqlUserTestRepository : IUserTestRepository
    {
        private readonly ApplicationDbContext context;

        public MySqlUserTestRepository(ApplicationDbContext context)
        {
           this.context = context;
        }
        public UserTest Add(UserTest userTest)
        {
            context.UserTests.Add(userTest);
            context.SaveChanges();
            return userTest;
        }

        public UserTest Delete(int id)
        {
            UserTest userTest = context.UserTests.Find(id);
            if(userTest != null)
            {
                context.UserTests.Remove(userTest);
                context.SaveChanges();
            }
            
            return userTest;
        }

        public IEnumerable<UserTest> GetAllUserTest()
        {
            return context.UserTests;
        }

        public UserTest GetUserTest(int id)
        {
            return context.UserTests.Find(id);
        }

        public UserTest Update(UserTest userTestChanges)
        {
            var userTest = context.UserTests.Attach(userTestChanges);
            userTest.State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            context.SaveChanges();

            return userTestChanges;
        }
    }
}
