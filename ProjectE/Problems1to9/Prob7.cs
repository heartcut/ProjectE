using System;
using System.Collections.Generic;
using System.Text;
using ProjectE.Problems10to19;

namespace ProjectE.Problems1to9
{
    class Prob7
    {
        //im going to try to use my code from Prob3 where I have a method that finds primes
        //call isPrime() with a DOUBLE if it is prime it returns the same number otherwise it returns the lowest prime
        public static void P7()
        {
            double howmany = 10001;
            double myIncr = 0;
            //something feels off starting myincr2 from 1 but it works so ohwell
            double myIncr2 = 1;
            while(myIncr <= howmany)
            {
                // i added up coming back and using a better isprime method i make later that is faster
                //and doesnt return a value back for finding other factors like prob3 needed
                if (Prob10.newIsPrime(myIncr2))
                {
                    if (myIncr == howmany)
                    {
                        Console.WriteLine(myIncr2);
                        break;
                    }
                    else
                    {
                        myIncr++;
                    }
                }
                myIncr2++;
            }
        }
    }
}
