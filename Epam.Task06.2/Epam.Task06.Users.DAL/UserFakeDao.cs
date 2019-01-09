using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Epam.Task06.Users.DAL.Interface;
using Epam.Task06.Users.Entities;

namespace Epam.Task06.Users.DAL
{
    public class UserFakeDao : IUserDao
    {
        private static readonly Dictionary<int, User> RepoUsers = new Dictionary<int, User>();

        public void Add(User user)
        {
            var lastId = RepoUsers.Any()
                ? RepoUsers.Keys.Max()
                : 0;

            user.Id = ++lastId;

            RepoUsers.Add(user.Id, user);
        }

        public bool Delete(int id)
        {
            return RepoUsers.Remove(id);
        }

        public bool Update(User user)
        {
            if (!RepoUsers.ContainsKey(user.Id))
            {
                return false;
            }

            RepoUsers[user.Id] = user;
            return true;
        }

        public User GetById(int id)
        {
            return RepoUsers.TryGetValue(id, out var user)
                ? user
                : null;
        }

        public IEnumerable<User> GetAll()
        {
            return RepoUsers.Values;
        }

        public void SaveUsersList()
        {
            Console.WriteLine("This is FakeDao, list can not be saved");
        }

        public void AddAward(User user, Award award)
        {
            if (RepoUsers[user.Id].Awards.ContainsKey(award.Id))
            {
                throw new Exception($"User already has award {award.Id} {award.Title}");
            }
            else
            {
                RepoUsers[user.Id].Awards.Add(award.Id, award);
            }
        }

        public IEnumerable<Award> GetAllAwards(User user)
        {
            {
                return RepoUsers[user.Id].Awards.Values;
            }
        }
    }
}
