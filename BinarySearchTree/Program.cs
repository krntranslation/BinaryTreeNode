using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinarySearchTree
{
    class Program
    {
        static void Main(string[] args)
        {
            BinaryTree binaryTree = new BinaryTree();
           
            binaryTree.Insert(5);
            binaryTree.Insert(2);
            binaryTree.Insert(3);
            binaryTree.Insert(7);
            binaryTree.Insert(8);
            binaryTree.Insert(6);
            binaryTree.Insert(1);

            Node node = binaryTree.Find(8);
            Console.WriteLine(binaryTree.Find(8));
            Console.ReadLine();



        }
    }
}
