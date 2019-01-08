using Epam.Task06.Users.BLL.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Epam.Task06.Users
{
    public class CacheLogic: ICacheLogic
    {
        private static Dictionary<string, object> _data = new Dictionary<string, object>();

        public bool Add<T>(string key, T value)
        {
            if (_data.ContainsKey(key))
            {
                return false;
            }

            _data.Add(key, value);
            return true;
        }

        public T Get<T>(string key)
        {
            if (!_data.ContainsKey(key))
            {
                return default(T);
            }

            return (T)_data[key];
        }

        public bool Delete(string key)
        {
            return _data.Remove(key);
        }
    }
}
