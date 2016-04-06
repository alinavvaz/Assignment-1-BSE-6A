using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Qremovestringchar
{
    using System;

    class Program
    {
        static void Main()
        {

            string str = "Ali";
            string rem = str.Remove(1, 2);

            string value2 = "Nawaz";
            string result2 = value2;
            int index1 = value2.IndexOf('w');
            if (index1 != -1)
            {
                result2 = value2.Remove(index1, 2);
            }

            Console.WriteLine(rem);
            Console.WriteLine(result2);
        }
    }
}