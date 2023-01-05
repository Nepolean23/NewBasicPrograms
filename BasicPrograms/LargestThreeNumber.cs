using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicPrograms
{
    public class LargestThreeNumber
    {
        public static void LargerNumbers()
        {
            Console.WriteLine("Finding of Largest Three Numbers");
            Console.Write("Enter a First Value :");
            int val1=Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter a Second Value :");
            int val2=Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter a Third Value :");
            int val3=Convert.ToInt32(Console.ReadLine());
            if(val1>val2 && val1>val3)
            {
                Console.WriteLine("The First value is greater");
            }
            else if(val2>val1 && val2>val3)
            {
                Console.WriteLine("The Second value is greater");
            }
            else
            {
                Console.WriteLine("The Third value is greater");
            }
        }
    }
}
