using System;
using System.Collections.Generic;

namespace Practice
{ 
    class Program
    {
        static void Main(string[] args)
        {
            var lc = new LetterCombinationsOfAPhoneNumber();
            var answer = lc.LetterCombinations("23");

            //public static Dictionary<char, char[]> graph = new Dictionary<char, char[]>()
            //{ 
            //    { 'a', new [] {'b','c' } },
            //    { 'b', new [] {'d' } },
            //    { 'c', new [] {'e' } },
            //    { 'd', new [] {'f' } },
            //    { 'e', null },
            //    { 'f', null }
            //};
        }
    }
}
