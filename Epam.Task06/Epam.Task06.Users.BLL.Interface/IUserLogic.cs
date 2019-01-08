using Epam.Task06.Users.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Epam.Task06.Users.BLL.Interface
{
    public interface IUserLogic
    {
        void Add(User user);

        void Delete(int id);

        void Update(User user);

        User GetById(int id);

        IEnumerable<User> GetAll();

        void SaveUsersList();
    }
}
