using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicPrograms
{
    public class HarmonicNumber
    {
        public static void Harmonicseries()
        {
            Console.WriteLine("Harmonic Number Program");
            Console.WriteLine("Enter the nthterm for the HarmonicSeries");
            int n=Convert.ToInt32(Console.ReadLine());
            for(int i=1; i<=n; i++) 
            {
                Console.Write("1/" +i+" "+"+ ");
            }

        }
    }
}
