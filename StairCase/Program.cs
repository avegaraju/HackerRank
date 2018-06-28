using System;

namespace StairCase
{
    class Program
    {
        static void staircase(int n) 
        {
             for (short i = 1; i <= n; ++i)
            {
                for (int j = 1; j <= n; ++j)
                {
                    if (j <= n - i)
                    {
                        Console.Write(" ");
                    }
                    else
                    {
                        Console.Write("#");
                    }
                }
                Console.WriteLine();
            }

        }

        static void Main(string[] args) {
            //int n = Convert.ToInt32(Console.ReadLine());

            staircase(5);
        }

        
    }
}
