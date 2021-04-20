using System;

namespace exercise2._2
{
    class Program
    {
        static void Main(string[] args)
        {
      
        string word1;
        
        int noprint;
        int rowCnt = 0;

            

            Console.WriteLine("How many times do you want X to print?");
            word1 = Console.ReadLine();

            noprint = int.Parse(word1);
            

            for (int i= 0; i < noprint ; i++)
            {
                for ( int k = 0; k <= rowCnt ; k++ )
                {
                    Console.Write("x");
                }
                
                Console.WriteLine();
                ++rowCnt;
            }
         
     
        }
    }
}
