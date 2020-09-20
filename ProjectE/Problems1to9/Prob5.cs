using System;
using System.Collections.Generic;
using System.Text;

namespace ProjectE.Problems1to9
{
    class Prob5
    {
        //lots of ways to optimize probably
        public static void P5()
        {
            int answer=1;
            
            while(candivide(answer) != 20)
            {
                answer++;
            }
            Console.WriteLine(answer);
        }
        //if it is divisable by 1-20 then it returns 20
        public static int candivide(int k)
        {
            int howmany = 0;
            if (k % 2 != 0)
            {
                return 0;
            }
            for(int u = 1; u<=20; u++)
            {
                //i originally went through all of them like this
                if (k % u == 0)
                {
                    howmany++;
                }
                //decided it was way too slow i can just stop if its not
                else
                {
                    return howmany;
                }
            }
            return howmany;
        }
    }
}
