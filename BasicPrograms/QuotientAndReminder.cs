using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicPrograms
{
    public class QuotientAndReminder
    {
        public static void values()
        {
            int quotient, reminder;

            Console.WriteLine("Quotient And Reminder Program");
            Console.Write("Enter a value for Divident :");
            int val1=Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter a value for Divisor :");
            int Val2=Convert.ToInt32(Console.ReadLine());
            quotient = (val1 / Val2);

            Console.WriteLine("The Quotient value is :"+quotient);
            reminder=(val1 % Val2);
            Console.WriteLine("The Reminder value is :"+ reminder);
        }
    }
}
