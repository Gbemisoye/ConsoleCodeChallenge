 using System;

namespace Question1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the number: ");
            int number = int.Parse(Console.ReadLine());
            StairCase(number);



            Console.ReadKey();
        }
        public static void StairCase(int number)
        {
            int maximum, current;
            int remainder = 0, row = number;

            while (remainder <= row)
            {
                maximum = remainder + (row - 1)/2;
                current = maximum *(maximum + 1) / 2;
                if(current == number)
                {
                    Console.WriteLine(maximum);
                }
                if(number < current)
                {
                    row = current - 1;
                }
                else
                {
                    remainder = current + 1;
                }
            }
        }


        public static void Stair(int num)
        {
            for (int i = 1; i <= num; i++)
            {
                for (int k = 1; k <= i; k++)
                {
                    Console.Write(k + " ");
                }
                Console.WriteLine();
            }

        }

    }
    
}
