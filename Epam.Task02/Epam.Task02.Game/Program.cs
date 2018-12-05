using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Epam.Task02.Game
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int width = 20;
            int heght = 30;
            string input;
            Field field = new Field(width, heght);

            Monster wolf = new Monster("wolf", 1, 1);
            Monster bear = new Monster("bear", width, heght);

            Hero hero = new Hero("Hero", width / 2, heght / 2);

            Obstacle rock = new Obstacle("rock", 10, 5);

            Bonus cherry = new Bonus("cherry", 5, 5);
            Bonus apple = new Bonus("apple", 10, 10);

            while (!(hero.Health == 0))
            {
                Console.WriteLine($"{wolf.Type} coord is {wolf.X} {wolf.Y} {bear.Type} coord is {bear.X} {bear.Y}");
                Console.WriteLine($"{hero.Type} coord is {hero.X} {hero.Y}, hero helth is {hero.Health}");
                Console.WriteLine("Type 1 to move right, 2 to move left, 3 to move up, 4 to move down");

                if ((hero.X == wolf.X) && (hero.Y == wolf.Y))
                {
                    hero.Health += wolf.AddHealth;
                }

                if ((hero.X == bear.X) && (hero.Y == bear.Y))
                {
                    hero.Health += bear.AddHealth;
                }

                if (apple.Show)
                {
                    Console.WriteLine($"{apple.Type} coord is {apple.X} {apple.Y}");
                }
                else
                {
                    if (cherry.Show)
                    {
                        Console.WriteLine($"{cherry.Type} coord is {cherry.X} {cherry.Y}");
                    }
                    else
                    {
                        break;
                    }
                }

                if ((hero.X == cherry.X) && (hero.Y == cherry.Y))
                {
                    cherry.Show = false;
                    hero.Health += cherry.AddHealth;
                }

                if ((hero.X == apple.X) && (hero.Y == apple.Y))
                {
                    apple.Show = false;
                    hero.Health += apple.AddHealth;
                }

                input = Console.ReadLine();
                hero.Step = int.Parse(input);
                hero.Move();
                wolf.Move();
                bear.Move();
            }

            if (hero.Health == 0)
            {
                Console.WriteLine("You lose");
            }
            else
            {
                Console.WriteLine("You win");
            }
        }
    }
}
