// Caleb Wherry
// Cameron Druyor
// CSCI 3005 Project 1: SuperRent!
// March 25th, 2008 

using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace VideoRental
{
    class Program
    {
        private static string choice;
        private static Game[] gamArr = new Game[99];
        private static GameCopy[] gameCpArr = new GameCopy[891];
        private static Member[] mbrArr = new Member[99];
        private static Movie[] movArr = new Movie[99];
        private static MovieCopy[] movieCpArr = new MovieCopy[891];
        private static TransRecord[] trsArr = new TransRecord[99];
        private static string temp, temp2, temp3;
        private static Int32 howMany, arrPosition, transaction;
        private static bool isMovie, found;

        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Green;

            SplashScreen();

            for (int i = 0; i < gamArr.Length; i++)
            {
                gamArr[i] = new Game();
                movArr[i] = new Movie();
                mbrArr[i] = new Member();
                trsArr[i] = new TransRecord();
            }

            for (int i = 0; i < gameCpArr.Length; i++)
            {
                gameCpArr[i] = new GameCopy();
                movieCpArr[i] = new MovieCopy();
            }

            do
            {
                Console.Title = "SuperRent! - Main Menu";
                Console.WriteLine("*************");
                Console.WriteLine("[I]nventory");
                Console.WriteLine("[M]embership");
                Console.WriteLine("[S]ervice");
                Console.WriteLine("[Q]uit");
                Console.WriteLine("*************");
                Console.WriteLine("");
                Console.Write("Choice: ");
                choice = Console.ReadLine().ToUpper();

                switch (choice)
                {
                    case "I":
                        Console.Clear();
                        InventoryMenu();
                        break;

                    case "M":
                        Console.Clear();
                        MemberMenu();
                        break;

                    case "S":
                        Console.Clear();
                        ServiceMenu();
                        break;

                    case "Q":
                        Console.WriteLine();
                        Console.WriteLine("Thank you for using SuperRent!");
                        Thread.Sleep(1500);
                        break;

                    default:
                        Console.WriteLine();
                        Console.WriteLine("Invalid choice. Try again...");
                        Thread.Sleep(1500);
                        Console.Clear();
                        break;
                }
            }
            while (choice != "Q");
        }

        public static void InventoryMenu()
        {
            do
            {
                Int32 existingCopies = 0;

                Console.Title = "SuperRent! - Inventory";
                Console.WriteLine("*****************");
                Console.WriteLine("[P]urchase");
                Console.WriteLine("[L]ist");
                Console.WriteLine("[M]ovie Rent Fee");
                Console.WriteLine("[G]ame Rent Fee");
                Console.WriteLine("[B]ack");
                Console.WriteLine("*****************");
                Console.WriteLine("");
                Console.Write("Choice: ");
                choice = Console.ReadLine().ToUpper();

                switch (choice)
                {
                    case "P":
                        Console.Title = "SuperRent! - Purchasing A Product...";
                        Console.WriteLine();
                        Console.Write("[M]ovie or [G]ame: ");
                        temp =  Console.ReadLine().ToUpper();

                        if (temp == "M")
                            isMovie = true;
                        else if (temp == "G")
                            isMovie = false;
                        else 
                        {
                            Console.WriteLine("Invalid choice. Try again...");
                            Thread.Sleep(1500);
                            Console.Clear();
                            break; 
                        }

                        Console.Write("Title: ");
                        temp = Console.ReadLine();

                        if (isMovie) 
                        {
                            for (int i = 0; i < movArr.Length; i++)
                            {
                                if (movArr[i].Id == "" || movArr[i].Id==temp)
                                {
                                    if (movArr[i].Id == "")
                                    {
                                        arrPosition = i;
                                 
                                        if (i < 10)
                                            movArr[i].Id = "M0" + i.ToString(); 
                                        else
                                            movArr[i].Id = "M" + i.ToString(); 
                                    }

                                    break;
                                }
                            }

                            movArr[arrPosition].Title = temp; 
                        }
                        else 
                        {
                            for (int i = 0; i < gamArr.Length; i++)
                            {
                                if (gamArr[i].Id == "" || gamArr[i].Id == temp)
                                {
                                    if (gamArr[i].Id == "")
                                    {
                                        arrPosition = i;
                                      
                                        if (i < 10)
                                            gamArr[i].Id = "G0" + i.ToString(); 
                                        else
                                            gamArr[i].Id = "G" + i.ToString(); 
                                    }

                                    break;
                                }
                            }

                            gamArr[arrPosition].Title = temp;
                        }

                        Console.Write("Release Date: ");
                        temp = Console.ReadLine();

                        if (isMovie) 
                            movArr[arrPosition].ReleaseDate = DateTime.Parse(temp);
                        else
                            gamArr[arrPosition].ReleaseDate = DateTime.Parse(temp);

                        Console.Write("Number of Copies: ");
                        howMany = Convert.ToInt32(Console.ReadLine());

                        if (isMovie)
                            movArr[arrPosition].NbrCopies = howMany;
                        else
                            gamArr[arrPosition].NbrCopies = howMany;

                        Console.Write("Purchase Date: ");
                        temp = Console.ReadLine();

                        if (isMovie)
                        {
                            for (int i = 0; i < 9; i++)
                            {
                                if (movieCpArr[arrPosition * 9 + i].MovieId == "") 
                                {
                                    existingCopies = i;
                                    break;
                                }
                            }

                            for (int i = 0; i < howMany; i++)
                            {
                                movieCpArr[arrPosition * 9 + existingCopies + i].MovieTitle = movArr[arrPosition].Title;
                                movieCpArr[arrPosition * 9 + existingCopies + i].PurchaseDate = DateTime.ParseExact(temp, "MM/dd/yyyy", null);
                                movieCpArr[arrPosition * 9 + existingCopies + i].MovieId = movArr[arrPosition].Id;
                                movieCpArr[arrPosition * 9 + existingCopies + i].Id = i + 1;
                                movieCpArr[arrPosition * 9 + existingCopies + i].IsCheckedOut = false;
                            }

                            existingCopies += howMany;
                            movArr[arrPosition].NbrCopies = existingCopies;

                            Console.WriteLine();
                            Console.WriteLine("{0} copies of {1} have been purchased.  We now own {2} copies.", howMany, movArr[arrPosition].Title, movArr[arrPosition].NbrCopies);
                            Thread.Sleep(1500);
                        }
                        else
                        {
                            for (int i = 0; i < 9; i++)
                            {
                                if (gameCpArr[arrPosition * 9 + i].GameId == "")
                                {
                                    existingCopies = i;
                                    break;
                                }
                            }

                            for (int i = 0; i < howMany; i++)
                            {
                                gameCpArr[arrPosition * 9 + existingCopies + i].GameTitle = gamArr[arrPosition].Title;
                                gameCpArr[arrPosition * 9 + existingCopies + i].PurchaseDate = DateTime.ParseExact(temp, "MM/dd/yyyy", null);
                                gameCpArr[arrPosition * 9 + existingCopies + i].GameId = gamArr[arrPosition].Id;
                                gameCpArr[arrPosition * 9 + existingCopies + i].Id = i + 1;
                                gameCpArr[arrPosition * 9 + existingCopies + i].IsCheckedOut = false;
                            }

                            existingCopies += howMany;
                            gamArr[arrPosition].NbrCopies = existingCopies;

                            Console.WriteLine();
                            Console.WriteLine("{0} copies of {1} have been purchased.  We now own {2} copies.", howMany, gamArr[arrPosition].Title, gamArr[arrPosition].NbrCopies);
                            Thread.Sleep(1500);                            
                        }

                        Console.Clear();
                        break;

                    case "L":
                        Console.Title = "SuperRent! - Inventory List";
                        Console.WriteLine();
                        Console.WriteLine("Movie ID           Movie Title            Game ID           Game Title");
                        Console.WriteLine("----------------------------------------------------------------------");

                        for (int i = 0; i < 99; i++)
                        {
                            if (movArr[i].Id == "" && gamArr[i].Id == "") 
                                break;
                            else
                                Console.WriteLine("{0}                {1}{2}               {3}", movArr[i].Id, String.Format("{0}", movArr[i].Title).PadRight(23), gamArr[i].Id,gamArr[i].Title);
                        }

                        Console.WriteLine();
                        Console.WriteLine();
                        Console.WriteLine("PRESS ANY KEY TO CONTINUE...");
                        Console.ReadKey();
                        Console.Clear();
                        break;

                    case "M":
                        Console.Title = "SuperRent! - Price of Movie Rental...";
                        Console.WriteLine();
                        Console.Write("Please enter the rental price for movies: ");
                        temp = Console.ReadLine();
                        Movie.Rental = Convert.ToDouble(temp);

                        Console.WriteLine();
                        Console.WriteLine("The rental rate for movies has been set to ${0}.", Movie.Rental.ToString());
                        Thread.Sleep(1500);
                        Console.Clear();
                        break;

                    case "G":
                        Console.Title = "SuperRent! - Price of Game Rental...";
                        Console.WriteLine();
                        Console.Write("Please enter the rental price for games: ");
                        temp = Console.ReadLine();
                        Game.Rental = Convert.ToDouble(temp);

                        Console.WriteLine();
                        Console.WriteLine("The rental rate for movies has been set to ${0}.", Game.Rental.ToString());
                        Thread.Sleep(1500);
                        Console.Clear();
                        break;

                    case "B":
                        Console.Clear();
                        break;

                    default:
                        Console.WriteLine();
                        Console.WriteLine("Invalid choice. Try again...");
                        Thread.Sleep(1500);
                        Console.Clear();
                        break;
                }               
            }
            while (choice != "B");
        }

        public static void MemberMenu()
        {
            Int32 numOfMembers = 0;

            for (int i = 0; i < 99; i++)
            {
                if (mbrArr[i].Id == "")
                {
                    numOfMembers = i;
                    break;
                }
            }

            do
            {
                Console.Title = "SuperRent! - Member Management";
                Console.WriteLine("*************");
                Console.WriteLine("[O]pen");
                Console.WriteLine("[C]lose");
                Console.WriteLine("[L]ist");
                Console.WriteLine("[B]ack");
                Console.WriteLine("*************");
                Console.WriteLine("");
                Console.Write("Choice: ");
                choice = Console.ReadLine().ToUpper();

                found = true;

                switch (choice)
                {
                    case "O":
                        Console.Title = "SuperRent! - Opening An Account...";
                        Console.WriteLine();
                        Console.Write("Member ID: ");
                        temp = Console.ReadLine();

                        int b = 0;

                        for (b = 0; b < mbrArr.Length; b++)
                        {
                            if (mbrArr[b].Id == "")
                            {
                                mbrArr[b].Id = temp;
                                break;
                            }
                        }

                        Console.Write("Name: ");
                        temp = Console.ReadLine();
                        mbrArr[b].Name = temp;

                        Console.WriteLine();
                        Console.Write("Membership has been opened for {0}.",mbrArr[b].Name);
                        Thread.Sleep(1500);
                        Console.Clear();
                        break;

                    case "C":
                        Console.Title = "SuperRent! - Closing An Account...";
                        Console.WriteLine();
                        Console.Write("Member ID: ");
                        temp = Console.ReadLine();

                        for (int i = 0; i < mbrArr.Length; i++)
                        {
                            if (mbrArr[i].Id == temp)
                            {
                                found = true;
                                mbrArr[i].Id = "";
                                temp = mbrArr[i].Name;
                                mbrArr[i].Name = "";

                                Console.WriteLine();
                                Console.Write("Membership has been closed for {0}", temp);
                                break;
                            }
                        }

                        if (!found)
                        {
                            Console.WriteLine();
                            Console.WriteLine("This account does not exist! Try again...");
                        }

                        Thread.Sleep(1500);
                        Console.Clear();
                        break;

                    case "L":
                        Console.Title = "SuperRent! - Member List";

                        Console.WriteLine();
                        Console.WriteLine("Member ID         Member Name");
                        Console.WriteLine("-------------------------------------------------");

                        for (int i = 0; i < mbrArr.Length; i++)
                        {
                            if (mbrArr[i].Id == "") { }
                            else
                                Console.WriteLine("{0}{1}", String.Format("{0}", mbrArr[i].Id).PadRight(18), mbrArr[i].Name);
                        }

                        Console.WriteLine();
                        Console.WriteLine();
                        Console.WriteLine("PRESS ANY KEY TO CONTINUE...");
                        Console.ReadKey();
                        Console.Clear();
                        break;

                    case "B":
                        Console.Clear();
                        break;

                    default:
                        Console.WriteLine();
                        Console.WriteLine("Invalid choice. Try again...");
                        Thread.Sleep(1500);
                        Console.Clear();
                        break;
                }
            } while (choice != "B");
        }

        public static void ServiceMenu()
        {
            do
            {
                Console.Title = "SuperRent! - Rental Services";
                Console.WriteLine("***********");
                Console.WriteLine("[R]ent");
                Console.WriteLine("re[T]urn");
                Console.WriteLine("[L]ist");
                Console.WriteLine("[B]ack");
                Console.WriteLine("***********");
                Console.WriteLine("");
                Console.Write("Choice: ");
                choice = Console.ReadLine().ToUpper();

                transaction = 0;

                found = false;

                switch (choice)
                {
                    case "R":
                        Console.Title = "SuperRent! - Rent A Product";
                        Console.WriteLine();
                        Console.Write("Movie/Game ID: ");
                        temp = Console.ReadLine();

                        int j = 0;
                        int movPos = 0, gamPos = 0;

                        if (temp[0] == 'M' || temp[0] == 'm')
                        {
                            for (j = 0; j < movArr.Length; j++)
                            {
                                if (movArr[j].Id == temp)
                                {
                                    for (int L = 0; L < 9; L++)
                                    {
                                        if (movArr[j].Id == movieCpArr[j*9+L].MovieId)
                                        {
                                            if (movieCpArr[j*9+L].IsCheckedOut == false)
                                            {
                                                found = true;
                                                movieCpArr[j*9+L].IsCheckedOut = true;
                                                movPos = j * 9 + L;
                                                break;
                                            }
                                        }
                                    }
                                }
                            }
                        }
                        else if (temp[0] == 'G' || temp[0] == 'g')
                        {
                            for (j = 0; j < gamArr.Length; j++)
                            {
                                if (gamArr[j].Id == temp)
                                {
                                    for (int i = 0; i < gameCpArr.Length; i++)
                                    {
                                        if (gamArr[j].Id == gameCpArr[j*9+i].GameId)
                                        {
                                            if (gameCpArr[j*9+i].IsCheckedOut == false)
                                            {
                                                found = true;
                                                gameCpArr[j*9+i].IsCheckedOut = true;
                                                gamPos = j * 9 + i;
                                                break;
                                            }
                                        }
                                    } 
                                }
                            }
                        }
                        else
                        {
                            Console.WriteLine();
                            Console.WriteLine("Invalid product ID! Try again...");
                            Thread.Sleep(1500);
                            Console.Clear();
                            break;
                        }

                        if (!found)
                        {
                            Console.WriteLine();
                            Console.WriteLine("Sorry, this product is not in stock!");
                            Thread.Sleep(1500);
                            Console.Clear();
                            break;
                        }

                        Console.Write("Member ID: ");
                        temp2 = Console.ReadLine();

                        found = false;

                        for (int i = 0; i < mbrArr.Length; i++)
                        {
                            if (mbrArr[i].Id == temp2)
                            {
                                found = true;
                                break;
                            }
                        }

                        if (!found)
                        {
                            Console.WriteLine();
                            Console.WriteLine("Member ID does not exist! Try again...");
                            Thread.Sleep(1500);
                            Console.Clear();
                            break;
                        }

                        Console.Write("Rent Date: ");
                        temp3 = Console.ReadLine();

                        found = false;

                        int q;
                        for (q = 0; q < trsArr.Length; q++)
                        {
                            if (trsArr[q].Id == "")
                            {
                                transaction++;
                                trsArr[q].Id = transaction.ToString();

                                if (temp[0] == 'M')
                                {
                                    found = true;
                                    trsArr[q].Rent(temp, temp2, temp3, movieCpArr[movPos]);
                                    break;
                                }
                                else
                                {
                                    found = true;
                                    trsArr[q].Rent(temp, temp2, temp3, gameCpArr[gamPos]);
                                    break;
                                }
                            }
                            else if (trsArr[q].MbrId == temp2)
                            {
                                if (temp[0] == 'M')
                                {
                                    found = true;
                                    trsArr[q].Rent(temp, temp2, temp3, movieCpArr[movPos]);
                                    break;
                                }
                                else
                                {
                                    found = true;
                                    trsArr[q].Rent(temp, temp2, temp3, gameCpArr[gamPos]);
                                    break;
                                }
                            }      
                        }

                        if (!found)
                        {
                            Console.WriteLine();
                            Console.WriteLine("An error has occured. Try again...");
                            Thread.Sleep(1500);
                            Console.Clear();
                            break;
                        }

                        for (int i = 0; i < mbrArr.Length; i++)
                        {
                            if (mbrArr[i].Id == temp2)
                            {
                                Console.WriteLine();
                                Console.Write("Member {0} rented ", mbrArr[i].Name);
                            }
                        }

                        if (temp[0] == 'M')
                        {
                            for (int i = 0; i < movArr.Length; i++)
                            {
                                if (movArr[i].Id == temp)
                                    Console.WriteLine("{0}.", movArr[i].Title);
                            }
                        }
                        else
                        {
                            for (int i = 0; i < gamArr.Length; i++)
                            {
                                if (gamArr[i].Id == temp)
                                    Console.WriteLine("{0}.", gamArr[i].Title);
                            }
                        }

                        if (temp[0] == 'M')
                            Console.WriteLine("Rental: ${0}", Movie.Rental);
                        else
                            Console.WriteLine("Rental: ${0}", Game.Rental);

                        Console.WriteLine("Rent Date: {0}", temp3);
                        Console.WriteLine("Return Date: {0}", trsArr[q].DueDate.ToShortDateString());

                        Console.WriteLine();
                        Console.WriteLine("PRESS ANY KEY TO CONTINUE...");
                        Console.ReadKey();
                        Console.Clear();
                        break;

                    case "T":
                        Console.Title = "SuperRent! - Return A Rental";
                        Console.WriteLine();
                        Console.Write("Transaction ID: ");
                        temp = Console.ReadLine();

                        found = false;
                        j =0;

                        for (j = 0; j < trsArr.Length; j++)
                        {
                            if (trsArr[j].Id == temp)
                            {
                                found = true;
                                break;
                            }
                        }

                        if (!found)
                        {
                            Console.WriteLine();
                            Console.WriteLine("No Transactions by that ID. Try again...");
                            Thread.Sleep(1500);
                            Console.Clear();
                            break;
                        }

                        Console.WriteLine("Return Date: ");
                        temp2 = Console.ReadLine();

                        found = false;

                        Console.WriteLine("-------------------------------------------");

                        for (int i = 0; i < movieCpArr.Length; i++)
                        {
                            if (movieCpArr[i].IsCheckedOut == true)
                            {
                                found = true;
                                movieCpArr[i].IsCheckedOut = false;
                                trsArr[i].Return(temp, temp2);
                                Console.WriteLine("Member {0} has returned {1}.", trsArr[j].Id, movieCpArr[i].MovieTitle);
                                break;
                            }
                        }

                        if (!found)
                        {
                            Console.WriteLine();
                            Console.WriteLine("An error has occured! Try again...");
                            Thread.Sleep(1500);
                            Console.Clear();
                            break;
                        }

                        Thread.Sleep(1500);
                        Console.Clear();
                        break;

                    case "L":
                        Console.Title = "SuperRent! - List of Transactions";

                        Console.WriteLine();
                        Console.WriteLine("Transaction ID               Member ID           # of Rented Products");
                        Console.WriteLine("---------------------------------------------------------------------");

                        int counter = 0;

                        for (int i = 0; i < trsArr.Length; i++)
                        {
                            if (trsArr[i].Id == "")
                                break;

                            Console.WriteLine(trsArr[i].Id + "                                " + trsArr[i].MbrId + "                  " + trsArr[i].CpArr);
                        }

                        Console.WriteLine();
                        Console.WriteLine();
                        Console.WriteLine("PRESS ANY KEY TO CONTINUE...");
                        Console.ReadKey();
                        Console.Clear();
                        break;

                    case "B":
                        Console.Clear();
                        break;

                    default:
                        Console.WriteLine();
                        Console.WriteLine("Invalid choice. Try again...");
                        Thread.Sleep(1500);
                        Console.Clear();
                        break;
                }
            } while (choice != "B");
        }

        public static void SplashScreen()
        {
            string console_title = "Welcome to SuperRent! - Loading";
            string vertical_frame = "*******************************************************************************";
            string vertical_spacer = "**                                                                           **";
            string left_padding = "**              ";
            string right_padding = "              **";

            // Painting Splash Screen
            Console.WriteLine(vertical_frame);
            Console.WriteLine(vertical_frame);
            Console.WriteLine(vertical_spacer);
            Console.WriteLine(vertical_spacer);
            Console.WriteLine(left_padding + " ______   _    _   ___    _____   ___      ___ " + right_padding);
            Console.WriteLine(left_padding + "/  __  \\ | |  | | |   \\  |  ___| |   \\    |   |" + right_padding);
            Console.WriteLine(left_padding + "\\  \\ \\_/ | |  | | | |\\ \\ | |     | |\\ \\   |   |" + right_padding);
            Console.WriteLine(left_padding + " \\  \\    | |  | | | |/ / | |___  | |/ /   |   |" + right_padding);
            Console.WriteLine(left_padding + "  \\  \\   | |  | | |  _/  |  ___| |   /    |   |" + right_padding);
            Console.WriteLine(left_padding + " _ \\  \\  | |  | | | |    | |     |   \\    |   |" + right_padding);
            Console.WriteLine(left_padding + "/ \\_\\  \\ | |__| | | |    | |___  | |\\ \\   |   |" + right_padding);
            Console.WriteLine(left_padding + "\\______/ |______| |_|    |_____| |_| \\_\\  |   |" + right_padding);
            Console.WriteLine(left_padding + "                                          |   |" + right_padding);
            Console.WriteLine(left_padding + " ___     _____   ____    __   __________  |   |" + right_padding);
            Console.WriteLine(left_padding + "|   \\   |  ___| |    \\  |  | |          | |   |" + right_padding);
            Console.WriteLine(left_padding + "| |\\ \\  | |     |  |  \\ |  | |___    ___| |   |" + right_padding);
            Console.WriteLine(left_padding + "| |/ /  | |___  |  |\\  \\|  |     |  |     |   |" + right_padding);
            Console.WriteLine(left_padding + "|   /   |  ___| |  | \\  |  |     |  |     |___|" + right_padding);
            Console.WriteLine(left_padding + "|   \\   | |     |  |  \\    |     |  |      ___ " + right_padding);
            Console.WriteLine(left_padding + "| |\\ \\  | |___  |  |   \\   |     |  |     |   |" + right_padding);
            Console.WriteLine(left_padding + "|_| \\_\\ |_____| |__|    \\__|     |__|     |___|" + right_padding);
            Console.WriteLine(vertical_spacer);
            Console.WriteLine(vertical_spacer);
            Console.WriteLine(vertical_frame);
            Console.Write(vertical_frame);

            // Drawing the loading bar in the console title
            for (int i = 0; i <= 8; i++)
            {
                Console.Title = console_title;
                console_title += ".";
                Thread.Sleep(800);
            }
            Console.Clear();
        }
    }
}