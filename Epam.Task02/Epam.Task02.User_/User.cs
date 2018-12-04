using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Epam.Task02.User_
{
    public class User
    {
        public User(string surename, string name, string patronym, DateTime birthdate)
        {
            if (DateTime.Compare(birthdate, DateTime.Now) > 0)
            {
                throw new Exception("Date of birth is not correct");
            }
            else
            {
                this.Surename = surename;
                this.Name = name;
                this.Patronym = patronym;
                this.Birthdate = birthdate;
                this.Age = DateTime.Now.Year - this.Birthdate.Year;
            }
        }

        public string Surename { get; set; }

        public string Name { get; set; }

        public string Patronym { get; set; }

        public DateTime Birthdate { get; set; }

        public int Age { get; set; }
    }
}
