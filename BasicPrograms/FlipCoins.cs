using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicPrograms
{
    public class FlipCoins
    {
        public static void Coins()
        {
            int tails = 0, heads = 0, tailsPercentage ,headsPercentage;
            Console.WriteLine("Flip Coins Program");

            Console.WriteLine("How many times do you want to flip a coin");
            int coin=Convert.ToInt32(Console.ReadLine());
            Random random=new Random();
            for (int i = 0; i < coin; i++)
            {
                int flips = random.Next(0, 2);
                if(flips==0)
                {
                    tails++;
                    Console.WriteLine("Its Tails");
                }
                else
                {
                    heads++;
                    Console.WriteLine("Its Heads");
                }
            }
            Console.WriteLine("number of times tails occured:"+tails);
            Console.WriteLine("number of times heads occured: "+heads);
            tailsPercentage = (tails*100/coin);
            Console.WriteLine("Percentage of Tails is :" + tailsPercentage+"%");
            headsPercentage= (heads*100/coin);
            Console.WriteLine("Percentage of Heads is :"+headsPercentage+"%");
            
            
        }
    }
}
