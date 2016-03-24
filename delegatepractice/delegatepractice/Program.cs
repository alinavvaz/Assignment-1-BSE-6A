using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



delegate int Changer(int n);
namespace delegatepractice
{
    class Program
    {
        static int num = 2;
        public static int AddNum(int p)
        {
            num += p;
            return num;
        }

        public static int MultiplyNum(int q)
        {
            num *= q;
            return num;
        }
        public static int getNum()
        {
            return num;
        }

        static void Main(string[] args)
        {
            Changer nc1 = new Changer(AddNum);
            Changer nc2 = new Changer(MultiplyNum);

            nc1(25);
            Console.WriteLine("Value of Num1=", getNum());
            nc2(5);
            Console.WriteLine("Value of Num2=", getNum());
            Console.ReadKey();
        }
    }
}