using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TASK5
{
    class MyClass
    {


        public double Sum(double x, double y)
        {
            return x + y;
        }
        
        public double Sub(double x, double y)
        {
            return x-y;
        }
        
        public double Mult(double x, double y)
        {
            return x * y;
        }
  
        public double Div(double x, double y)
        {
            return x / y;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            MyClass obj = new MyClass();
            double x = 4;
            double y = 10;
            Console.WriteLine("Print result = " + obj.Sub(obj.Sum(x, obj.Mult(x,5)), obj.Div(y,2)) + ";");
            Console.ReadKey();
        }
    }
}
