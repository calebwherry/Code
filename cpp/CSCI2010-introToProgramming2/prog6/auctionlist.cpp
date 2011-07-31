// Caleb Wherry
// auctionlist.cpp
// 3/29/07
// Purpose:

#include <iostream>
#include <string>
#include <fstream>
#include <iomanip>
#include <list> 

using namespace std;

struct Auction 			
{
    string id;
    string ownerId;
    string category;
    string description;
    string closingDate;
    double startingBid;
    double currentBid;
};

void display();                 	
void menu(int & );              	
void readitem(list<Auction> & );        
void removeitem(list<Auction> & );       
void printlist(list<Auction> & );      
void readfromfile(list<Auction> & );     
void itemsofowner(list<Auction> & );       
void itemsondate(list<Auction> & );        
void wait();                    	

int main()
{
    list<Auction> mylist;              
    int choice;                       

    readfromfile(mylist);           

    menu(choice);                     
    while(choice != 0)              
    {
      switch(choice)
      {
        case 1: printlist(mylist);    
                break;
        case 2: readitem(mylist);          
                break;
        case 3: removeitem(mylist);  
                break;
        case 4: itemsofowner(mylist);     
                break;
        case 5: itemsondate(mylist);         
                break;
      }                               
      menu(choice);                   
    }                                 
    return 0;
}                                   

void readfromfile(list<Auction> & newlist)
{
    ifstream fil;
    Auction aucItem;
    string emptyLine;
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
  
      while(p != newlist.end() && !found)
        if(aucItem.id <= (*p).id)
          found = true;
        else
          p++;
  
      newlist.insert(p, aucItem);
    }
    fil.close();
}

void menu(int &c)
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

void printlist(list<Auction> & plist)
{
    list<Auction>::iterator p;
    cout << endl << "List Contains " << plist.size() << " Auction Items: " << endl;
    p = plist.begin();
    while(p != plist.end())
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

void readitem(list<Auction> & templist)
{
    list<Auction>::iterator p;
    Auction aucItem;
    
    bool found = false;
     
    cin.ignore(80, '\n');
    cout << endl;
    cout << "Enter ID Number: ";
    getline(cin, aucItem.id);
    cout << "Enter Owner ID: ";
    getline(cin, aucItem.ownerId);
    cout << "Enter Category: ";
    getline(cin, aucItem.category);
    cout << "Enter Description: ";
    getline(cin, aucItem.description);
    cout << "Enter Closing Date: ";
    getline(cin, aucItem.closingDate);
    cout << "Enter Starting Bid: ";
    cin >> aucItem.startingBid;
    cout << "Enter Current Bid: ";
    cin >> aucItem.currentBid;
    cin.ignore();
     
    p = templist.begin();
    while(p != templist.end() && !found)
    {
       if(aucItem.id <= (*p).id)
          found = true;
       else
          p++;
    }
    
    templist.insert(p, aucItem);
    wait();
}

void removeitem(list<Auction> & newlist)
{
    list<Auction>::iterator p;
    string id;
    
    cout << "Enter ID Number: ";
    getline(cin, id);
    
    p = newlist.begin();
    while (p!=newlist.end())
    {
        if ((*p).id == id)
            newlist.erase(p);  
    }
    
    wait();
}

void itemsofowner(list<Auction> & plist)
{
    list<Auction>::iterator p;
    string value;

    cout << endl << endl << "Enter Owner ID: ";
    cin.ignore();
    getline(cin,value);
    
    cout << endl << "Items of Owner with ID " << value << endl;
      
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

void itemsondate(list<Auction> & plist)
{
     list<Auction>::iterator p;
     string value;
     
     cout << endl << endl << "Enter Closing Date: ";
     cin.ignore();
     getline(cin, value);
     
     p = plist.begin();
     while (p != plist.end())
     {
           if ((*p).closingDate == value)
           {
               cout << setw(4) << (*p).id << setw(20) << (*p).description 
                    << setw(7) << (*p).currentBid << endl;
           }
           p++;
     }
     
     wait();
}

void wait()
{
    cout << endl << endl << "Press Enter Key To Continue ";
    getchar();
}
