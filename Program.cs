using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] names = new string[2];
            names[0] = "Eric";
            names[1] = "Mark";

            int[] numbers = { 4, 7, 3, 0, 5 };

            Console.WriteLine("printing out some elements from an array of strings");
            for (int i = 0; i < names.Length; i++)
            {
                Console.WriteLine(names[i]);
            }

            Console.WriteLine("Printing out an array of integers");
            foreach (int num in numbers)
            {
                Console.WriteLine(num);
            }

            Console.WriteLine("Sorting the array");
            Array.Sort(numbers);

            foreach (int num in numbers)
            {
                Console.WriteLine(num);
            }

            Console.ReadKey();

        }
    }
}
