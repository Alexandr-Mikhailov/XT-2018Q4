using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Epam.Task02.Employee
{
    public class Program
    {
        public static void Main(string[] args)
        {
            string name, surename, patronym, position;
            int year, month, day, lengthofwork;

            Console.WriteLine("Input name");
            name = Console.ReadLine();

            Console.WriteLine("Input surename");
            surename = Console.ReadLine();

            Console.WriteLine("Input patronym");
            patronym = Console.ReadLine();

            Console.WriteLine("Input year of birth");
            year = int.Parse(Console.ReadLine());

            Console.WriteLine("Input month of birth");
            month = int.Parse(Console.ReadLine());

            Console.WriteLine("Input day of birth");
            day = int.Parse(Console.ReadLine());

            DateTime dateofbirth = new DateTime(year, month, day);

            Console.WriteLine("Input position");
            position = Console.ReadLine();

            Console.WriteLine("Input length of work");
            lengthofwork = int.Parse(Console.ReadLine());

            try
            {
                Employee person = new Employee(surename, name, patronym, dateofbirth, position, lengthofwork);
                Console.WriteLine("Surename is {0}", person.Surename);
                Console.WriteLine("Name is {0}", person.Name);
                Console.WriteLine("Patronym is {0}", person.Patronym);
                Console.WriteLine("Birthdate is {0}", person.Birthdate.ToShortDateString());
                Console.WriteLine("Age is {0}", person.Age);
                Console.WriteLine("Position is {0}", person.Position);
                Console.WriteLine("Length of work is {0}", person.LengthOfWork);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
