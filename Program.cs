﻿/* 
  Author: Cody Jones
  Date: 2/4/21
  Comments: This C# console application demonstrates the use of
            arrays with no user input.
*/
using System;

namespace Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20, 21, 22, 23, 24, 25 };
            foreach (int i in array)
            {
                Console.WriteLine(i);

            }
        }
    }
}
