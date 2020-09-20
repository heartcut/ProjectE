using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace ProjectE.Problems1to9
{
    class Prob4
    {
        public static void P4()
        {
            int answer = 0;
            int i = 999;
            int j = 999;
            while (i > 99)
            {
                j = 999;
                while (j > 99)
                {
                    if (multiples(i, j).Length == 6)
                    {
                        if (multiples(i, j)[0] == multiples(i, j)[5]&&multiples(i, j)[1] == multiples(i, j)[4]&&multiples(i, j)[2] == multiples(i, j)[3])
                        {
                            //is is a palindrome number
                            if (i*j> answer)
                            {
                                answer = i*j;
                            }
                        }
                    }
                    if (multiples(i, j).Length == 5)
                    {
                        if (multiples(i, j)[0] == multiples(i, j)[4] && multiples(i, j)[1] == multiples(i, j)[3])
                        {
                            //is is a palindrome number
                            if (i*j > answer)
                            {
                                answer = i*j;
                            }
                        }
                    }
                    j--;
                }
                i--;
            }
            Console.WriteLine(answer);
        }
        //returns the product in an array
        public static int[] multiples(int a, int b)
        {
            int product = a * b;
            string sproduct = product.ToString();
            int[] arr = new int[sproduct.Length];
            for(int i = 0; i < sproduct.Length; i++)
            {
                arr[i] = sproduct.ElementAt(i);
            }
            return arr;
        }
    }
}
