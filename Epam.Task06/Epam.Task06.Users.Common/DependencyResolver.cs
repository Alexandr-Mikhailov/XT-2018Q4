using Epam.Task06.Users.BLL;
using Epam.Task06.Users.BLL.Interface;
using Epam.Task06.Users.DAL;
using Epam.Task06.Users.DAL.Interface;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Epam.Task06.Users.Common
{
    public static class DependencyResolver
    {
        private static IUserDao _userDao;

        public static IUserDao UserDao
        {
            get
            {
                var key = ConfigurationManager.AppSettings["DaoUserKey"];

                if(_userDao == null)
                {
                    switch (key.ToLower())
                    {
                        case "text":
                            {
                                _userDao = new UserTextFileDao();
                                break;
                            }
                        case "memory":
                            {
                                _userDao = new UserFakeDao();
                                break;
                            }
                        default:
                            break;
                    }
                }

                
                return _userDao;
            }
        }

        private static IUserLogic _userLogic;

        public static IUserLogic UserLogic => _userLogic ?? (_userLogic = new UserLogic(UserDao, CacheLogic));

        private static ICacheLogic _cacheLogic;

        public static ICacheLogic CacheLogic => _cacheLogic ?? (_cacheLogic = new CacheLogic());
    }
}
