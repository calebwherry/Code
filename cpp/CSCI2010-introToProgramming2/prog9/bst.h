#ifndef BINSEARCHTREE
#define BINSEARCHTREE

#include <iostream>

using namespace std;

template<class T>



class BinSearchTree
{
    friend ostream& operator<< (ostream& out_stream, BinSearchTree<T>& tree)
    {
        for (Iterator itr = tree.begin(); itr != tree.end(); itr++)
            out_stream << *itr << endl;
        return out_stream;
    } // overloading <<

protected:

        struct tree_node
        {
            T item;
            tree_node* parent,
                     * left,
                     * right;
            bool isHeader;
        }; // Node

        typedef tree_node* Link;

        Link header;
        long node_count;

    public:

        class Iterator;
        friend class Iterator;


        
		
		
	// Postcondition: this BinSearchTree is empty.
        BinSearchTree ()
        {
            header = new tree_node;
            header -> parent = NULL;
            header -> left = header;
            header -> right = header;
            header -> isHeader = true;
            node_count = 0;
        } //  default constructor

        // Postcondition: The space allocated for this BinSearchTree has been
        //                deallocated.  The worstTime(n) is O(n).
        ~BinSearchTree( )
        {
            destroy(header -> parent);
        }//destructor

        void destroy (Link link)
        {
    	     if (link != NULL)
    	     {
                destroy (link -> left);
        	destroy (link -> right);
        	delete (link);
    	      } // if
         } // destroy method


        // Postcondition: the number of items in this BinSearchTree
        //                has been returned.
        unsigned size() const
        {
              return node_count;
        } // size


        // Postcondition: item has been inserted into this BinSearchTree. An iterator 
        //                positioned at the inserted item has been returned. The
        //                averageTime(n) is O(log n) and worstTime(n) is O(n).

        Iterator insert (const T& item)
        {
            if (header -> parent == NULL)
            {
                insertLeaf (item, header, header -> parent);
                header -> left = header -> parent;
                header -> right = header -> parent;
                return header -> parent;
             } // inserting at tree's root
             else
             {
                 Link parent = header,
                               child = header -> parent;

                 while (child != NULL)
                 {
                     parent = child;
                     if (item < child -> item)
                         child = child -> left;
                     else
                         child = child -> right;
                 } // while
                 if (item < parent -> item)
                 {
                     insertLeaf (item, parent, parent -> left);
                     if (header -> left == parent) // parent -> item is smallest item
                          header -> left = parent -> left;
                     return parent -> left;
                 } // insert at left of parent
                 else
                 {
                     insertLeaf (item, parent, parent -> right);
                     if (header -> right == parent) //parent -> item is largest item
                         header -> right = parent -> right; // child is rightmost
                     return parent -> right;
                 } // insert at right of parent
             } // tree not empty
         } // insert


         class Iterator
         {
             friend class BinSearchTree<T>;

             protected:

                 Link link;
                 Iterator (Link new_link) : link (new_link) {}

             public:

                 Iterator () {}
                 Iterator& operator++ ()
                 {
                      Link tempLink;

                      if ((link -> right) != NULL)
                      {
                          link = link -> right;
                          while ((link -> left) != NULL)
                              link = link -> left;
                      } // node has right child
                      else
                      {
                          tempLink = link -> parent;
                          while (link == tempLink -> right)
                          {
                              link = tempLink;
                              tempLink = tempLink -> parent;
                          } // moving up and leftward as far as possible
                          if ((link -> right) != tempLink)
                              link = tempLink;
                      } // node has no right child
                      return *this;
                 } // prefix ++

                 Iterator operator++ (int)
                 {
                     Iterator temp = *this;
                     ++(*this);
                     return temp;
                 } // postfix ++
                 Iterator& operator-- ()
                 {
                     if (link -> isHeader)
                        link = link -> right;   // Return rightmost.
                     else if (link -> left != NULL)
                     {
                         Link y = link -> left;
                         while (y -> right != NULL)
                             y = y -> right;
                         link = y;
                     } // link -> left != NULL
                     else
                     {
                         Link y = link -> parent;
                         while (link == y -> left)
                         {
                             link = y;
                             y = y -> parent;
                         } // while moving up and rightward
                         link = y;
                     } // link -> left == NULL
                     return *this;
             } // pre-decrement operator

