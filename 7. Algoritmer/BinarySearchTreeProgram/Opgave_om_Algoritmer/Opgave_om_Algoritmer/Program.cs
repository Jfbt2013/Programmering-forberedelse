using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opgave_om_Algoritmer
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Binary Search Tree");

            BinaryTree binaryTree = new BinaryTree();

            binaryTree.Insert(5);
            binaryTree.Insert(8);
            binaryTree.Insert(9);
            binaryTree.Insert(6);
            binaryTree.Insert(2);
            binaryTree.Insert(1);
            binaryTree.Insert(4);
            
            
            


            Console.WriteLine("In Order Traversal (Left->Root->Right)");
            binaryTree.InOrderTraversal();
            //Console.WriteLine("Get the number of leaf nodes");
            //Console.WriteLine(binaryTree.NumberOfLeafNodes());
            Console.WriteLine("Get the height of the tree");
            Console.WriteLine(binaryTree.Height());

            //Check if the binary tree is balanced. A balanced tree occurs when the height of two subtrees of any node do not differe more than 1.
            bool balanced = binaryTree.IsBalanced();

            Console.ReadKey();

        }

        public static int getHeight(TreeNode root)
        {
            if (root == null)
            {
                return 0;
            }

            return Math.Max(getHeight(root.LeftNode), getHeight(root.RightNode)) + 1;
        }

        public static bool isBalanced(TreeNode root)
        {
            if (root == null)
            {
                return true;
            }

            int heightDiff = getHeight(root.LeftNode) - getHeight(root.RightNode);
            if (Math.Abs(heightDiff) > 1)
            {
                return false;
            }
            else
            {
                return (isBalanced(root.LeftNode) && isBalanced(root.RightNode));
            }
        }
        
    }
}
