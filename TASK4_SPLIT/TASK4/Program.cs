using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace TASK4
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = "Hello Svitlana you are so beautiful girl Andriz";
            char[] separator = {' '};
            int WordsCount = text.Split(separator, StringSplitOptions.RemoveEmptyEntries).Length;
            Console.WriteLine("Count of words : "+WordsCount);
            Console.ReadKey(); 
        }
    }
}
