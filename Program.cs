﻿using System;

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
                Console.WriteLine("\nHello, " + name + "! You are not as bad is I thought you were!");

                Console.Write("Do you want to loop this program again?: ");
                exit = Console.ReadLine();
            }                       
            Environment.Exit(0);
        }
    }
}
