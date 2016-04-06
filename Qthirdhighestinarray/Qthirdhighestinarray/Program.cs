using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Qthirdhighestinarray
{
    class Program
    {

        static void Main(string[] args)
        {
            int[] arr = { 1, 8, 4, 5, 12, 2, 5, 6, 7, 1, 90, 100, 56, 8, 34 };

            int temp, f, s, t;
            f = s = t = arr[0];
            foreach (int i in arr)
            {
                if (f < i)
                {
                    temp = f;
                    f = i;
                    s = temp;
                }
                if (s < i && f > i)
                {
                    temp = i;
                    s = i;
                    t = temp;
                }
                if (t < i && s > i)
                {
                    temp = i;
                    t = i;
                }
            }
            Console.WriteLine(t.ToString());
            Console.ReadLine();
        }
    }
}


