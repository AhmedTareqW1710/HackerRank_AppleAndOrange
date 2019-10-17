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

class Solution
{

    // Complete the countApplesAndOranges function below.
    static void countApplesAndOranges(int s, int t, int a, int b, int[] apples, int[] oranges)
    {
        int appleCount = 0;
        int orangeCount = 0;

        for (int i = 0; i < apples.Length; i++)
        {
            apples[i] = apples[i] + a;

            if (apples[i] < 0)
            {
                continue;
            }
            else if (apples[i] <= t && apples[i] >= s)
            {
                appleCount++;
            }

        }

        for (int j = 0; j < oranges.Length; j++)
        {

            oranges[j] = oranges[j] + b;

            if (oranges[j] < 0)
            {
                continue;
            }
            if (oranges[j] <= t && oranges[j] >= s)
            {
                orangeCount++;
            }
        }

        Console.WriteLine(appleCount);
        Console.WriteLine(orangeCount);
        Console.ReadKey();
    }

    static void Main(string[] args)
    {
        string[] st = Console.ReadLine().Split(' ');

        int s = Convert.ToInt32(st[0]);

        int t = Convert.ToInt32(st[1]);

        string[] ab = Console.ReadLine().Split(' ');

        int a = Convert.ToInt32(ab[0]);

        int b = Convert.ToInt32(ab[1]);

        string[] mn = Console.ReadLine().Split(' ');

        int m = Convert.ToInt32(mn[0]);

        int n = Convert.ToInt32(mn[1]);

        int[] apples = Array.ConvertAll(Console.ReadLine().Split(' '), applesTemp => Convert.ToInt32(applesTemp))
        ;

        int[] oranges = Array.ConvertAll(Console.ReadLine().Split(' '), orangesTemp => Convert.ToInt32(orangesTemp))
        ;
        countApplesAndOranges(s, t, a, b, apples, oranges);
    }
}
