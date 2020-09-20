using System;
using System.Collections.Generic;
using System.Text;

namespace ProjectE.Problems1to9
{
    class Prob8
    {
        public static void P8()
        {
            //yea this is janky
            //i get my string
            int howmany = 13;
            double answer = 0;
            //i know its fucking long
            string mynumbers = "7316717653133062491922511967442657474235534919493496983520312774506326239578318016984801869478851843858615607891129494954595017379583319528532088055111254069874715852386305071569329096329522744304355766896648950445244523161731856403098711121722383113622298934233803081353362766142828064444866452387493035890729629049156044077239071381051585930796086670172427121883998797908792274921901699720888093776657273330010533678812202354218097512545405947522435258490771167055601360483958644670632441572215539753697817977846174064955149290862569321978468622482839722413756570560574902614079729686524145351004748216637048440319989000889524345065854122758866688116427171479924442928230863465674813919123162824586178664583591245665294765456828489128831426076900422421902267105562632111110937054421750694165896040807198403850962455444362981230987879927244284909188845801561660979191338754992005240636899125607176060588611646710940507754100225698315520005593572972571636269561882670428252483600823257530420752963450";
            //use tochararry to put it in a chararray
            char[] chararr = mynumbers.ToCharArray();
            //instanciate my int array with the length of the char array
            int[] intarr = new int[chararr.Length];
            //here i go through and put every char into the arry by parsing to string and to int :)
            for (int i = 0; i < intarr.Length; i++)
            {
                intarr[i] = int.Parse(chararr[i].ToString());
            }
            //now i started mulplying 13(howmany) side by side numbers in the array
            int bot = 0;
            int top = howmany-1;
            double tempanswer = 1;
            while (top < intarr.Length)
            {
                int incr = bot;
                while (incr <= top)
                {
                    tempanswer *= intarr[incr];
                    incr++;
                }
                if (tempanswer > answer)
                {
                    answer = tempanswer;
                }
                tempanswer = 1;
                top++;
                bot++;
            }
            Console.WriteLine(answer);
        }
    }
}
