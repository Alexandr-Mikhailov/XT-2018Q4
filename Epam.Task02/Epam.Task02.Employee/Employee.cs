using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Epam.Task02.Employee
{
    public class Employee : User
    {
        private string tempstring;

        public Employee(string surename, string name, string patronym, DateTime birthdate, string position, int lengthofwork) :
            base(surename, name, patronym, birthdate)
        {
            this.tempstring = position.Trim();
            if (this.tempstring.Length == 0)
            {
                throw new Exception("Position can not be blank");
            }
            else
            {
                this.Position = position;
                if (lengthofwork < 0)
                {
                    throw new Exception("Length of work can not be less than zero");
                }
                else
                {
                    if ((this.Age < 18) || ((this.Age - lengthofwork) < 18))
                    {
                        throw new Exception("Length of work is not correct");
                    }
                    else
                    {
                        this.LengthOfWork = lengthofwork;
                    }
                }
            }
        }

        public string Position { get; set; }

        public int LengthOfWork { get; set; }
    }
}
