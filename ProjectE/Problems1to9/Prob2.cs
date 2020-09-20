using System;
using System.Collections.Generic;
using System.Text;

namespace ProjectE.Problems1to9
{
    class Prob2
    {
        public static void P2()
        {
            int max = 4000000;
            int holder1 = 1;
            int holder2 = 2;
            int holder3;
            int AnswerSum=0;
            while (holder2 <= max)
            {
                if (holder2 % 2 == 0)
                {
                    AnswerSum += holder2;
                }
                holder3 = holder2;
                holder2 = holder1 + holder2;
                holder1 = holder3;
            }
            Console.WriteLine(AnswerSum);
        }
    }
}
