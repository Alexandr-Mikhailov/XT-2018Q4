using Epam.Task06.Users.BLL.Interface;
using Epam.Task06.Users.DAL.Interface;
using Epam.Task06.Users.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Epam.Task06.Users.BLL
{
    public class UserLogic: IUserLogic
    {
        private const string ALL_USERS_CACHE_KEY = "GetAllUsers";

        private readonly IUserDao _userDao;
        private readonly ICacheLogic _cacheLogic;

        public UserLogic(IUserDao userDao, ICacheLogic cacheLogic)
        {
            _userDao = userDao;
            _cacheLogic = cacheLogic;
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

            _cacheLogic.Delete(ALL_USERS_CACHE_KEY);
            _userDao.Add(user);
        }

        public void Delete(int id)
        {
            _userDao.Delete(id);
        }

        public void Update(User user)
        {
            _userDao.Update(user);
        }

        public User GetById(int id)
        {
            return _userDao.GetById(id);
        }

        public IEnumerable<User> GetAll()
        {
            var cacheResult = _cacheLogic.Get<IEnumerable<User>>(ALL_USERS_CACHE_KEY);

            if (cacheResult == null)
            {
                var result = _userDao.GetAll();
                _cacheLogic.Add(ALL_USERS_CACHE_KEY, result);

                return result;
            }

            return cacheResult;
        }

        public void SaveUsersList()
        {
            _userDao.SaveUsersList();
        }
    }
}
