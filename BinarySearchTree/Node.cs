using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinarySearchTree
{
    public class Node
    {
        private Node rightNode;
        public Node RightNode
        {
            get { return rightNode; }
            set { rightNode = value; }
        }
        private Node leftNode;
        public Node LeftNode
        {
            get { return leftNode; }
            set { leftNode = value; }
        }
        private int data;
        public int Data
        {
            get { return data; }
        }
        public Node(int value)
        {
            data = value;
        }
        public void Insert(int value)
        {
            if (value >= data)//if the value passed in is >= to the data then insert to right side
            {
                if (rightNode == null)//if right child node is null create new node
                {
                    rightNode = new Node(value);//creating a node
                }
                else
                {
                    rightNode.Insert(value);//if right node is not null, insert on the right node
                }
            }
            else
            {
                if (leftNode == null)//if the value passed in is < the data then insert to left side
                {
                    leftNode = new Node(value);//if the leftnode is null then create new node
                }
                else
                {
                    leftNode.Insert(value);//if the left node is not null then insert on the left node
                }
            }
        }
        public Node Find(int value)
        {
            Node currentNode = this;//this node is the starting current node

            while (currentNode != null)//loop through this node and all of the children of this node
            {
                if (value == currentNode.data)//if the current nodes data is == to the value passed in return it
                {
                    return currentNode;
                }
                else if (value > currentNode.data)//if the value passed in is greater than the current data then go to the right child
                {
                    currentNode = currentNode.rightNode;
                }
                else//otherwise if the value is less than the current nodes data the go to the left child node 
                {
                    currentNode = currentNode.leftNode;
                }
            }
            return null;

        }
    }
}

