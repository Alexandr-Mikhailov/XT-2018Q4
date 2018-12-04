using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Epam.Task02.Employee
{
    public class User
    {
        private string tempstring;

        public User(string surename, string name, string patronym, DateTime birthdate)
        {
            if (DateTime.Compare(birthdate, DateTime.Now) > 0)
            {
                throw new Exception("Date of birth is not correct");
            }
            else
            {
                this.tempstring = surename.Trim();
                if (this.tempstring.Length == 0)
                {
                    throw new Exception("Surename can not be blank");
                }
                else
                {
                    this.Surename = surename;
                    this.tempstring = name.Trim();
                    if (this.tempstring.Length == 0)
                    {
                        throw new Exception("Name can not be blank");
                    }
                    else
                    {
                        this.Name = name;
                        this.tempstring = patronym.Trim();
                        if (this.tempstring.Length == 0)
                        {
                            throw new Exception("Patronym can not be blank");
                        }
                        else
                        {
                            this.Patronym = patronym;
                            this.Birthdate = birthdate;
                            this.Age = DateTime.Now.Year - this.Birthdate.Year;
                        }
                    }
                }
            }
        }

        public string Surename { get; set; }

        public string Name { get; set; }

        public string Patronym { get; set; }

        public DateTime Birthdate { get; set; }

        public int Age { get; set; }
    }
}
