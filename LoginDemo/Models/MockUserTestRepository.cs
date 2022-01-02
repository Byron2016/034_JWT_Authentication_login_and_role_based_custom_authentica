using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LoginDemo.Models
{
    public class MockUserTestRepository : IUserTestRepository
    {
        private List<UserTest> _userTestList;

        public MockUserTestRepository()
        {
            _userTestList = new List<UserTest>()
            {
                new UserTest() { Id = 1, Name = "Mary", Email = "mary@yahoo.com", Password = "marypas" },
                new UserTest() { Id = 2, Name = "John", Email = "john@yahoo.com", Password = "johnpas" },
                new UserTest() { Id = 3, Name = "Sam", Email = "sam@yahoo.com", Password = "sampas" },
            };
        }
        public UserTest Add(UserTest userTest)
        {
            userTest.Id = _userTestList.Max(e => e.Id) + 1;
            _userTestList.Add(userTest);
            return userTest;
        }

        public UserTest Delete(int id)
        {
            UserTest userTest = _userTestList.FirstOrDefault(e => e.Id == id);
            if(userTest != null)
            {
                _userTestList.Remove(userTest);
            }
            return userTest;
        }

        public IEnumerable<UserTest> GetAllUserTest()
        {
            return _userTestList;
        }

        public UserTest GetUserTest(int id)
        {
            return _userTestList.FirstOrDefault(e => e.Id == id);
        }

        public UserTest Update(UserTest userTestChanges)
        {
            UserTest userTest = _userTestList.FirstOrDefault(e => e.Id == userTestChanges.Id);
            if (userTest != null)
            {
                userTest.Name = userTestChanges.Name;
                userTest.Email = userTestChanges.Email;
                userTest.Password = userTestChanges.Password;
            }
            return userTest;
        }
    }
}
