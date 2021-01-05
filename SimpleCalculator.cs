using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Final_second_lab
{
    class SimpleCalculator : IBasicCalculatorInterface
    {
        public SimpleCalculator()
        {
            Console.WriteLine("Simple calculator.");
        }
        public int division(int x, int y)
        {
            Console.WriteLine("Divison : " + (x / y));
            return x / y;
        }

        public int multiplication(int x, int y)
        {
            Console.WriteLine("Multiplication : " + (x * y));
            return x * y;
        }

        public int sub(int x, int y)
        {
            Console.WriteLine("Subtraction : " + (x - y));
            return x - y;
        }

        public int sum(int x, int y)
        {
            Console.WriteLine("Summation : " + (x + y));
            return x + y;
        }
    }
}