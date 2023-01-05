using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicPrograms
{
    public class SwapTwoNumbers
    {
        public static void SwapingNumbers()
        {
            
            Console.WriteLine("Swaping Two Numbers Program");
            Console.Write("Enter a 1st value: ");
            int val1=Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter a 2nd value: ");
            int val2=Convert.ToInt32(Console.ReadLine());
            val1 = val1 * val2;
            val2 = val1 / val2;
            val1 = val1/val2;
            Console.WriteLine("The Swaped Value is");
            Console.WriteLine("The Val1 is :"+val1);
            Console.WriteLine("The val2 is :"+val2);


        }
    }
}
