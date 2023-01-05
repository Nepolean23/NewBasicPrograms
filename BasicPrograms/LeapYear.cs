using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicPrograms
{
    public class LeapYear
    {
        public static void Year()
        {
            Console.WriteLine("LeapYear Program");

            Console.WriteLine("Enter a Year in 4digit number to find LeapYear or Not-LeapYear");
            int year=Convert.ToInt32(Console.ReadLine());
            if((year%4==0)&&(year%100!=0)||(year%400==0))
            {
                Console.WriteLine("Entered Year is LeapYear:" + year);
            }
            else
            {
                Console.WriteLine("Entered Year is Not LeapYear:" + year);
            }
        }
    }
}
