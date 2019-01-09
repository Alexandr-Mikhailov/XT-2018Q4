using System.Collections.Generic;
using Epam.Task06.Users.Entities;

namespace Epam.Task06.Users.DAL.Interface
{
    public interface IUserDao
    {
        void Add(User user);

        void AddAward(User user, Award award);

        bool Delete(int id);

        IEnumerable<User> GetAll();

        IEnumerable<Award> GetAllAwards(User user);

        User GetById(int id);

        bool Update(User user);

        void SaveUsersList();
    }
}