using Epam.Task06.Users.DAL.Interface;
using Epam.Task06.Users.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Epam.Task06.Users.DAL
{
    public class UserFakeDao : IUserDao
    {
        private static readonly Dictionary<int, User> _repoUsers = new Dictionary<int, User>();

        public void Add(User user)
        {
            var lastId = _repoUsers.Any()
                ? _repoUsers.Keys.Max()
                : 0;

            user.Id = ++lastId;

            _repoUsers.Add(user.Id, user);
        }

        public bool Delete(int id)
        {
            return _repoUsers.Remove(id);
        }

        public bool Update(User user)
        {
            if (!_repoUsers.ContainsKey(user.Id))
            {
                return false;
            }

            _repoUsers[user.Id] = user;
            return true;
        }

        public User GetById(int id)
        {
            return _repoUsers.TryGetValue(id, out var user)
                ? user
                : null;
        }

        public IEnumerable<User> GetAll()
        {
            return _repoUsers.Values;
        }

        public void SaveUsersList()
        {
            Console.WriteLine("This is FakeDao, list can not be saved");
        }
    }
}
