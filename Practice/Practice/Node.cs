using System;
using System.Collections.Generic;
using System.Text;

namespace Practice
{
    public class Node
    {
        public Node(int val, Node left = null, Node right = null)
        {
            this.val = val;
            this.left = left;
            this.right = right;
        }
        public Node left { get; set; }
        public Node right { get; set; }
        public int val { get; set; }

        public void PrintPostOrder(Node node)
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


            
    
        
    }

    

}