            T& operator* () const { return link -> item; }
            bool operator== (const Iterator &otherIterator)const
            {
                return link == otherIterator.link;
            } //operator ==
            bool operator!= (const Iterator &otherIterator)const
            {
                return link != otherIterator.link;
            } // operator !=

      }; // Iterator


      // Postcondition: if this BinSearchTree is non-empty, an iterator positioned
      //                at the smallest item in the tree has been returned.
      //                Otherwise, the iterator returned has the same value as the
      //                iterator returned by the end( ) method.
      Iterator begin () { return header -> left; }


      // Postcondition: the value returned is an iterator that can be used in a 
      //                comparison for ending the traversal of this BinSearchTree.
      //                If this BinSearchTree is non-empty, the largest item is in the
      //                position just before the position of the iterator returned.
      Iterator end () { return header; }


      // Postcondition: if there is an item in this BinSearchTree that equals item,
      //                the value returned is an iterator pointing to that item.
      //                Otherwise, the value returned is an iterator with the same
      //                value as the iterator returned by the end( ) method.  The
      //                averageTime(n) is O(log n) and worstTime(n) is O(n).
      Iterator find (const T& item)
      {
          Link parent = header;
          Link child = header -> parent;
          while (child != NULL)
          {
              if (!(child -> item < item))
              {
                  parent = child;
                  child = child -> left;
              } // item <= child -> item
              else
                  child = child -> right;
          } // while

          if (parent == header || item < parent -> item)
              return end();
          else
              return parent;   // automatic type casting
      } // find

      // Precondition: itr is positioned at an item in this BinSearchTree.
      // Postcondition: the item that itr is positioned at has been deleted from
      //                this BinSearchTree.  The averageTime(n) is O(log n)
      //                and worstTime(n) is O(n).

      void erase (Iterator itr)
      {
          if (itr.link -> parent -> parent == itr.link)
              deleteLink (itr.link -> parent -> parent);
          else if (itr.link -> parent -> left == itr.link)
              deleteLink (itr.link -> parent -> left);
          else
              deleteLink (itr.link -> parent -> right);
       } // erase


    protected:

        // Postcondition: A copy of item has been inserted in the tree at the
        //                child of the given parent.
        void insertLeaf (const T& item, Link parent, Link& child)
        {
            child = new tree_node;
            child -> item = item;
            child -> parent = parent;
            child -> left = NULL;
            child -> right = NULL;
            child -> isHeader = false;
            node_count++;
        } // insertLeaf


        // Precondition: the subtree pointed to by link has at most one child.
        // Postcondition: The item pointed to by link has been deleted from this BinSearchTree.
        void prune (Link& link)
        {
            Link linkCopy = link,
                 newLink;

            node_count--;
            if ((link -> left == NULL) && (link -> right == NULL))
            {
                if (link == header -> left)
                    header -> left = link -> parent; // new leftmost
                if (link == header -> right)
                    header -> right = link -> parent; // new rightmost
                link = NULL;
            } // link's node is a leaf
            else if (link -> left == NULL)
            {
                link = link -> right;
                link -> parent = linkCopy -> parent;
                if (linkCopy == header -> left)
                {
                    newLink = link;
                    while ((newLink -> left) != NULL)
                        newLink = newLink -> left;
                    header -> left = newLink;  // new leftmost
                } // re-calculate leftmost
            } // link -> left nonempty
            else
            {
                 link = link -> left;
                 link -> parent = linkCopy -> parent;
                 if (linkCopy == header -> right)
                 {
                      newLink = link;
                      while ((newLink -> right) != NULL)
                          newLink = newLink -> right;
                      header -> right = newLink; // new rightmost
                 } // re-calculate rightmost
            } // root -> right nonempty
            delete linkCopy;
       } // prune


       // Postcondition: The item that had been the link item has been
       //                deleted.
       void deleteLink (Link& link)
       {
            T item = link -> item;
            Link parent = link -> parent;

            if (link -> left == NULL || link -> right == NULL) //the item has no children
                prune (link);
            else if (link -> right -> left == NULL)
            {
                parent = link;
                link -> item = link -> right ->item;
                prune(link -> right);
            } // empty left subtree

            else
            {
              Link temp = link -> right -> left;
              while (temp -> left != NULL)
                temp = temp -> left;
              parent = temp -> parent;
              link -> item = temp -> item;
              prune (temp -> parent -> left);
              
            } //neither subtree empty
       } // deleteLink



}; // BinSearchTree


#endif
