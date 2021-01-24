using System;
using System.Collections.Generic;
using System.Text;

namespace Practice
{
    class TreeNode
    {
        public TreeNode(int val)
        {
            this.val = val;
        }
        public TreeNode Left { get; set; }
        public TreeNode Right { get; set; }
        public int val { get; set; }

        public void PrintPostOrder(TreeNode node)
            {
                
                if (node.Left != null)
                {
                    PrintPostOrder(node.Left);
                }
                if (node.Right != null)
                {
                    PrintPostOrder(node.Right);
                }
                Console.WriteLine(node.val);
                return;
        }

            
    
        
    }

    

}
