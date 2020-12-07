using System;

namespace Final_Lab2
{
    class Program
    {
        static void Main(string[] args)
        {
            Calculator c = new Calculator();
            Console.WriteLine(" Sum = " + c.sum(15, 10));
            Console.WriteLine(" Sub = " + c.sub(15, 10));
            Console.WriteLine(" Multiplication = " + c.multiplication(15, 10));
            Console.WriteLine(" Division = " + c.division(15, 10));
            Console.WriteLine(" Power = " + c.XtoY(15, 10));
            Console.WriteLine(" Factorial = " + c.factorial(10));
        }
    }
}