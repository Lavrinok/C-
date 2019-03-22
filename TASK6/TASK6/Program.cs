using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace TASK6
{
    public class MyClass
    {
        public string Word { get; set; }
        public int Count { get; set; }
    }

    class Program
    {

        public static MyClass[] CreateArrOfObj(string input_string, string[] input_arr)
        {
            MyClass[] result = new MyClass[input_arr.Length];

            for (int i = 0; i < input_arr.Length; i++)
            {
                //int x = 0;
                //string[] input_stringMas = input_string.Split(' ', '.', ',', '-', '!', '?');
                //foreach (string p in input_stringMas)
                //{
                //    if (p == input_arr[i])
                //    {
                //        x++;
                //    }
                //}

                Regex regex = new Regex(input_arr[i], RegexOptions.IgnoreCase);
                string[] input_stringMas = input_string.Split(' ', '.', ',', '-', '!', '?');
                int x = 0;
                foreach (string p in input_stringMas)
                {
                    if (regex.IsMatch(p))
                        x++;
                }

                result[i] = new MyClass();
                result[i].Word = input_arr[i];
                result[i].Count = x;
            }
            return result;
        }


        static void Main(string[] args)
        {
            // Console.WriteLine("INPUT YOUR STRING: ");
            // string _LINE = Console.ReadLine();
            string input_string = "По по по по п о  .NET платформа платформа  ряд методов, ряд  int, double i т.д.";
            string[] input_arr = new string[] { "по", "NET", "ряд", "int"};



            MyClass[] mas_obj = CreateArrOfObj(input_string, input_arr);
            for (int i = 0; i < input_arr.Length; i++)
            {
                Console.WriteLine(i + "-слово в масивi " + input_arr[i]);
                Console.WriteLine(i + "-й об'єкт який має властивість: <<" + mas_obj[i].Word + ">> - i зустрічається: " + mas_obj[i].Count);
            }
            Console.ReadKey();
        }
    }
}