using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicPrograms
{
    public class PrimeFactors
    {
        public static void Numbers()
        {
            int divisior = 0;
            Console.WriteLine("Prime Factor Program");
            Console.WriteLine("Enter a number to check Prime number");
            int number=Convert.ToInt32(Console.ReadLine());
            for (int i = 1; i <= number; i++)
            {
               if (number % i==0)
                {
                    divisior++;
                }

               

            }
            if (divisior==2)
            {
                Console.WriteLine("The entered number is  prime number: " +number);
            }
            else 
            {
                Console.WriteLine("The entered number is not prime number: "+number);
            }
        }
    }
}
