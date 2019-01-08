using System.Collections.Generic;
using Epam.Task06.Users.Entities;

namespace Epam.Task06.Users.DAL.Interface
{
    public interface IUserDao
    {
        void Add(User user);

        bool Delete(int id);

        IEnumerable<User> GetAll();

        User GetById(int id);

        bool Update(User user);

        void SaveUsersList();
    }
}