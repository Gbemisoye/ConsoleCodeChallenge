using System;
using System.Collections.Generic;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            string[] words = { "abcw", "baz", "foo", "bar", "xtfn", "abcdef" };
            bool newWord = true;
            int number = 0;
            int max = 0;
            var newList = new List<int>();
            for (int i = 0; i < words.Length; i++)
            {
                for (int j = 0; j < words.Length - 1; j++)
                {
                    newWord = words[i].Contains(words[j]);
                    if (newWord != true && words[i].Length == words[j].Length)
                    {
                        number = words[i].Length * words[j].Length;
                        newList.Add(number);
                    }
                   
                }
            }
            foreach (var numb in newList )
            {
                if (numb > max)
                {
                    max = numb;
                }
                
            }
            Console.WriteLine(max);
        }
    }
}
