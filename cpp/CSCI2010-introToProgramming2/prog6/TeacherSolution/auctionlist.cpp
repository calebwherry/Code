// auctionlist.cpp
// Jiang Li

#include <iostream>
#include <string>
#include <fstream>
#include <iomanip>
#include <list> 

using namespace std;

struct Auction 			// data type to store information
{
  string id;
  string ownerId;
  string category;
  string description;
  string closingDate;
  double startingBid;
  double currentBid;
};

// method declarations

void menu( int &);              	// displays menu and accepts choice
void readitem( list<Auction> & );        // adds new item to list
void removeitem( list<Auction> &);       // removes an item from list
void printlist( list<Auction> & );       // displays list
void readfromfile( list<Auction> &);     // reads original data from file
void itemsofowner( list<Auction> & );        // adds new item to list
void itemsondate( list<Auction> & );        // adds new item to list
void wait();                    	// allows the user to read screen

int main()
{
  list<Auction> mylist;              // original linked list
  int choice;                       // menu option

  readfromfile( mylist );           // read original data from file

  menu(choice);                     // display menu
  while( choice != 0 )               // repeat until choice is zero
  {
    switch(choice)
    {
      case 1: printlist(mylist);    // display list
              break;
      case 2: readitem(mylist);     // add item to list       
              break;
      case 3: removeitem(mylist);   // remove item from list
              break;
      case 4: itemsofowner(mylist); // items of an owner       
              break;
      case 5: itemsondate(mylist);  // items closing on a date       
              break;
    }                               // Ends Switch
    menu(choice);                   // display menu again
  }                                 // Ends While
  return 0;
}                                   // Ends Main Program

// reads data from file and places on list
void readfromfile( list<Auction> & newlist)
{
  // Code to open file and read data

  ifstream fil;
  Auction aucItem;
  //string emptyLine;
  bool found;
  list<Auction>::iterator p;

  fil.open("auction.dat");
  if( fil.fail() )
  {
    cout << "Data File Not Available " << endl;
    exit(1);
  }

  while( !fil.eof() )
  {
    getline(fil,aucItem.id);
    getline(fil,aucItem.ownerId);
    getline(fil,aucItem.category);
    getline(fil,aucItem.description);
    getline(fil,aucItem.closingDate);
    fil >> aucItem.startingBid;
    fil >> aucItem.currentBid;
    fil.ignore(80, '\n');
    fil.ignore(80, '\n');
    //getline(fil,emptyLine);
    
    p = newlist.begin();
    found = false;
  
    while( p != newlist.end() && !found )
      if( aucItem.id <= (*p).id )
        found = true;
      else
        p++;
  
    newlist.insert(p, aucItem);
  }
  fil.close();
}

// displays menu choices and performs menu operations
void menu( int &c)
{
  system("clear");
  do
  {
    system("clear");
    cout << endl << endl;
    cout << "       1.  Print The List" << endl << endl;
    cout << "       2.  Enter A New Item" << endl << endl;
    cout << "       3.  Remove An Item From The List" << endl << endl;
    cout << "       4.  Print All Items Of An Owner" << endl << endl;
    cout << "       5.  Print All Items Closing On A Date" << endl << endl;
    cout << "       Enter Choice:   ";
    cin >> c;
  } while( c < 0 || c > 5 );
}

// print contents of plist
void printlist( list<Auction> & plist)
{
  list<Auction>::iterator p;
  cout << endl << "List Contains " << plist.size() << " Auction Items: " << endl;
  p = plist.begin();
  while( p != plist.end() )
  {
     cout << setw(4) << (*p).id << setw(5) << (*p).ownerId 
          << setw(10) << (*p).category << setw(20) << (*p).description 
          << setw(15) << (*p).closingDate << setw(7) << (*p).startingBid 
          << setw(7) << (*p).currentBid << endl;
     p++;
  }
  getchar();
  wait();
}

// read new item from keyboard and add to templist
void readitem( list<Auction> & templist)
{
  list<Auction>::iterator p;
  Auction aucItem;
  bool found = false;

  cin.ignore();
  cout << endl << "Enter Item ID: ";
  getline(cin,aucItem.id);
  cout << endl << "Enter Owner ID: ";
  getline(cin,aucItem.ownerId);
  cout << endl << "Enter Category: ";
  getline(cin,aucItem.category);
  cout << endl << "Enter Description: ";
  getline(cin,aucItem.description);
  cout << endl << "Enter Closing Date: ";
  getline(cin,aucItem.closingDate);
  cout << endl << "Enter Starting Bid: ";
  cin >> aucItem.startingBid;
  cout << endl << "Enter Current Bid: ";
  cin >> aucItem.currentBid;
    
  p = templist.begin();
  while( p != templist.end() && !found )
   if( aucItem.id < (*p).id )
     found = true;
   else
     p++;

  templist.insert(p,aucItem);
  cout << endl << endl << "Auction " << aucItem.id << " was added to our list.";
  cin.ignore();
  wait();
}

// accepts item name from keyboard and removes from list
void removeitem( list<Auction> & newlist)
{
   list<Auction>::iterator p;
   string value;
   bool found = false;

   cout << endl << endl << "Enter Item ID To Remove: ";
   cin.ignore();
   getline(cin,value);

   p = newlist.begin();

   while( p != newlist.end() && !found )
     if( value == (*p).id )
       found = true;
     else
       p++;

   if( found )
   {
     newlist.erase(p);
     cout << endl << endl << "Item " << value << " was removed from our list";
   }
   else
     cout << value << " is not on our list";
   wait();
}
  
// print contents of plist of this owner
void itemsofowner( list<Auction> & plist)
{
  list<Auction>::iterator p;
  string value;

  cout << endl << endl << "Enter Owner ID: ";
  cin.ignore();
  getline(cin,value);
      
  p = plist.begin();
  while( p != plist.end() )
  {
     if ((*p).ownerId == value)
     {
       cout << setw(4) << (*p).id << setw(5) << (*p).ownerId 
          << setw(10) << (*p).category << setw(20) << (*p).description 
          << setw(15) << (*p).closingDate << setw(7) << (*p).startingBid 
          << setw(7) << (*p).currentBid << endl;
     }  
     p++;
  }

  wait();
}

// print contents of plist of this owner
void itemsondate( list<Auction> & plist)
{
  list<Auction>::iterator p;
  string value;

  cout << endl << endl << "Enter Closing Date: ";
  cin.ignore();
  getline(cin,value);
      
  p = plist.begin();
  while( p != plist.end() )
  {
     if ((*p).closingDate == value)
     {
       cout << setw(4) << (*p).id << setw(5) << (*p).ownerId 
          << setw(10) << (*p).category << setw(20) << (*p).description 
          << setw(15) << (*p).closingDate << setw(7) << (*p).startingBid 
          << setw(7) << (*p).currentBid << endl;
     }  
     p++;
  }

  wait();
}

// pauses screen to allow user to view screen contents
void wait()
{
  cout << endl << endl << "Press Enter Key To Continue ";
  getchar();
}
