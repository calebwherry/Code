// Caleb Wherry
// Assignment #1
// January 31, 2008
// Purpose: To show basic understanding of Visual C# in the .NET framework.

using System;
using System.Collections.Generic;
using System.Threading;
using System.Text;

namespace Wherry1
{
    class Program
    {            
        static void Main(string[] args)
        {
            Checking[] newAccount = new Checking[3];
            for (int i = 0; i < 3; i++)
                newAccount[i] = new Checking();

            string name;
            int pin, custCount = 0;
            double deposit, withdraw;
            bool found = false;

            char choice;

            do
            {
                Console.Title = "Town House Banking";
                Console.ForegroundColor = ConsoleColor.Green;

                tellerMenu();
                choice = Char.Parse(Console.ReadLine());
                choice = Char.ToUpper(choice);

                switch (choice)
                {
                    case 'O':
                        if (custCount >= 3)
                        {
                            Console.WriteLine();
                            Console.WriteLine("Too many customers exists! Please delete a customer before opening a new account!");
                            Thread.Sleep(2000);
                            Console.Clear();
                            break;
                        }

                        found = false;

                        Console.WriteLine();
                        Console.Write("Name On Account: ");
                        name = Console.ReadLine();

                        Console.Write("4-Digit Pin: ");
                        pin = Int32.Parse(Console.ReadLine());

                        foreach (Checking chk in newAccount)
                            if (chk.Pin == pin)
                                found = true;

                        if (found)
                        {
                            Console.WriteLine();
                            Console.WriteLine("That pin already exists! Please try again...");
                            Thread.Sleep(2000);
                            Console.Clear();
                            break;
                        }

                        Console.Write("Initial Deposit: ");
                        deposit = Double.Parse(Console.ReadLine());

                        foreach (Checking chk in newAccount)
                            if (chk.Name == "")
                            {
                                chk.Open(name, deposit, pin);
                                break;
                            }

                        custCount++;

                        Console.WriteLine();
                        Console.WriteLine("The account for {0} has been opened!", name);
                        Thread.Sleep(2000);
                        Console.Clear();

                        break;

                    case 'L':
                        found = false;
                        Console.WriteLine();
                        Console.Write("Enter PIN of account to be deleted: ");
                        pin = Int32.Parse(Console.ReadLine());

                        foreach (Checking chk in newAccount)
                            if (chk.Pin == pin)
                            {
                                found = true;
                                chk.Name = "";
                                chk.Pin = 0;
                                chk.Balance = 0.0;
                                custCount--;

                                Console.WriteLine();
                                Console.WriteLine("Account with Pin {0} has been deleted.", pin);
                                Thread.Sleep(2000);
                                break;
                            }

                        if (!found)
                        {
                            Console.WriteLine();
                            Console.WriteLine("Pin number could not be found! Please try again...");
                            Thread.Sleep(2000);
                            Console.Clear();
                            break;
                        }

                        Console.Clear();
                        break;

                    case 'H':
                        Console.WriteLine();
                        Console.WriteLine("Name             Balance");
                        Console.WriteLine("------------------------");

                        foreach (Checking chk in newAccount)
                            Console.WriteLine("{0}{1}", String.Format("{0}", chk.Name).PadRight(20), chk.Balance);

                        Console.WriteLine();
                        Console.WriteLine();
                        Console.WriteLine("PRESS ANY KEY TO CONTINUE...");
                        Console.ReadKey();
                        Console.Clear();
                        break;

                    case 'S':
                        found = false;
                        Console.WriteLine();
                        Console.Write("Pin Number For Account Access: ");
                        pin = Int32.Parse(Console.ReadLine());

                        foreach (Checking chk in newAccount)
                            if (chk.Pin == pin)
                                found = true;

                        if (!found)
                        {
                            Console.WriteLine();
                            Console.WriteLine("PIN number does not exist! Please try again...");
                            Thread.Sleep(2000);
                            Console.Clear();
                            break;
                        }

                        do
                        {
                            Console.Clear();
                            customerMenu();

                            choice = Char.Parse(Console.ReadLine());
                            choice = Char.ToUpper(choice);

                            switch (choice)
                            {
                                case 'I':
                                    Console.WriteLine();

                                    foreach (Checking chk in newAccount)
                                        if (chk.Pin == pin)
                                            Console.WriteLine("The balance for {0}'s account is ${1}", chk.Name, chk.Balance);

                                    Thread.Sleep(2000);
                                    Console.Clear();
                                    break;

                                case 'D':
                                    Console.WriteLine();
                                    Console.Write("Enter amount to deposit: ");
                                    deposit = Double.Parse(Console.ReadLine());

                                    foreach (Checking chk in newAccount)
                                        if (chk.Pin == pin)
                                        {
                                            chk.Balance += deposit;
                                            Console.WriteLine();
                                            Console.WriteLine("New balance for {0}'s account is ${1}", chk.Name, chk.Balance);
                                            Thread.Sleep(2000);
                                            break;
                                        }

                                    Console.Clear();
                                    break;

                                case 'W':
                                    Console.WriteLine();
                                    Console.Write("Enter amount to withdraw: ");
                                    withdraw = Double.Parse(Console.ReadLine());

                                    foreach (Checking chk in newAccount)
                                        if (chk.Pin == pin)
                                        {
                                            if (withdraw < chk.Balance)
                                            {
                                                chk.Balance -= withdraw;
                                                Console.WriteLine();
                                                Console.WriteLine("New balance for {0}'s account is ${1}", chk.Name, chk.Balance);
                                                Thread.Sleep(2000);
                                                break;
                                            }
                                            else
                                            {
                                                Console.WriteLine();
                                                Console.WriteLine("Error! ${0} exceeds the available balance! Please enter an amount less than ${1}", withdraw, chk.Balance);
                                                Thread.Sleep(3000);
                                                Console.Clear();
                                                break;
                                            }
                                        }

                                    Console.Clear();
                                    break;

                                case 'R':
                                    Console.Clear();
                                    break;

                                default:
                                    Console.WriteLine();
                                    Console.WriteLine("Your selection was invalid! Please try again!");
                                    Thread.Sleep(2000);
                                    Console.Clear();
                                    break;
                            }
                        } while (choice != 'R');

                        break;

                    case 'Q':
                        Console.WriteLine();
                        Console.WriteLine("Thank you for banking with Town House Banking!");
                        Thread.Sleep(2000);
                        break;

                    default:
                        Console.WriteLine("Your selection was invalid! Please try again!");
                        Thread.Sleep(2000);
                        Console.Clear();
                        break;
                }
            }while(choice != 'Q');
        }

        static private void tellerMenu()
        {
            Console.WriteLine("*****************");
            Console.WriteLine("[O]pen Account");
            Console.WriteLine("C[L]ose Account");
            Console.WriteLine("S[H]ow Customers");
            Console.WriteLine("[S]ervices");
            Console.WriteLine("[Q]uit");
            Console.WriteLine("*****************");
            Console.WriteLine();
            Console.Write("Choice: ");
        }

        static private void customerMenu()
        {
            Console.WriteLine("***********");
            Console.WriteLine("[I]nquire");
            Console.WriteLine("[D]eposit");
            Console.WriteLine("[W]ithdraw");
            Console.WriteLine("[R]eturn");
            Console.WriteLine("***********");
            Console.WriteLine();
            Console.Write("Choice: ");
        }
    }

    class Checking
    {
        private string name;
        private double balance;
        private int pin;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        
        public double Balance
        {
            get { return balance; }
            set { balance = value; }
        }
 
        public int Pin
        {
            get { return pin; }
            set { pin = value; }
        }

        public Checking()
        {
            name = "";
            balance = 0.0;
            pin = 0;
        }


        public void Open(string sname, double dbalance, int dpin)
        {
            name = sname;
            balance = dbalance;
            pin = dpin;
        }
    }
}