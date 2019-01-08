using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Epam.Task06.Users.BLL;
using Epam.Task06.Users.BLL.Interface;
using Epam.Task06.Users.DAL;
using Epam.Task06.Users.DAL.Interface;

namespace Epam.Task06.Users.Common
{
    public static class DependencyResolver
    {
        private static IUserDao userdao;
        private static IUserLogic userlogic;
        private static ICacheLogic cachelogic;

        public static IUserDao UserDao
        {
            get
            {
                var key = ConfigurationManager.AppSettings["DaoUserKey"];

                if (userdao == null)
                {
                    switch (key.ToLower())
                    {
                        case "text":
                            {
                                userdao = new UserTextFileDao();
                                break;
                            }

                        case "memory":
                            {
                                userdao = new UserFakeDao();
                                break;
                            }

                        default:
                            break;
                    }
                }

                return userdao;
            }
        }

        public static IUserLogic UserLogic => userlogic ?? (userlogic = new UserLogic(UserDao, CacheLogic));

        public static ICacheLogic CacheLogic => cachelogic ?? (cachelogic = new CacheLogic());
    }
}
