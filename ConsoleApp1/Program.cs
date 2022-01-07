using System;
using System.Collections.Generic;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums = new int [6] {1, 1, 1, 2, 2, 3};
            NumMoreThanTwo(nums,6);

        }
        public static void NumMoreThanTwo(int[]numns, int number)
        {
            int[] nums = new int[number];

            List<int> k = new List<int>();
            int count = 0;
            int two = 2;
            for (int i = 0; i < nums.Length; i++)
            {
                count = 0;
                for (int j = i+1; j < nums.Length; j++)
                {
                    if (nums[i] == nums[j])
                    {
                         count++;
                    }

                }
                if (count <= 2)
                {
                    k[i] = count;
                }
                
            }
            foreach (var item in k)
            {
                Console.WriteLine($" {k}, {item}");
            }

        }
    }

}



