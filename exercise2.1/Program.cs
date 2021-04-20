using System;

namespace exercise2._1
{
    class Program
    {
        static void Main(string[] args)
        {
                      
            int innerCnt;        /*set up counter innerCnt ie what number does the entry being with*/
            int outerCnt =1;    /*set up outer loop counter */

           
           while(outerCnt <= 5) /*will repeat loop 3 times*/
           {
               innerCnt = outerCnt; /* this is declaring the innerloop start number*/


                while (innerCnt <= 5) 
                {
                    Console.Write("X");
                    innerCnt++;
                }

                Console.WriteLine(); /*end of outerloop*/
                outerCnt++;
            }

        }
    }
}
