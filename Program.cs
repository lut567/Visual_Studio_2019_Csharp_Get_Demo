using System;

namespace Visual_Studio_2019_Csharp_Get_Demo
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = "";
            String exit = "Yes";

            Console.WriteLine("Hopefuly I remember how to code in C#.");

            while (exit == "Yes" || exit == "yes" || exit == "Y" || exit == "y")
            {
                Console.WriteLine("\nHello World!");

                
                Console.Write("What is your name?: ");
                name = Console.ReadLine();

                while (name == "")
                {
                    Console.Write("Really now? What is your name: ");
                    name = Console.ReadLine();
                    if (name == "")
                    {
                        Console.WriteLine("Well OK then, since you dont want to play along...");
                        Environment.Exit(0);
                    }
                    else
                    {
                        Console.WriteLine("\nHello, " + name + "! You are not as bad is I thought you were!\n");
                    }
                }
                Console.Write("Do you want to loop this program again?: ");
                exit = Console.ReadLine();
            }                       
            Environment.Exit(0);
        }
    }
}
