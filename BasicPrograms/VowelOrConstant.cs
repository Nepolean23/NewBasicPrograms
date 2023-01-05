using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicPrograms
{
    public class VowelOrConstant
    {
        public static void Checkingchar()
        {
            char chr;
            Console.WriteLine("Vowel Or Constant Program");
            Console.WriteLine("Enter a charcter to find its Vowel or Constant");
            chr = Convert.ToChar(Console.ReadLine().ToUpper());
            char.ToUpper(chr);
            switch(chr)
            {
                case 'A':
                    Console.WriteLine("It's vowel");
                    break;

                case 'E':
                    Console.WriteLine("It's vowel");
                    break;

                case 'I':
                    Console.WriteLine("It's vowel");
                    break;

                case 'O':
                    Console.WriteLine("It's vowel");
                    break;

                case 'U':
                    Console.WriteLine("It's vowel");
                    break;

                default:
                    Console.WriteLine("You have entered in-valid character");
                    break;
            }

        }
    }
}
