using System;
using System.Collections.Generic;
using System.Text;

namespace Practice
{
    public static class Graphs
    {
        public static Dictionary<char, char[]> graph = new Dictionary<char, char[]>() {
            { 'a', new [] {'b','c' } },
            { 'b', new [] {'d' } },
            { 'c', new [] {'e' } },
            { 'd', new [] {'f' } },
            { 'e', null },
            { 'f', null },

        };

        public static void DepthFirstSearch(Dictionary<char, char[]> graph, char head) {
            Stack<char> stack = new Stack<char>(head);
            foreach(KeyValuePair<char, char[]> node in graph)
            {
                while (stack.Count > 0)
                {
                    var curr = stack.Pop();
                    Console.WriteLine(curr);
                    foreach (char c in graph[curr])
                    {
                        stack.Push(c);
                    }
                }
            }
        } 
    }
}
