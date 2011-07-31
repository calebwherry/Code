// Caleb Wherry
// CSCI 3005 - Assignment #2
// February 12th, 2008

using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace Wherry2
{
    class Program
    {
        static string choice;
    
        public static void Main(string[] args)
        {
            Console.Title = "Town House Banking";
            Console.ForegroundColor = ConsoleColor.Green;

            Customer[] customerArr = new Customer[3];
            for (int i = 0; i < 3; i++)
                customerArr[i] = new Customer();

            do
            {
                mainMenu();

                choice = Console.ReadLine().ToUpper();

                switch (choice)
                {
                    case "C":
                        Console.Clear();
                        break;
                    case "D":
                        Console.Clear();
                        break;
                    case "I":
                        Console.Clear();
                        break;
                    case "S":
                        Console.Clear();
                        break;
                    case "Q":
                        Console.WriteLine();
                        Console.WriteLine("Thank you for using Town House Banking!");
                        Thread.Sleep(2000);
                        break;
                    default:
                        Console.WriteLine();
                        Console.WriteLine("Invalid choice. Try again...");
                        Thread.Sleep(2000);
                        Console.Clear();
                        break;
                }
            } while (choice != "Q");
        }

        public static void mainMenu()
        {
            Console.WriteLine("******************");
            Console.WriteLine("[C]reate Customer");
            Console.WriteLine("[D]elete Customer");
            Console.WriteLine("d[I]splay");
            Console.WriteLine("[S]ervices");
            Console.WriteLine("[Q]uit");
            Console.WriteLine("******************");
            Console.WriteLine();
            Console.Write("Choice: ");
        }

        public static void customerMenu()
        {
            Console.WriteLine("****************");
            Console.WriteLine("[C]hecking");
            Console.WriteLine("[S]et Pin");
            Console.WriteLine("s[H]ow Accounts");
            Console.WriteLine("[R]eturn");
            Console.WriteLine("****************");
            Console.WriteLine();
            Console.Write("Choice: ");
        }

        public static void checkingMenu()
        {
            Console.WriteLine("***********");
            Console.WriteLine("[0]pen");
            Console.WriteLine("[C]lose");
            Console.WriteLine("[I]nquire");
            Console.WriteLine("[D]eposit");
            Console.WriteLine("[W]ithdraw");
            Console.WriteLine("[R]eturn");
            Console.WriteLine("***********");
            Console.WriteLine();
            Console.Write("Choice: ");
        }
    }
}