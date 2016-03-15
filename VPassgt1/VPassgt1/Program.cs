using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VPassgt1
{
    class Program
    {
        static void Main(string[] args)
        {
           
        int Siblings=0;
        int Day, year, month;
        String[] DateOfBirth = new String[50];
            DateTime[] first = new DateTime[50];
            DateTime Second = DateTime.Today;



            Console.WriteLine("Please enter number of siblings");
            Siblings = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("you have siblings = "+Siblings);



            for (int i = 0; i < Siblings; i++)
            {
                Console.WriteLine("Please Enter Date Of Birth for Sibling  "+(i+1)+" In the format of Month/Date/Year as MM/DD/YY");
                DateOfBirth[i]=Console.ReadLine();
                first[i]=Convert.ToDateTime(DateOfBirth[i]);
            }
                for (int j = 0; j < Siblings; j++)
                {
                    Day = first[j].Day - Second.Day;
                    month = first[j].Month - Second.Month;
                    year = first[j].Year - Second.Year ;
                    Console.WriteLine("The Age of the sibling " + (j) + "  =  " + year + " Years " + month + " Months " + Day + "  Days Old ");
                }
                for (int k = 0; k < Siblings; k++)
                {
                    int DifferenceDay = first[k].Day - first[k+1].Day;
                    int DifferenceMonth = first[k].Month - first[k + 1].Month;
                    int DifferenceYear = first[k].Year - first[k + 1].Year;
                    Console.WriteLine("The difference between Siblings respectively =  " +DifferenceDay+" Days " +DifferenceMonth+" Months " +DifferenceYear+" Years");
                }
                Console.ReadLine();   
            }

			
           
            }	 
			}


    


