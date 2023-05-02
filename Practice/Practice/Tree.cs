using System;
using System.Collections.Generic;
using System.Text;

namespace Practice
{
    public static class Tree
    {
        
        public static void PrintPostOrder(Node node)
        {

            if (node.left != null)
            {
                PrintPostOrder(node.left);
            }
            if (node.right != null)
            {
                PrintPostOrder(node.right);
            }
            Console.WriteLine(node.val);
            return;
        }
        public static bool IsValidBST(Node root)
        {
            if (root.left == null && root.right == null)
            {
                return true;
            }
            if (root.left != null)
            {
                if (root.left.val >= root.val)
                {
                    return false;
                }
            }
            if (root.right != null && root.right.val <= root.val)
            {
                return false;
            }
            bool result = IsValidBST(root.left);
            if(result == true)
            {
                result = IsValidBST(root.left);
            }

            return result;
            

        }

    }
}
