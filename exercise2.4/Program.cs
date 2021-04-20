using System;

namespace exercise2._4
{
    class Program
    {
        static void Main(string[] args)
        {
            string word1;
            int innerCnt;        /*set up counter innerCnt*/
            int rowCnt =1;    /*set up outer loop counter */

           Console.WriteLine("Enter enter the amount of lines");


           word1 = Console.ReadLine();
            Console.WriteLine("");
           Console.WriteLine("");

           innerCnt =int.Parse(word1);

           for (int i= 0; i < innerCnt ; i++)
           {
               
                for ( int k = 0; k < rowCnt ; k++ )
                {
                    Console.Write("x");
                }
                
                Console.WriteLine();
                ++rowCnt;
           }
        }
    }
}
