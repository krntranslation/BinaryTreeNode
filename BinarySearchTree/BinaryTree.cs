using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinarySearchTree
{

    public class BinaryTree
    {
        private Node root;
        public Node Root
        {
            get { return root; }
        }
        public void Insert(int data)
        {

            if (root != null)
            {
                root.Insert(data);
            }
            else
            {
                root = new Node(data);
            }
        }
        public Node Find(int data)
        {
            //if the root is not null then we call the find method on the root
            if (root != null)
            {
                // call node method Find
                return root.Find(data);
            }
            else
            {//the root is null so we return null, nothing to find
                return null;
            }
        }


    }
}      

  