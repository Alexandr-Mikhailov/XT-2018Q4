using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Epam.Task02.User_
{
    public class Program
    {
        public static void Main(string[] args)
        {
            string name, surename, patronym;
            string namestring = "Name";
            string surenamestring = "Surename";
            string patronymstring = "Patronym";
            string yearstring = "Year";
            string monthstring = "Month";
            string daystring = "Day";

            int year, month, day;

            name = Input(namestring);
            surename = Input(surenamestring);
            patronym = Input(patronymstring);

            do
            {
                if (int.TryParse(Input(yearstring), out year))
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Incorrect input of year");
                }
            }
            while (true);

            do
            {
                if (int.TryParse(Input(monthstring), out month))
                {
                    if ((month > 0) && (month < 13))
                    {
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Incorrect number of month");
                    }
                }
            }
            while (true);

            do
            {
                if (int.TryParse(Input(daystring), out day))
                {
                    if ((day > 0) && (day <= DateTime.DaysInMonth(year, month)))
                    {
                        break;
                    }
                    else
                    {
                        Console.WriteLine($"Incorrect day of {month} month");
                    }
                }
            }
            while (true);

            DateTime birthdate = new DateTime(year, month, day);

            try
            {
                User person = new User(surename, name, patronym, birthdate);

                Console.WriteLine("Surename is {0}", person.Surename);
                Console.WriteLine("Name is {0}", person.Name);
                Console.WriteLine("Patronym is {0}", person.Patronym);
                Console.WriteLine("Birthdate is {0}", person.Birthdate.ToShortDateString());
                Console.WriteLine("Age is {0}", person.Age);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        public static string Input(string text)
        {
            string tempstring;

            do
            {
                Console.WriteLine($"Input {text}");
                tempstring = Console.ReadLine();
                tempstring = tempstring.Trim();

                if (!(tempstring.Length == 0))
                {
                    break;
                }
                else
                {
                    Console.WriteLine($"{text} can not be blank");
                }
            }
            while (true);

            return tempstring;
        }
    }
}
