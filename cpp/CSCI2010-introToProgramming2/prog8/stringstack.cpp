// Caleb Wherry
// stringstack.cpp
// 04/11/07
/* Purpose: To manipulate an input to see if it, or any of it components, is a palindrome.*/

#include <iostream>
#include <iomanip> 
#include <string> 
#include <stack>

using namespace std;

bool nbr(char symb);
void revstring(string & s);
void print1(string s);
void print2(string s);
void print3(string s);
void print4(string s);
void print5(string s);

int main()
{
	string s;
  	cout << endl << "Input A String: ";
  	getline(cin,s);
  	cout << endl << "Output: " << endl;
  	print1(s);
  	print2(s);
  	print3(s);
 	print4(s);
 	print5(s);
	cout << endl;
 	return 0;
}

bool nbr (char symb)
{
	if( symb >= '0' && symb <= '9' )
		return true;
	else
		return false;
}

void revstring (string & s)
{
	stack<char> nbrstk;
  	int i=0;

  	while (i < s.length())
  		nbrstk.push(s[i++]);
  
  	i = 0;
  	while(!nbrstk.empty())
  	{
    		s[i++] = nbrstk.top();
    		nbrstk.pop();
  	}
}

void print1 (string s)
{
  	for(int i=0; i < s.length(); i++)
    		cout << s[i];
  	
	cout << endl;
}

void print2 (string s)
{
	string temp = s;
	revstring(temp);
	print1(temp);  
}

void print3 (string s)
{
	stack<char> nbrstk;
	char symb;
	int i = 0;

	while (i < s.length())
	{
		symb = s[i];

		if (!nbr(symb))
		{
			cout << symb;
			i++;
		}
		
		else
		{
			while (nbr(symb))
			{
				nbrstk.push(symb);
				symb = s[++i];
			}

			while (!nbrstk.empty())
			{
				cout << nbrstk.top();
				nbrstk.pop(); 
			}
		}
	}

	cout << endl;		  
}

void print4 (string s)
{
	string temp = s;
	revstring(temp);

	if (temp == s)
		cout << "This is a palindrome!" << endl;
	else
		cout << "This is not a palindrome!" << endl;
}

void print5 (string s)
{
	string temp, temp2;
	char symb;
	int i = 0;

	while (i < s.length())
	{
		symb = s[i];		
		
		if (!nbr(symb))
		{
			i++;	
		}	
	
		else
		{
			temp = s.substr(0,i);
			temp2 = s.substr(0, i);
			revstring(temp);

			if (temp2 == temp)
				cout << "The first " << i << " characters form a palindrome." << endl;
       			else
               			cout << "There is no palindrome in this string!" << endl;

			break;
		}
	}	
}
