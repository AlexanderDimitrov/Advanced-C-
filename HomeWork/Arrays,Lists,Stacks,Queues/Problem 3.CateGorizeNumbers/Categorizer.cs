using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_3.CateGorizeNumbers
{
    class Program
    {
        static void NumberCategorizer(string input)
        {
            double[] numbers = input.Split(' ').
                Select(double.Parse).ToArray();

            List<double> roundNumbers = new List<double>();
            List<double> floatingNumbers = new List<double>();

            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i]%1 != 0)
                {
                    floatingNumbers.Add(numbers[i]);
                }
                else
                {
                    roundNumbers.Add(numbers[i]);
                }
                
            }
            Console.WriteLine("Round Numbers :");
            Console.WriteLine("Min :{0}",roundNumbers.Min());
            Console.WriteLine("Max :{0}",roundNumbers.Max());
            Console.WriteLine("Avarage :{0}",roundNumbers.Average());

            Console.WriteLine("Floating Point Numbers :");
            Console.WriteLine("Min :{0}", floatingNumbers.Min());
            Console.WriteLine("Max :{0}", floatingNumbers.Max());
            Console.WriteLine("Avarage :{0}", floatingNumbers.Average());

        }
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            NumberCategorizer(input);
        }
    }
}
