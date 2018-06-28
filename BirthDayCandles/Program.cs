using System;
using System.Collections.Generic;
using System.Linq;

namespace BirthDayCandles
{
    class Program
    {
        static void Main(string[] args)
        {
            //int arCount = Convert.ToInt32(Console.ReadLine());

            //int[] ar = Array.ConvertAll(Console.ReadLine().Split(' '), arTemp => Convert.ToInt32(arTemp))        ;
            int[] ar = new[]{3, 2, 1, 3, 5,5,5};
            
            int result = birthdayCakeCandles(ar);

            Console.WriteLine(result);

        }

        static int birthdayCakeCandles(int[] ar) 
        {
            int tallestCandle =0;
            Dictionary<int, int> tallestCandleCount = new Dictionary<int,int>();
            
            for(int i=0; i< ar.Length ;i++)
            {
                if(ar[i] >= tallestCandle)
                {
                    tallestCandle = ar[i];
                    
                    if(tallestCandleCount.ContainsKey(tallestCandle))
                        tallestCandleCount[tallestCandle]++;
                    else
                        tallestCandleCount.Add(tallestCandle,1);
                }
            }

            return tallestCandleCount.OrderByDescending(kvp=> kvp.Value).First().Value;
        }
    }
}
