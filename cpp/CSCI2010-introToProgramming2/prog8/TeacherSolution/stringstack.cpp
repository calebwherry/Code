// Jiang Li
// stringstack.cpp

#include <iostream>
#include <iomanip> 
#include <string> 
#include <stack>
using namespace std;

bool nbr(char symb);
void revstring(string& s);
void print1(string s);
void print2(string s);
void print3(string s);
void print4(string s);
void print5(string s);

int main()
{
  string s;  // original string
  cout << "Input a string: ";
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

bool nbr( char symb )
{
  if( symb >= '0' && symb <= '9' )
    return true;
  else
    return false;
}

void revstring(string& s)
{
  stack<char> nbrstk;
  int i=0;

  while( i<s.length() )
    nbrstk.push(s[i++]);
  
  i = 0;
  while(!nbrstk.empty())
  {
    s[i++] = nbrstk.top();
    nbrstk.pop();
  }
}

void print1(string s)
{
  for(int i=0; i<s.length(); i++)
    cout << s[i];
  cout << endl;
}

void print2(string s)
{
  string s1 = s;
  revstring(s1);
  print1(s1);
}

void print3( string s )
{
  stack<char> nbrstk;
  char symb;
  int i = 0;
  
  while( i<s.length() )
  {
    symb = s[i];
	
    if (!nbr(symb))	// print out letters
    {
      cout << symb;
      i++;
    }
    else			// print out numbers
    {
      while(nbr(symb))
      {
        nbrstk.push(symb);
	        symb = s[++i];
      }
	  
      while(!nbrstk.empty())
      {
        cout << nbrstk.top();
        nbrstk.pop();
      }
    }
  }
  cout << endl;
}

void print4(string s)
{
  string s1 = s;
  revstring(s1);
  if(s1==s)
    cout << "The string is a palindrome." << endl;
  else
    cout << "Not a Palindrome." << endl;
}

void print5( string s )
{
  string s1, s2;
  for(int pos=s.size(); pos>0; pos--)
  {
    s1 = s2 = s.substr(0, pos);
    revstring(s1);
    if(s1==s2)
    {
      cout << "The first " << pos << " characters form a palindrome." << endl;
      break;
    }
  }
}
