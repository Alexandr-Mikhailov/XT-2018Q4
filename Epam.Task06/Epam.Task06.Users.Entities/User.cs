using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Epam.Task06.Users.Entities
{
    public class User
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public DateTime DateOfBirth { get; set; }

        public int Age
        {
            get
            {
                return DateTime.Now.Year - DateOfBirth.Year;
            }
        }

        public override string ToString()
        {
            return $"{this.Id} {this.Name} {this.DateOfBirth.ToShortDateString()} {this.Age}";
        }
    }
}
