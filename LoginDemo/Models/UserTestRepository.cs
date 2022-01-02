using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LoginDemo.Models
{
    public class UserTestRepository : IUserTestRepository
    {
        public UserTest Add(UserTest userTest)
        {
            throw new NotImplementedException();
        }

        public UserTest Delete(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<UserTest> GetAllUserTest()
        {
            throw new NotImplementedException();
        }

        public UserTest GetUserTest(int id)
        {
            throw new NotImplementedException();
        }

        public UserTest Update(UserTest userTestChanges)
        {
            throw new NotImplementedException();
        }
    }
}
