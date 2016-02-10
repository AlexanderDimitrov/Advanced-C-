using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_6.SubsetOfSums
{
    class Program
    {
        static void SubsetSumFinder(string input, int sum)
        {
            int[] arr = input.Split(' ').
                Select(int.Parse).ToArray();
            int tmpSum = 0;
            int maxSum = int.MinValue;
            int[] maxArray = new int[1];
            int curIndex = 0;
            List<int> tmpArray = new List<int>();
            if (arr.Length != 1)
            {
                for (int i = 0; i < arr.Length; i++)
                {
                    tmpSum = 0;
                    curIndex = i;
                    tmpArray.Clear();

                    while (curIndex < arr.Length)
                    {
                        tmpSum += arr[curIndex];
                        tmpArray.Add(arr[curIndex]);

                        if (tmpSum > maxSum)
                        {
                            maxSum = tmpSum;
                            maxArray = tmpArray.ToArray();
                        }
                        curIndex++;
                    }
                }
            }
            else
            {
                maxSum = arr[0];
                maxArray = arr;
            }
           
            Console.Write("{0}",maxSum);
        }
       


        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            int sum = int.Parse(Console.ReadLine());
            SubsetSumFinder(input,sum);
        }
    }
}
