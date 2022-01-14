using System;

namespace Question1
{
    class Program
    {
        static void Main(string[] args)
        {
            BiggestNumber();
        }
        public static void BiggestNumber()
        {
            int[] input = { 3, 30, 34, 5, 9 };
            string number = Convert.ToString(input).Substring(0,1);

            // int nums = new int[number.Length];
            int nums = Convert.ToInt32(number);
           
            for (int i  = 0; i  < number.Length - 1; i ++)
            {
                for (int j = i + 1; j < number.Length; j++)
                {
                    if (number[i] > number[i + 1])
                    {
                        Console.WriteLine(i);
                    }
                }
            }

        }
    }
}
