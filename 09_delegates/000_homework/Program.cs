using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _000_homework
{
    public delegate double MediumDelegate(int a, int b, int c);
    class Program
    {
        static void Main(string[] args)
        {
            MediumDelegate mediumDelegate = new MediumDelegate(delegate(int a, int b, int c) { return (a + b + c) / 3; });
            double result = mediumDelegate.Invoke(1,2,3);
            Console.WriteLine(result);
            Console.ReadKey();
        }
    }
}
