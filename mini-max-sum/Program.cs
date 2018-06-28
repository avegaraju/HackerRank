using System;

namespace mini_max_sum
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = Array.ConvertAll(Console.ReadLine().Split(' '), arrTemp => Convert.ToInt32(arrTemp));
            miniMaxSum(arr);
        }

        static void miniMaxSum(int[] arr) 
        {
            long maxSum = 0;
            long minSum =0;

            for(int i=0; i<arr.Length;i++)
            {
                long sum = 0;
                for(int j=0; j< arr.Length; j++)
                {
                    if(i != j)
                    {
                        sum += arr[j];
                    }
                }

                if(i==0)
                {
                    maxSum = minSum = sum;
                }

                if(sum >= maxSum)
                    maxSum = sum;
                else if(sum <= minSum)
                    minSum = sum;
            }

            Console.Write(minSum + " " + maxSum);
            Console.ReadLine();
        }
    }
}
