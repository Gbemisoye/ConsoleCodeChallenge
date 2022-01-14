using System;

namespace Question2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            SubSequence();

        }
        public static void SubSequence()
        {
            int[] input = { 10, 9, 2, 5, 3, 7, 101, 18 };
              
            int count = 0;
            //int longestCount = 0;
            for (int i = 0; i < input.Length-1; i++)
            {
            
                    if (input[i] <= input[i+1])
                    {
                        count++;   
                    }              
            }
            Console.WriteLine(count);
        }
    }
}
