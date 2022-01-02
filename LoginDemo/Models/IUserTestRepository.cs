using System.Collections.Generic;

namespace LoginDemo.Models
{
    public interface IUserTestRepository
    {
        UserTest GetUserTest(int id);
        IEnumerable<UserTest> GetAllUserTest();

        UserTest Add(UserTest userTest);

        UserTest Update(UserTest userTestChanges);

        UserTest Delete(int id);
    }
}
