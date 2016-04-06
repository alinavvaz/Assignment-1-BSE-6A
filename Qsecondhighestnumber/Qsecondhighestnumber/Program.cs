using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Qsecondhighestnumber{
class Program
    {
       
        static void Main(string[] args)
        {
            int[] myArray = new int[] { 0, 1, 2, 3, 13, 8, 5 };
            int largest = int.MinValue;
            int second = int.MinValue;
            foreach (int i in myArray)
            {
                if (i > largest)
                {
                    second = largest;
                    largest = i;
                }
                else if (i > second)
                    second = i;
            }

            System.Console.WriteLine(second);
            Console.ReadLine();
        }
    }}
