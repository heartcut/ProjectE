using System;
using System.Collections.Generic;
using System.Text;

namespace ProjectE.Problems10to19
{
    class Prob12
    {
        public static void P12()
        {
            int howmanydivisors = 500;
            bool notdone = true;
            for(double i=0;notdone; i++)
            {
                if (FindFactors(GetTriangleNum(i)) > howmanydivisors)
                {
                    Console.WriteLine(GetTriangleNum(i));
                    notdone = false;
                }
            }
        }
        //just need to return how many factors a number has
        public static double FindFactors(double n)
        {
            //the number i put it wil always have at least two numbers
            //1 and itself so i start howmany at 2 and start at one less looking
            double start = n - 1;
            double howmany = 2;
            if (n == 1)
            {
                return 1;
            }
            else if (n == 0)
            {
                return 0;
            }
            for (double i = 2; i <= Math.Sqrt(n); i++)
            {
                if (n % i == 0)
                {
                    howmany += 2;
                }
            }
            return howmany;
        }
        //just returns triangle numbers at any given position
        //1, 3, 6, 10, 15, 21, 28, 36, 45, 55, ...
        //1, 2, 3, 4,,  5,, 6,, 7,, 8,, 9, 10, ...
        public static double GetTriangleNum(double n)
        {
            double sum = 0;
            for(double i = n; i >0; i--)
            {
                sum = sum + i;
            }
            return sum;
        }
    }
}
