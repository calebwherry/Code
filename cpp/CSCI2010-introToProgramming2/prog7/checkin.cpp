// Caleb Wherry
// checkin.cpp
// 04/08/07
// Purpose: To organize the customers at an airport according to their flying status for the clerks.

#include <string>
#include <iostream>
#include <fstream>
#include <queue> 

using namespace std;

struct Customer
{
	string name;
 	char status;
};

void printQueue(queue<Customer> que);

int main()
{
  	string status[3] = {"Frequent Flyer", "Gold Card", "Regular"};
  
  	queue<Customer> que[3];  	
  	Customer ctm;        		
  
  	int clerkNbr;
  	char code;
  	ifstream fin;

  	fin.open("input.dat");
  	if( fin.fail() )
  	{
  		cout << "Data File Not Available!" << endl;
    		exit(1);
  	}

	cout << endl;
 
  	fin >> code;
  	while (!fin.eof() && code != 'X') 
 	{
    		if (code == 'A') 
    		{
      			fin >> ctm.name;
			fin >> ctm.status;

			if (ctm.status == 'F')
			{
				que[0].push(ctm);
			}

			else if (ctm.status == 'G')
			{
				que[1].push(ctm);
			}

			else if (ctm.status == 'R')
			{
				que[2].push(ctm);
			} 			
    		}
    
    		else if (code == 'C')	
    		{
			fin >> clerkNbr;

			if (clerkNbr == 1)
			{
				if (!que[0].empty())
				{
					ctm = que[0].front();
					cout << "Clerk #1 is checking in customer " << ctm.name << " whose status is " << ctm.status << "." << endl;
					que[0].pop();
				}

				else if(!que[1].empty())
				{
					ctm = que[1].front();
                                        cout << "Clerk #1 is checking in customer " << ctm.name << " whose status is " << ctm.status << "." << endl;
                                        que[1].pop();
				}

				else if (!que[2].empty())
				{
					ctm = que[2].front();
                                        cout << "Clerk #1 is checking in customer " << ctm.name << " whose status is " << ctm.status << "." << endl;
                                        que[2].pop();
				}
			}

			else if (clerkNbr == 2)
			{
				if (!que[0].empty())
                                {
                                        ctm = que[0].front();
                                        cout << "Clerk #2 is checking in customer " << ctm.name << " whose status is " << ctm.status << "." << endl;
                                        que[0].pop();
                                }

                                else if (!que[1].empty())
                                {
                                        ctm = que[1].front();
                                        cout << "Clerk #2 is checking in customer " << ctm.name << " whose status is " << ctm.status << "." << endl;
                                        que[1].pop();
                                }

                                else if (!que[2].empty())
                                {
                                        ctm = que[2].front();
                                        cout << "Clerk #2 is checking in customer " << ctm.name << " whose status is " << ctm.status << "." << endl;
                                        que[2].pop();
                                }	
			}

			else if (clerkNbr == 3)
			{
				if (!que[0].empty())
                                {
                                        ctm = que[0].front();
                                        cout << "Clerk #3 is checking in customer " << ctm.name << " whose status is " << ctm.status << "." << endl;
                                        que[0].pop();
                                }

                                else if (!que[1].empty())
                                {
                                        ctm = que[1].front();
                                        cout << "Clerk #3 is checking in customer " << ctm.name << " whose status is " << ctm.status << "." << endl;
                                        que[1].pop();
                                }

                                else if (!que[2].empty())
                                {
                                        ctm = que[2].front();
                                        cout << "Clerk #3 is checking in customer " << ctm.name << " whose status is " << ctm.status << "." << endl;
                                        que[2].pop();
                                }
			}
    		}
    
    		fin >> code;
  	}
  
	fin.close();

  	for (int i=0; i<3; i++)
  	{
    		cout << endl << "The following " << status[i] << " customer(s) are waiting for check-in: " << endl;
    		printQueue(que[i]);
  	}

  	cout << endl;

  	return 0;
}

void printQueue(queue<Customer> que)
{
  	Customer ctm;

  	while (!que.empty())
  	{
    		ctm = que.front();
    		cout << ctm.name << " ";
    		que.pop();
  	}	 
}
