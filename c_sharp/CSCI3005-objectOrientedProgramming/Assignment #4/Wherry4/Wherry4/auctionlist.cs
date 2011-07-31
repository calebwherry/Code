// Caleb Wherry
// CSCI 3005 - Assignment #4
// April 1st, 2008

using System;
using System.IO;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace Wherry4
{
    public struct Auction
    {
        public string id;
        public string ownerId;
        public string category;
        public string title;
        public string closingDate;
        public double startingBid;
        public double currentBid;
    };

    class auctionlist
    {
        static public List<Auction> mylist = new List<Auction>();
        
        static void Main(string[] args)
        {
            Console.Title = "MyList";
            Console.ForegroundColor = ConsoleColor.Green;

            String s;
            string temp;
            string blank = "";
            string choice;
            int count = 0;
            bool found = false;

            StreamReader sr = new StreamReader("auctions.txt");

            while ((s = sr.ReadLine()) != null)
            {
                Auction auct = new Auction();

                auct.id = s;
                auct.ownerId = sr.ReadLine();
                auct.category = sr.ReadLine();
                auct.title = sr.ReadLine();
                auct.closingDate = sr.ReadLine();
                auct.startingBid = Convert.ToDouble(sr.ReadLine());
                auct.currentBid = Convert.ToDouble(sr.ReadLine());
                blank = sr.ReadLine();

                mylist.Add(auct);
            }

            sr.Close();

            do
            {
                MainMenu();

                choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        Console.WriteLine();
                        Console.WriteLine("ID   Ower ID  Category  Title            Closing Date  Starting Bid  Current Bid");
                        Console.WriteLine("--------------------------------------------------------------------------------");

                        foreach (Auction x in mylist)
                            Console.WriteLine("{0}   {1}    {2}{3}{4}        {5}{6}",
                                                x.id, x.ownerId, String.Format("{0}", x.category).PadRight(10), String.Format("{0}", x.title).PadRight(18),
                                                x.closingDate, String.Format("{0}", x.startingBid).PadRight(13), x.currentBid);

                        Console.WriteLine();
                        Console.WriteLine();
                        Console.WriteLine("PRESS ANY KEY TO CONTINUE...");
                        Console.ReadKey();
                        break;

                    case "2":
                        found = false;
                        Auction auct = new Auction();

                        Console.WriteLine();
                        Console.Write("ID: ");
                        auct.id = Console.ReadLine();

                        foreach (Auction x in mylist)
                        {
                            if (x.id == auct.id)
                            {
                                found = true;
                                break;
                            }
                        }

                        if (found)
                        {
                            Console.WriteLine();
                            Console.WriteLine("This ID already exists! Please try again...");
                            Thread.Sleep(2000);
                            break;
                        }

                        StreamWriter sw = File.AppendText("auctions.txt");

                       if (count == 0)
                            sw.WriteLine();

                        count++;

                        Console.Write("Owner ID: ");
                        auct.ownerId = Console.ReadLine();
                        

                        Console.Write("Category: ");
                        auct.category = Console.ReadLine();
                       
                        Console.Write("Title: ");
                        auct.title = Console.ReadLine();
                        
                        Console.Write("Closing Date: ");
                        auct.closingDate = Console.ReadLine();
                        

                        Console.Write("Starting Bid: ");
                        auct.startingBid = Convert.ToDouble(Console.ReadLine());
                        
                        Console.Write("Current Bid: ");
                        auct.currentBid = Convert.ToDouble(Console.ReadLine());
                        
                        sw.WriteLine();
                        sw.WriteLine(auct.id);
                        sw.WriteLine(auct.ownerId);
                        sw.WriteLine(auct.category);
                        sw.WriteLine(auct.title);
                        sw.WriteLine(auct.closingDate);
                        sw.WriteLine(auct.startingBid);
                        sw.WriteLine(auct.currentBid);

                        mylist.Add(auct);

                        Console.WriteLine();
                        Console.WriteLine("Auction {0} has been added." , auct.id);
                        sw.Close();
                        Thread.Sleep(2000);
                        break;

                    case "3":
                        found = false;

                        Console.WriteLine();
                        Console.Write("Enter the auction ID to be deleted: ");
                        temp = Console.ReadLine();

                        foreach (Auction x in mylist)
                        {
                            if (x.id == temp)
                            {
                                mylist.Remove(x);
                                found = true;
                                break;
                            }
                        }

                        if (!found)
                        {
                            Console.WriteLine();
                            Console.WriteLine("ID could not be found! Please try again...");
                            Thread.Sleep(2000);
                            break;
                        }

                        Console.WriteLine();
                        Console.WriteLine("Auction {0} has been deleted!", temp);
                        Thread.Sleep(2000);
                        break;

                    case "4":
                        found = false;
                        Console.WriteLine();
                        Console.Write("Enter the owner ID to display: ");
                        s = Console.ReadLine();

                        foreach (Auction x in mylist)
                            if (x.ownerId == s)
                                found = true;

                        if (!found)
                        {
                            Console.WriteLine();
                            Console.WriteLine("Owner ID could not be found! Please try again...");
                            Thread.Sleep(2000);
                            break;
                        }

                        Console.WriteLine();
                        Console.WriteLine();
                        Console.WriteLine("ID    Title             Current Bid");
                        Console.WriteLine("-----------------------------------");
                        
                        foreach(Auction x in mylist)
                            if (x.ownerId == s)
                                Console.WriteLine("{0}  {1}{2}", x.id, String.Format("{0}", x.title).PadRight(22), x.currentBid);


                        Console.WriteLine();
                        Console.WriteLine();
                        Console.WriteLine("PRESS ANY KEY TO CONTINUE...");
                        Console.ReadKey();
                        break;

                    case "5":
                        found = false;

                        StreamWriter sw2 = File.AppendText("output.txt");

                        Console.WriteLine();
                        Console.Write("Display auctions ending on this date: ");
                        s = Console.ReadLine();

                        Console.WriteLine();
                        Console.WriteLine();
                        Console.WriteLine("ID    Title             Current Bid");
                        Console.WriteLine("-----------------------------------");

                        foreach (Auction x in mylist)
                            if (x.closingDate == s)
                            {
                                Console.WriteLine("{0}  {1}{2}", x.id, String.Format("{0}", x.title).PadRight(22), x.currentBid);
                                sw2.WriteLine(x.id);
                                sw2.WriteLine(x.title);
                                sw2.WriteLine(x.currentBid);
                                sw2.WriteLine();
                                found = true;
                            }

                        if (!found)
                        {
                            Console.WriteLine();
                            Console.WriteLine("No auctions ending on that date! Please try again...");
                        }

                        sw2.Close();

                        Console.WriteLine();
                        Console.WriteLine();
                        Console.WriteLine("PRESS ANY KEY TO CONTINUE...");
                        Console.ReadKey();

                        break;

                    case "0":
                        Console.WriteLine();
                        Console.WriteLine("Thank you for using MyList software!");
                        Thread.Sleep(2000);
                        break;

                    default:
                        Console.WriteLine();
                        Console.WriteLine("You have entered an incorrect selection. Please try again...");
                        Thread.Sleep(2000);
                        break;
                }
            } while (choice != "0");
        }

        public static void MainMenu()
        {
            Console.Clear();
            Console.WriteLine("********************************************");
            Console.WriteLine("1. Print The List");
            Console.WriteLine("2. Enter A New Item");
            Console.WriteLine("3. Remove An Item From The List");
            Console.WriteLine("4. Print All Items Of An Owner");
            Console.WriteLine("5. Print All Items Closing On A Certain Date");
            Console.WriteLine("0. Exit");
            Console.WriteLine("********************************************");
            Console.WriteLine();
            Console.Write("Enter Selection: ");
        }
    }
}