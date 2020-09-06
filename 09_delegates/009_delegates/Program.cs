using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _009_delegates
{
    public delegate void MulticastDelegate();
    class Program
    {
        static void Main(string[] args)
        {
            MulticastDelegate multicastDelegate = new MulticastDelegate(delegate () { Console.WriteLine("Hello1"); });
            multicastDelegate += delegate () { Console.WriteLine("Hello2"); };
            multicastDelegate += () => Console.WriteLine("Hello3");
            multicastDelegate.Invoke();
            Console.ReadKey();
        }
    }
}
