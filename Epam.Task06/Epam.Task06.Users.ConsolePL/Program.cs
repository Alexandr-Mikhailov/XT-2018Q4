using Epam.Task06.Users.BLL.Interface;
using Epam.Task06.Users.Common;
using Epam.Task06.Users.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Epam.Task06.Users.ConsolePL
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var userLogic = DependencyResolver.UserLogic;
            string input;

            ShowMenu();

            do
            {
                input = Console.ReadLine();

            }
            while (input != "q");
        }

        private static void AddUser(IUserLogic userLogic)
        {
            var user = new User
            {
                Name = "John",
                DateOfBirth = DateTime.Now,
            };

            userLogic.Add(user);
        }

        private static void ShowMenu()
        {
            Console.WriteLine("Please type command");
            Console.WriteLine("1 - to add user");
            Console.WriteLine("2 - to delete user");
            Console.WriteLine("3 - to show users");
            Console.WriteLine("4 - to save user list to file");
            Console.WriteLine("q - to quit program");
        }

        private static void ShowUsers(IUserLogic userLogic)
        {
            foreach (var user in userLogic.GetAll())
            {
                Console.WriteLine(user);
            }
            Console.WriteLine();
        }

        private static void SaveUsers(IUserLogic userLogic)
        {
            userLogic.SaveUsersList();
        }
    }
}
