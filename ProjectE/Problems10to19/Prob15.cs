using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Xml.Schema;
using System.Xml.Serialization;

namespace ProjectE.Problems10to19
{
    class Prob15
    {
        public static void P15()
        {
            //this one hard
            //put the nxn value in mygrid
            int mygrid = 20;
            long[,] arr = new long[mygrid+1, mygrid+1];
            for(int j = 0; j <= mygrid; j++)
            {
                arr[j, 0] = 1;
                arr[0, j] = 1;
            }
            for(int i = 1; i <= mygrid; i++)
            {
                for (int a = 1; a <= mygrid; a++)
                {
                    arr[i, a] = arr[i-1, a] + arr[i, a-1];
                }
            }
            Console.WriteLine(arr[20, 20]);
        }
    }
}
