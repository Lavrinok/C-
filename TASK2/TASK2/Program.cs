using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TASK2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Input count of numbers of array: ");
            int n = Convert.ToInt32(Console.ReadLine());
            int[] numbers = new int[n];
            int min = numbers[0];
            int max = numbers[0];

            for (int i = 0; i < n; i++)
            {
                Console.Write("Enter number {0}:  ",i + 1);
                numbers[i] = Convert.ToInt32(Console.ReadLine());
            }

            for (int i = 0; i < n; i++)
            {
                if (min > numbers[i]) min = numbers[i];
                if (max < numbers[i]) max = numbers[i];
            }
            Console.WriteLine("The minimum is:"+min);
            Console.WriteLine("The maximum is:"+ max);
            Console.ReadKey();
        }
    }
}
    
