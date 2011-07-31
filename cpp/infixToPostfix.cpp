// Caleb Wherry
// 16 March 2010
// Programming Assignment #1
// CSCI 3250
// Dr. Bateman
// Execution style:
// -> assign1Wherry "(A+B)-(C*D)"
// In order for bash (or whichever shell you are using) to
//   correctly read the input, quotes will have to enclose
//   the infix argument. Spaces will be taken out at the
//   beginning of the program.

#include <iostream>
#include <iomanip>
#include <string>
#include <queue>
#include <stack>

using namespace std;

struct BinaryTree {

  char data;
  BinaryTree* left;
  BinaryTree* right;

};

void preOrderTraversal(BinaryTree* tree, int level);
void breadthFirstTraversal(BinaryTree* tree);

int main (int argc, char* argv[]) {

  // Return if wrong number of arguments:
  if (argc != 2) {
    cout << endl;
    cout << "Error: Wrong number of arguments!" << endl;
    cout << "Execution sequence should have format: " << endl;
    cout << argv[0] << " \"(A + B) - (D * E)\"" << endl << endl;
    return 1;
  }

  // Command line input variables:
  string initial_input = argv[1];
  string input = "";

  // Take all spaces out of command line input stream: 
  for ( int i = 0; i < initial_input.length(); i++) {
    if ( initial_input[i] != ' ' )
      input += initial_input[i];
  }

  cout << endl;
  cout << "Input: " << input << endl << endl;
  cout << "Outputs: " << endl;

  // Here we convert from infix to postfix:
  /***************************************************/
  // Stack for keeping up with groupings:
  stack<char> s1;
  char token = ' ';
  string postfix = "";

  for (int i = 0; i < input.length(); i++) {
    token = input[i];

    switch(token) {

      case '(': s1.push(token);

                break;

      case ')': while( s1.top() != '(' ) {
                  postfix += s1.top();
                  s1.pop();
                }
                s1.pop();

                break;

      case '/':
      case '*': if ( s1.empty() ) {
                  s1.push(token); 
                  break;
                }

                if ( s1.top() == '*' || s1.top() == '/' ) {
                  while (s1.top() != '(' ) {
                    if( s1.top() == '*' || s1.top() == '/' ) {
                      postfix += s1.top(); 
                      s1.pop();
                    }
                    else
                      break;
                  }
                  s1.push(token);
                }
                else
                  s1.push(token);

                break;

      case '+':
      case '-': if ( s1.empty() ) {
                  s1.push(token);
                  break;
                }     

                if ( s1.top() == '+' || s1.top() == '-' || s1.top() == '*' || s1.top() == '/' ) {
                  while( s1.top() != '(' ) {
                    if( s1.top() == '+' || s1.top() == '-' || s1.top() == '*' || s1.top() == '/' ) {
                      postfix += s1.top();
                      s1.pop();
                    }
                    else 
                      break;
                  }
                  s1.push(token);
                }
                else
                  s1.push(token);

                break;

      default:
               postfix += token;
    }
  }

  // Pop rest of stack:
  while( !s1.empty() ) {
    postfix += s1.top();
    s1.pop();
  }

  cout << "Postfix:\t" << postfix << endl;
  /**************************************************************/

  // Here we convert from postfix to expression tree:
  /*************************************************************/
  stack<BinaryTree*> s2;

  for (int i = 0; i < postfix.length(); i++) {
    token = postfix[i];

    if( token == '+' || token == '-' || token == '*' || token == '/' ) {
      
      BinaryTree* tree = (BinaryTree*)malloc(sizeof(BinaryTree));

      tree->data = token;

      tree->right = s2.top();
      s2.pop();

      tree->left = s2.top();
      s2.pop();

      s2.push(tree);
    }
    else {

      BinaryTree* tree = (BinaryTree*)malloc(sizeof(BinaryTree));

      tree->data = token;
      tree->left =  NULL;
      tree->right = NULL;

      s2.push(tree);
    }
 
  }
  /************************************************************/

  // Root node for rest of calculations:
  BinaryTree* root = s2.top();
 
  // Print out tree in preoder form to make expression tree:
  /***********************************************************/
  cout << "Expression Tree:" << endl; 
  preOrderTraversal( root, 0 );
  cout << "=====" << endl;
  /**********************************************************/


  // Breadth first traversal using a queue:
  /*********************************************************/
  cout << "Breadth First Traversal:" << endl;
  breadthFirstTraversal( root );
  cout << endl << endl;
/*********************************************************/

  return 0;
}

void preOrderTraversal( BinaryTree* tree, int level ) {

  int levelIndent = 4*level;

  cout << setw(levelIndent) << tree->data << endl;
  level++;

  if ( tree->left != NULL)  
    preOrderTraversal( tree->left, level );
  if ( tree->right != NULL)
    preOrderTraversal( tree->right, level );

}

void breadthFirstTraversal( BinaryTree* tree ) {

  queue<BinaryTree*> q1;
  queue<int> q2;
  BinaryTree* currentTree;
  int level = 0, currentLevel = 0;

  q1.push( tree );
  q2.push( level );

  while ( !q1.empty() ) {
    
    currentTree = q1.front();
    q1.pop();
    level = q2.front();
    q2.pop();

    if (currentLevel != level) {
      cout << endl;
      currentLevel = level;
    }

    cout << currentTree->data;

    if (currentTree->left != NULL) {
      q1.push(currentTree->left);
      q2.push(level+1);
    }
    if (currentTree->right != NULL) { 
      q1.push(currentTree->right);
      q2.push(level+1); 
    }

  }

}
