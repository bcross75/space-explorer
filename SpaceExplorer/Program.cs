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
                if (inputs[0] == "walk")
                {
                    var direction = inputs[1];
                    if (direction == "left" || direction == "right")
                    {
                        Console.WriteLine($"Walking {direction}");
                    }
                    else
                    {
                        Console.WriteLine("I only walk left and right");
                    }

                }
                else if (userinput == "quit")
                {
                    exit = true;
                }
                else if (userinput == "fire")
                {
                    Console.WriteLine("Suns Out Guns Out");
                }

                else
                {
                    Console.WriteLine("I don't understand " + userinput + "!");
                    Console.WriteLine($"I don't understand {userinput}!");

                    var builder = new StringBuilder();
                    builder.Append("I don't understand ");
                    builder.Append(userinput);
                    builder.Append("!");

                    Console.WriteLine(builder.ToString());
                }
               
            } while (exit == false);
        }
    }
}
