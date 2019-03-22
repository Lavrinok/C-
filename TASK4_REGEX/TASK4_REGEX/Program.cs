using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace TASK4_REGEX
{
    class Program
    {
        static void Main(string[] args)
        {
            int word = 0;
            string pattern = "[\\w-]+";
            Regex regex = new Regex(pattern);
            string input = "I got this program               and i am so happy";
            foreach (Match m in Regex.Matches(input, pattern))
            {
                word++;
            }
            Console.WriteLine("Count of your input words is :"+ word);
            Console.ReadKey();
        }
    }
}
