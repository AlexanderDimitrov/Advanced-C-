using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_4.SequenceOfEqualStrings
{
    class Program
    {
        static void StringEqualizer(string input)
        {
            string[] arrStrings = input.Split().ToArray();

            for (int i = 0; i < arrStrings.Length - 1; i++)
            {
                Console.Write(arrStrings[i] + " ");
                if (!arrStrings[i].Equals(arrStrings[i + 1]))
                {
                    Console.WriteLine();
                }
            }
            Console.Write(arrStrings[arrStrings.Length - 1]);
            Console.WriteLine();



        }

        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            StringEqualizer(input);
        }
    }
}
