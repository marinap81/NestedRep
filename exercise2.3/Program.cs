using System;

namespace exercise2._3
{
    class Program
    {
        static void Main(string[] args)
        {
            int innerCnt;        
            int outerCnt =0;   

           
           while(outerCnt < 5) 
           {
               innerCnt = outerCnt; /* declaring the innerloop start number*/


                while (innerCnt >= 0) 
                {
                    Console.Write("X");
                    innerCnt--;
                }

                Console.WriteLine(); /*end of outerloop*/
                outerCnt++;
           }
        }
    }
}
