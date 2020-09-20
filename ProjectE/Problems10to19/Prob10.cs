using System;
using System.Collections.Generic;
using System.Text;
using ProjectE.Problems1to9;

namespace ProjectE.Problems10to19
{
    class Prob10
    {
        public static void P10()
        {
            double howhigh = 2000000;

            Console.WriteLine(sumOfPrimesBelow(howhigh));
        }
        //i know its bad
        public static double sumOfPrimesBelow(double belowwhat)
        {
            double sum=0;
            double i = 1;
            while (i < belowwhat)
            {
                if (newIsPrime(i))
                {
                    sum = sum + i;
                }
                i++;
            }
            return sum;
        }
        //i didnt end up using my isprime from prob 3 again because its more useful for finding other factors and primes
        public static bool newIsPrime(double num)
        {
            if (num == 1)
            {
                return false;
            }
            double j = 2;
            while (j <= Math.Sqrt(num))//added the sqrt later so it would be twice as fast Kappa
            {
                if (Math.Sqrt(num) % 1 == 0)
                {
                    return false;
                }
                else if(num % j == 0){
                    return false;
                }
                j++;
            }
            return true;
        }
    }
}

