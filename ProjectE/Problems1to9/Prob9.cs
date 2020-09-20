using System;
using System.Collections.Generic;
using System.Text;

namespace ProjectE.Problems1to9
{
    class Prob9
    {
        public static void P9()
        {
            int sum = 1000;
            bool foundit = false;
            int diff = 1;
            //not sure if there is a better way to do this while loop but im tired
            while (foundit != true)
            {
                diff++;
                int a = 1;
                int b = a + diff;
                int c = sum - (a + b);
                while (b < c)
                {
                    if (((a*a)+(b*b)) == (c*c))
                    {
                        Console.WriteLine(a * b * c);
                        foundit = true;
                        break;
                    }
                    a++;
                    b++;
                    c = c - 2;
                }
            }
        }
    }
}
