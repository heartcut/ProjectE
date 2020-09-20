using System;
using System.Collections.Generic;
using System.Text;

namespace ProjectE.Problems1to9
{
    class Prob1
    {
        public static void P1()
        {
            int input = 999;
            int answer = 0;
            for(int i = input; i > 0; i--)
            {
                 if(i % 3 == 0 || i % 5 == 0)
                 {
                    answer += i;
                 }
            }
            Console.WriteLine(answer);
        }
    }
}
