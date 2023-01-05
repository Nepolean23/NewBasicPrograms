using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicPrograms
{
    public class PowerOfTwo
    {
        public static void Squareofnumber()
        {
            int val1;
            Console.WriteLine("Power Of Two Program");
            Console.WriteLine("How many times do you want to print the power of two tables");
            val1=Convert.ToInt32(Console.ReadLine());
            for (int i = 1; i <=val1; i++)
            {
                double val2 = Math.Pow(2, i);


                Console.WriteLine("2^ " + i + " is " + val2);
            }
        }
    }
}
