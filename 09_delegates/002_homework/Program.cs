using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _002_homework
{
    class Program
    {
        public delegate double ArithmeticDelegate(int a, int b);
        static void Main(string[] args)
        {
            ArithmeticDelegate plus = (a, b) => a + b;
            ArithmeticDelegate minus = (a, b) => a - b;
            ArithmeticDelegate multiply = (a, b) => a * b;
            ArithmeticDelegate divide = (a, b) => a / b;

            Console.WriteLine(plus.Invoke(3,4));
            Console.WriteLine(minus.Invoke(4,4));
            Console.WriteLine(multiply.Invoke(4,5));
            Console.WriteLine(divide.Invoke(12,4));
            Console.ReadLine();
        }
    }
}
