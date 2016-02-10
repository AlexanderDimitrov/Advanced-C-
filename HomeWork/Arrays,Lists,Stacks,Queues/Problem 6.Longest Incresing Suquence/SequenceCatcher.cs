using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_6.Longest_Incresing_Suquence
{
    class SequenceCatcher
    {
        static void SequenceFinder(string input)
        {
            var arr = input.Split(' ').
                Select(n => Convert.ToInt32(n)).ToArray();
            int end = 0;
            int minimumIndex = 0;
            int maximumIndex = 0;

            Console.Write(arr[0] + " ");
            for (int i = 1; i < arr.Length -1; i++)
            {
                if (arr[i] > arr[i - 1])
                {
                    minimumIndex++;
                    Console.WriteLine(arr[i] + " ");
                }

                else
                {
                    minimumIndex = 1;
                    Console.WriteLine();
                    Console.Write(arr[i]+ " ");
                }
                if (minimumIndex > maximumIndex)
                {
                    maximumIndex = minimumIndex;
                    end = i;
                }
            }
            Console.WriteLine();
            Console.Write("Longest :");
            for (int i = end - maximumIndex + 1; i <= end; i++)
            {
                Console.Write(arr[i] + " ");
            }
        }
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            SequenceFinder(input);
        }
    }
}
