using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _008_delegates
{
    public delegate int AnonymousDelegate(int x); //class-delegate
    class Program
    {
        static void Main(string[] args)
        {
            // lambda operatorebis ganvitarebis stadiebi
            //AnonymousDelegate anonymousDelegate = new AnonymousDelegate(delegate (int x) { return x * 2; });
            //AnonymousDelegate anonymousDelegate = delegate (int x) { return x * 2; };
            AnonymousDelegate anonymousDelegate = (x) => (x * 2);
            Console.WriteLine(anonymousDelegate(4));
            Console.WriteLine(anonymousDelegate.Invoke(4));
            Console.ReadLine();
        }
    }
}
