using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Qquizwala2arrays{
class Program
    {
        public void displayMatrix(List<int> arry)
        {
            for (int i = 0; i < arry.Count; i++)
            {
                Console.Write(arry[i] + " ");
            }
            Console.WriteLine();
            Console.WriteLine();
        }
        public void ValueSearch(List<int> first, List<int> second)
        {
            List<int> distinct = new List<int>();

            for (int i = 0; i < first.Count; i++)
            {
                for (int j = 0; j < second.Count; j++)
                {
                    if (first[i] == second[j])
                    {
                        first[i] = 0;
                        break;
                    }
                }
            }
            for (int i = 0; i < first.Count; i++)
            {
                if (first[i] != 0)
                {

                    distinct.Add(first[i]);
                }
            }
            Console.Write("The numbers not in second array: ");
            displayMatrix(distinct);
        }
        static void Main(string[] args)
        {
           List<int> firstArr = new List<int>();
           List<int> secndArr = new List<int>();
           firstArr.Add(2);
           firstArr.Add(3);
           firstArr.Add(4);
           firstArr.Add(6);
           firstArr.Add(1);
           secndArr.Add(8);
           secndArr.Add(2);
           secndArr.Add(5);
           secndArr.Add(4);
           secndArr.Add(7);

            Program pgm = new Program();
            Console.Write("The First Array: ");
            pgm.displayMatrix(firstArr);
            Console.Write("The Second Array: ");
            pgm.displayMatrix(secndArr);
            pgm.ValueSearch(firstArr, secndArr);
        }
    }}
