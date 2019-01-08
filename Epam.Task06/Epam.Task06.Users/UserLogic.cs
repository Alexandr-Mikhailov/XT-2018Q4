using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Epam.Task06.Users.BLL.Interface;
using Epam.Task06.Users.DAL.Interface;
using Epam.Task06.Users.Entities;

namespace Epam.Task06.Users.BLL
{
    public class UserLogic : IUserLogic
    {
        private const string AllUsersCacheKEY = "GetAllUsers";

        private readonly IUserDao userdao;
        private readonly ICacheLogic cachelogic;

        public UserLogic(IUserDao userDao, ICacheLogic cacheLogic)
        {
            this.userdao = userDao;
            this.cachelogic = cacheLogic;
        }

        public void Add(User user)
        {
            try
            {
                if (user == null)
                {
                    throw new Exception("User is null");
                }
            }
            catch
            {
                throw;
            }

            this.cachelogic.Delete(AllUsersCacheKEY);
            this.userdao.Add(user);
        }

        public void Delete(int id)
        {
            this.userdao.Delete(id);
        }

        public void Update(User user)
        {
            this.userdao.Update(user);
        }

        public User GetById(int id)
        {
            return this.userdao.GetById(id);
        }

        public IEnumerable<User> GetAll()
        {
            var cacheResult = this.cachelogic.Get<IEnumerable<User>>(AllUsersCacheKEY);

            if (cacheResult == null)
            {
                var result = this.userdao.GetAll();
                this.cachelogic.Add(AllUsersCacheKEY, result);

                return result;
            }

            return cacheResult;
        }

        public void SaveUsersList()
        {
            this.userdao.SaveUsersList();
        }
    }
}
