using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Epam.Task06.Users.BLL.Interface;
using Epam.Task06.Users.Common;
using Epam.Task06.Users.Entities;

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

                switch (input)
                {
                    case "1":
                        {
                            AddUser(userLogic);
                            break;
                        }

                    case "2":
                        {
                            DeleteUser(userLogic);
                            break;
                        }

                    case "3":
                        {
                            ShowUsers(userLogic);
                            break;
                        }

                    case "4":
                        {
                            ShowAwards(userLogic);
                            break;
                        }

                    case "5":
                        {
                            AddAwardToList(userLogic);
                            break;
                        }

                    case "6":
                        {
                            AddAwardToUser(userLogic);
                            break;
                        }

                    case "7":
                        {
                            SaveUsers(userLogic);
                            break;
                        }

                    default: break;
                }
            }
            while (input.ToLower() != "q");

            SaveUsers(userLogic);
        }

        private static void AddUser(IUserLogic userLogic)
        {
            string input;

            Console.WriteLine("input user Name");
            input = Console.ReadLine();

            var user = new User();
            user.Name = input;

            Console.WriteLine("input user date of birth in format dd.mm.yyyy");
            input = Console.ReadLine();

            if (!DateTime.TryParse(input, out var datebirth) || datebirth > DateTime.Now)
            {
                Console.WriteLine("Date of birth is not correct");
            }
            else
            {
                user.DateOfBirth = datebirth;

                userLogic.Add(user);

                Console.WriteLine("User added");
                ShowMenu();
            }
        }

        private static void DeleteUser(IUserLogic userLogic)
        {
            string input;
            ShowUsers(userLogic);
            Console.WriteLine("Choose user Id to delete");
            input = Console.ReadLine();

            if (!int.TryParse(input, out var id) || userLogic.GetById(id) == null)
            {
                Console.WriteLine("User Id is not correct");
            }
            else
            {
                userLogic.Delete(id);

                Console.WriteLine("User deleted");
                ShowMenu();
            }
        }

        private static void ShowMenu()
        {
            Console.WriteLine("Please type command");
            Console.WriteLine("1 - to add user");
            Console.WriteLine("2 - to delete user");
            Console.WriteLine("3 - to show users with awards");
            Console.WriteLine("4 - to show awards list");
            Console.WriteLine("5 - to add award to awards list");
            Console.WriteLine("6 - to add award to user");
            Console.WriteLine("7 - to save user list to file");
            Console.WriteLine("q - to quit program");
        }

        private static void ShowUsers(IUserLogic userLogic)
        {
            Console.WriteLine("ID Name Date of birth Age");

            foreach (var user in userLogic.GetAll())
            {
                Console.WriteLine(user);
            }

            Console.WriteLine();
        }

        private static void ShowAwards(IUserLogic userLogic)
        {
        }

        private static void AddAwardToList(IUserLogic userLogic)
        {
        }

        private static void AddAwardToUser(IUserLogic userLogic)
        {
        }

        private static void SaveUsers(IUserLogic userLogic)
        {
            userLogic.SaveUsersList();

            Console.WriteLine("User list saved");
        }
    }
}
