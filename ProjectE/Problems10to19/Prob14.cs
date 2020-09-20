using System;
using System.Collections.Generic;
using System.Text;

namespace ProjectE.Problems10to19
{
    class Prob14
    {
        //god fucking dammit im so mad about this huge ass number and overflowing andsaf
        // the fucking shit was going negative into my array
        //prob need to use long fuck it i always use double beacuse im a dumbshit
        public static void P14()
        {
            long termanswerstart = 0;
            long tempanswerterms = 0;
            
            for(long i = 1; i <=999999; i++)
            {
                long b = ReturnTerms(i);
                if (b > tempanswerterms)
                {
                    termanswerstart = i;
                    tempanswerterms = b;
                }
            }
            Console.WriteLine(termanswerstart);
        }
        
        public static long[] myterms = new long[1000000000];
        public static long ReturnTerms(long a)
        {
            long numberofterms = 1;
            long startingnumber = a;

            while (startingnumber != 1)
            {
                if(startingnumber<2000000000&&startingnumber<(myterms.Length-1))
                {
                    if(myterms[Convert.ToInt32(startingnumber)] == 0)
                    { 
                        if (startingnumber % 2 == 0)
                        {
                            startingnumber = startingnumber / 2;
                            numberofterms++;
                        }
                        else
                        {
                            startingnumber = ((startingnumber * 3) + 1);
                            numberofterms++;
                        }
                    }
                    else
                    {
                        return numberofterms + myterms[Convert.ToInt32(startingnumber)];
                    }
                }
                else
                {
                    if (startingnumber % 2 == 0)
                    {
                        startingnumber = startingnumber / 2;
                        numberofterms++;
                    }
                    else
                    {
                        startingnumber = ((startingnumber * 3) + 1);
                        numberofterms++;
                    }
                }
            }
            return numberofterms;
        }
    }
}
