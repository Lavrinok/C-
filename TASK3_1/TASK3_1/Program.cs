using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TASK3_1
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] a = { 7, 72, 6, 13, 9, 45, 12, 99, 100 };
            List<int> numbers = new List<int>();
            int min = 6;
            int max = 100;
            for (int i = 0; i < a.Length; i++)
            {
                if (a[i] > min && a[i] < max)
                {
                    numbers.Add(a[i]);
                }
            }
            foreach (int i in numbers)
            {
                Console.WriteLine("Element in list: numbers: " + i);
            }
            Console.ReadKey();
        }
    }
}
