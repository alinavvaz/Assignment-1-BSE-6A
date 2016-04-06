using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Qpalindromecheck
{
    using System;
    namespace palindrome
    {
        class Program
        {
            static void Main(string[] args)
            {
                string str;
                string reverse = "";
                Console.WriteLine(" Enter string to be checked");
                str = Console.ReadLine();
                for (int i = str.Length - 1; i >= 0; i--) 
                {
                    reverse += str[i].ToString();
                }
                if (reverse == str) 
                {
                    Console.WriteLine("Palindrome", str, reverse);
                }
                else
                {
                    Console.WriteLine("not Palindrome");
                }
                Console.ReadKey();
            }
        }
    }
}