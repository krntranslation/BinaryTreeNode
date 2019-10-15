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
            if (value >= data)
            {
                if (rightNode == null)
                {
                    rightNode = new Node(value);
                }
                else
                {
                    rightNode.Insert(value);
                }
            }
            else
            {
                if (leftNode == null)
                {
                    leftNode = new Node(value);
                }
                else
                {
                    leftNode.Insert(value);
                }
            }
        }
        public Node Find(int value)
        {
            Node currentNode = this;

            while (currentNode != null)
            {
                if (value == currentNode.data)
                {
                    return currentNode;
                }
                else if (value > currentNode.data)
                {
                    currentNode = currentNode.rightNode;
                }
                else
                {
                    currentNode = currentNode.leftNode;
                }
            }
            return null;

        }
    }
}

