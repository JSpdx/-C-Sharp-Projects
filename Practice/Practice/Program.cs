using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;

namespace Practice
{
    class Program
    {
        static void Main(string[] args)
        {
            string ReverseString(string str)
            {
                string answer = string.Empty;
                char[] cArray = str.ToCharArray();
                for (var i = str.Length -1; i > -1; i--)
                {
                    Console.WriteLine(cArray[i]);
                    answer += cArray[i];
                }
                //Console.WriteLine(answer);
                return answer;
            }
            //Console.WriteLine("Enter the string to reverse :");
            //string name = Console.ReadLine();

            //char[] cArray = name.ToCharArray();
            //string nameReverse = String.Empty;
            //for (int i = cArray.Length - 1; i > -1; i--)
            //{
            //    nameReverse += cArray[i];
            //}
            //Console.WriteLine(nameReverse);

            string answer = ReverseString("banana");
            Console.WriteLine(answer);


            //TreeNode head = new TreeNode(1);
            //TreeNode two = new TreeNode(2);
            //TreeNode three = new TreeNode(3);
            //TreeNode four = new TreeNode(4);
            //TreeNode five = new TreeNode(5);
            //TreeNode six = new TreeNode(6);
            //TreeNode seven = new TreeNode(7);

            //head.Left = two;
            //head.Right = three;
            //two.Left = four;
            //two.Right = five;
            //three.Left = six;
            //three.Right = seven;

            //head.PrintPostOrder(head);
        }
    }
}
