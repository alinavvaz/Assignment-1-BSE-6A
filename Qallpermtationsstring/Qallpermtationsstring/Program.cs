using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Qallpermtationsstring

{
    class Program
    {
        static void Main(string[] args)
        {
            string r;
            r = Console.ReadLine();
            Permutation(r);
            Console.ReadLine();
        }

        public static void Permutation(string input)
        {
            RecPermutation("", input);
        }
        private static void RecPermutation(string soFar, string input)
        {
            if (string.IsNullOrEmpty(input))
            {
                Console.WriteLine(soFar);
                return;
            }
            else
            {
                for (int i = 0; i < input.Length; i++)
                {

                    string remaining = input.Substring(0, i) + input.Substring(i + 1);
                    RecPermutation(soFar + input[i], remaining);
                }
            }
        }
    }
}

