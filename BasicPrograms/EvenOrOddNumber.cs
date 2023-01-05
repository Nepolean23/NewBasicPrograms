using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicPrograms
{
    public class EvenOrOddNumber
    {
        public static void Checkingnumber()
        {
            Console.WriteLine("Even Or Odd Number Program");
            Console.WriteLine("Enter value to check Even or Odd");
            Console.Write("val: ");
            int val=Convert.ToInt32(Console.ReadLine());
            if(val%2==0)
            {
                Console.WriteLine("It's Even: " + val);

            }
            else
            {
                Console.WriteLine("It's Odd: " + val);
            }
        }
    }
}
