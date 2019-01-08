using Epam.Task06.Users.DAL.Interface;
using Epam.Task06.Users.Entities;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Epam.Task06.Users.DAL
{
    public class UserTextFileDao : IUserDao
    {
        private const char Space = '|';
        private const string TextFile = "users.txt";

        private static readonly Dictionary<int, User> _repoUsers = new Dictionary<int, User>();

        public UserTextFileDao()
        {
            ReadUsersFromFile();
        }

        private void ReadUsersFromFile()
        {
            if (!File.Exists(Directory.GetCurrentDirectory() + "\\" + TextFile))
            {
                using (StreamWriter textFile = File.CreateText(Directory.GetCurrentDirectory() + "\\" + TextFile))
                {
                }
            }

            using (StreamReader textFile = new StreamReader(Directory.GetCurrentDirectory() + "\\" + TextFile))
            {
                while (!textFile.EndOfStream)
                {
                    string[] userName = textFile.ReadLine().Split(new char[] { Space });

                    if (_repoUsers.ContainsKey(int.Parse(userName[0])))
                    {
                        throw new Exception("Duplicate keys in textfile");
                    }
                    else
                    {
                        var user = new User();
                        user.Id = int.Parse(userName[0]);
                        user.Name = userName[1];
                        user.DateOfBirth = DateTime.Parse(userName[2]);

                        _repoUsers.Add(user.Id, user);
                    }
                }
            }
        }

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
            if (!File.Exists(Directory.GetCurrentDirectory() + "\\" + TextFile))
            {
                using (StreamWriter textFile = File.CreateText(Directory.GetCurrentDirectory() + "\\" + TextFile))
                {
                }
            }

            using (StreamWriter textFile = File.CreateText(Directory.GetCurrentDirectory() + "\\" + TextFile))
            {
                foreach (var item in _repoUsers)
                {
                    var sb = new StringBuilder();

                    sb.Append(item.Value.Id.ToString());
                    sb.Append(Space);
                    sb.Append(item.Value.Name);
                    sb.Append(Space);
                    sb.Append(item.Value.DateOfBirth.ToShortDateString().ToString());
                    sb.Append(Space);
                    sb.Append(item.Value.Age.ToString());

                    textFile.WriteLine(sb.ToString());
                }
            }
        }
    }
}
