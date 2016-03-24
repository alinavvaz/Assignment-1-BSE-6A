using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication6
{
    delegate void Mdelegate(int x, int y);

    delegate void dele(int a, int b);
    public class Oper
    {
        public static void Add(int a, int b)
        {
            Console.WriteLine("{0} + {1} = {2}", a, b, a + b);
        }

        public static void Sub(int a, int b)
        {
            Console.WriteLine("{0} - {1} = {2}", a, b, a - b);
        }

        public static void Mul(int a, int b)
        {
            Console.WriteLine("{0} * {1} = {2}", a, b, a * b);
        }

        public static void Div(int a, int b)
        {
            Console.WriteLine("{0} / {1} = {2}", a, b, a / b);
        }
    }
    public class program
    {
        static void Main()
        {

            dele del = new dele(Oper.Add);

            del += new dele(Oper.Sub);
            del += new dele(Oper.Mul);
            del += new dele(Oper.Div);

            del(55, 42);

            Console.Read();
        }
    }
}