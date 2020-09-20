using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace ProjectE.Problems1to9
{
    class Prob3
    {
        public static void P3()
        {
            double max = 600851475143;
            //double max = 13195;
            double tempmax = max;
            while (isPrime(tempmax)!=tempmax)
            {
                tempmax = isPrime(tempmax);
            }
            Console.WriteLine(isPrime(tempmax));
        }
        //returns the same number if it is prime
        public static double isPrime(double num)
        {
            double i = 2;
            while( num % i != 0&&i<num)//added the num/2 later so it would be twice as fast Kappa
            {
                if (Math.Sqrt(num) % 1 == 0)
                {
                    return Math.Sqrt(num);
                }
                i++;
            }
            if (i == num)
            {
                return num;
            }
            else if (num == 1)
            {
                return 0;
            }
            else
            {
                return num/i;
            }
        }
    }
}
