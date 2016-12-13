using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpaceExplorer
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Space Explorer");
            bool exit = false;
            do
            {
                string userinput = Console.ReadLine().ToLower();
                var inputs = userinput.Split(' ');
                var action = inputs[0];

                var description = "";
                if (inputs.Length > 1)
                    description = inputs[1];

                string[] directions = new string[] { "left", "right", "forward", "back" };

                if (action == "walk")
                {
                    if (directions.Contains(description))
                    {
                        Console.WriteLine($"Walking {description}");
                    }
                    else
                    {
                        Console.WriteLine("I can't walk that way");
                    }
                }
                else if (action == "jump")
                {
                    if (directions.Contains(description))
                    {
                        Console.WriteLine($"Jumping {description}");
                    }
                    else
                    {
                        Console.WriteLine("I can't jump that way");
                    }
                }
                else if (userinput == "fire")
                {
                    Console.WriteLine("Kablooie!");
                }
                else if (action == "quit")
                {
                    exit = true;
                }
                else
                {
                    Console.WriteLine($"I don't understand {userinput}!");
                }
               
            } while (exit == false);
        }
    }
}
