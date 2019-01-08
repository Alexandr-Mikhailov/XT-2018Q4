using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Epam.Task06.Users.Entities
{
    public class Award
    {
        public int Id { get; set; }

        public string Title { get; set; }

        public override string ToString()
        {
            return $"{this.Id} {this.Title}";
        }
    }
}
