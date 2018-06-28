using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Collections;
using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.Serialization;
using System.Text.RegularExpressions;
using System.Text;
using System;

class Solution {

    // Complete the rotLeft function below.
    static int[] rotLeft(int[] a, int d) 
    {
         int[][] arr = new int[][]{};

for(int i=0; i< arr.Length-1;i++)
{

}

        var temp = a[0];
        for(int i=0;i< a.Length-1; i++)
        {
            a[i] = a[i+1];
            
        }
        a[a.Length-1] = temp;
        
        

        if(d > 1)
        {
        return rotLeft(a, --d);
        }

        else
        return a;


    }

    static void Main(string[] args) {
        //TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        //string[] nd = Console.ReadLine().Split(' ');

        var a = new []{
1,2,3,4,5
        };
        int[] result = rotLeft(a, 4);

        Console.WriteLine(string.Join(" ", result));

        
    }
}
