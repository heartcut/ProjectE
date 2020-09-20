using System;
using System.Collections.Generic;
using System.Text;

namespace ProjectE.Problems10to19
{
    class Prob16
    {
        public static void P16()
        {
            //2^1000
            int[] arr = new int[1000];
            arr[0] = 2;
            bool needtocarry = false;
            for(int howmany =1; howmany < 1000;howmany++)
            {
                for(int i = 0; i < arr.Length; i++)
                {
                    if (needtocarry)
                    {
                        arr[i] = (arr[i] * 2) + 1;
                    }
                    else
                    {
                        arr[i] = arr[i] * 2;
                    }
                    if (arr[i].ToString().Length == 2)
                    {
                        needtocarry = true;
                        arr[i] = arr[i] - 10;
                    }
                    else
                    {
                        needtocarry = false;
                    }
                }
            }
            int answer = 0;
            for(int i = 0; i < arr.Length; i++)
            {
                answer = arr[i] + answer;
            }
            Console.WriteLine(answer);
        }
    }
}
