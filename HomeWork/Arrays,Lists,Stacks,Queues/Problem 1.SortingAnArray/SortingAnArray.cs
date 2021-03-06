﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_1.SortingAnArray
{
    class SortingAnArray
    {
        static void SortingArray(int[] arr)
        {
            int minimumPosition = 0;
            int tempNumber = 0;
            for (int i = 0; i < arr.Length - 1; i++)
            {
                minimumPosition = i;
                for (int j = i + 1; j < arr.Length; j++)
                {
                    if (arr[j] < arr[minimumPosition])
                    {
                        minimumPosition = j;

                    }
                }

                if (minimumPosition != i)
                {
                    tempNumber = arr[i];
                    arr[i] = arr[minimumPosition];
                    arr[minimumPosition] = tempNumber;
                }
        }

            foreach (var value in arr)
            {
                Console.Write(value + " ");
            }


        }
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your desired numbers to be sorted separated by space ");

            string input = Console.ReadLine();
            int[] arr = input.Split(' ').Select(n => Convert.ToInt32(n)).ToArray();
            SortingArray(arr);

            Console.WriteLine();
            
        }
    }
}
