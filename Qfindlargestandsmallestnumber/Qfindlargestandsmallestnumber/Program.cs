using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Qfindlargestandsmallestnumber
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = new int[10];
            Console.WriteLine("enter the array elements to b sorted");
            for (int i = 0; i < 10; i++)
            {
                array[i] = Convert.ToInt32(Console.ReadLine());
            }
            int smallest = array[0];
            for (int i = 0; i < 10; i++)
            {
                if (array[i] < smallest)
                {
                    smallest = array[i];

                }
            }
            int largest = array[9];
            for (int i = 0; i < 10; i++)
            {

                if (array[i] > largest)
                {
                    largest = array[i];

                }
            }
            Console.WriteLine("the smallest no is {0}", smallest);
            Console.WriteLine("the largest no is {0}", largest);
            Console.Read();


        }
    }
}
