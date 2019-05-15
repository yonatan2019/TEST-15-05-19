using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test1505part4q2
{
    class Program
    {
        static void Main(string[] args)
        {
            Rational r = new Rational(4,8);
            Rational r1 = new Rational(-1,6);
            Rational r2 = new Rational(5,5);
            Console.WriteLine(r2);
            Console.WriteLine(r1);

            Rational r3 = new Rational(2,3);
            Rational r4 = new Rational(2,3);
            Console.WriteLine(r3);
            Console.WriteLine(r4);

            Console.WriteLine(r3.GreaterThen(r4));
            Console.WriteLine(r3.Equals(r4));
            Console.WriteLine(r3 + r4);
            Console.WriteLine(r3 - r4);
            Console.WriteLine(r3 * r4);

        }
    }
}
