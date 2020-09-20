using System;
using System.Collections.Generic;
using System.Text;

namespace ProjectE.Problems1to9
{
    class Prob6
    {
        public static void P6()
        {
            //this problem was way too easy so i tried to made it modular in that you only change 1 var to get answer with different number
            int howmany = 100;
            Console.WriteLine(squareofsum(howmany) - sumofsquare(howmany));
        }
        public static int sumofsquare(int howmany)
        {
            int sum = 0;
            for(int i = howmany; i > 0; i--)
            {
                sum += (i * i);
            }
            return sum;
        }
        public static int squareofsum(int howmany)
        {
            int sum = 0;
            for (int i = howmany; i > 0; i--)
            {
                sum += i;
            }
            return sum*sum;
        }
    }
}
