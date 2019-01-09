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
                            AddAwardToUser(userLogic);
                            break;
                        }

                    case "5":
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
            Console.WriteLine("3 - to show users");
            Console.WriteLine("4 - to add award to user");
            Console.WriteLine("5 - to save user list to file");
            Console.WriteLine("q - to quit program");
        }

        private static void ShowUsers(IUserLogic userLogic)
        {
            Console.WriteLine("ID Name Date of birth Age");

            foreach (var user in userLogic.GetAll())
            {
                Console.WriteLine(user);

                if (userLogic.GetAllAwards(user).Count() == 0)
                {
                    Console.WriteLine("User has no awards");
                }
                else
                {
                    Console.WriteLine("User has award(s)");

                    foreach (var award in userLogic.GetAllAwards(user))
                    {
                        Console.WriteLine($"{award.Id} {award.Title}");
                    }
                }
            }

            Console.WriteLine();
        }

        private static void AddAwardToUser(IUserLogic userLogic)
        {
            string input;

            Console.WriteLine("input user Id to take award");
            input = Console.ReadLine();

            if (!int.TryParse(input, out int userId) || userId < 0)
            {
                Console.WriteLine("user Id is not correct");
            }
            else
            {
                Console.WriteLine("input Id of award");
                input = Console.ReadLine();

                if (!int.TryParse(input, out int awardId) || awardId < 0)
                {
                    Console.WriteLine("award Id is not correct");
                }
                else
                {
                    Console.WriteLine("input Title of award");
                    input = Console.ReadLine();

                    var user = new User
                    {
                        Id = userId,
                    };

                    var award = new Award
                    {
                        Id = awardId,
                        Title = input,
                    };

                    userLogic.AddAward(user, award);
                }
            }
        }

        private static void SaveUsers(IUserLogic userLogic)
        {
            userLogic.SaveUsersList();

            Console.WriteLine("User list saved");
        }
    }
}
