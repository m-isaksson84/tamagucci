using System;
using System.Collections.Generic;

namespace tamagucci
{
    class Program
    {
        static void Main(string[] args)
        {

            Tamagotchi requirements = new Tamagotchi();

            while (requirements.GetAlive())
            {
                requirements.PrintStats();
                Console.WriteLine("Actions " + requirements.name);
                Console.WriteLine("1: Ge mat");
                Console.WriteLine("2: Lär ord");
                Console.WriteLine("3: Lista på lärda ord");
                string action = Console.ReadLine();
                Console.Clear();

                if (action == "1")
                {
                    Console.Clear();
                    requirements.Feed();

                }
            }
        }
    }
}
