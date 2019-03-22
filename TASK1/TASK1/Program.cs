using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TASK1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter 1 number: ");

            float bigNumb = float.Parse(Console.ReadLine());
            Console.WriteLine("Please enter 2 number: ");
            float smalNumb = float.Parse(Console.ReadLine());

            if (smalNumb > bigNumb)
            {
                bigNumb = smalNumb;
            }

            Console.WriteLine("The greater number is: " + bigNumb);
            Console.ReadKey();
        }
        
    }
  
}
