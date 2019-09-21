using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace basictraining
{
    class Program
    {
        static void Main(string[] args)
        {
            HelloWorld();

            Print1to10();
            PrintPairs();
            PrintPairswithargs(20,40);
            PrintPairswithargs(21, 41);
            PrintPairswithargs (21,40);
            Sumuntilarg(5000);
            Sumuntilarg(7800);
            Sumuntilarg(7800000);
            Console.WriteLine("Please press a key");
            Console.ReadKey();

        }

        static void HelloWorld()
        {
            Console.WriteLine("Hello");
            Console.WriteLine();
        }

        static void Print1to10()
        {
            Console.WriteLine("Print1to10");
            for (var num = 1; num < 11; num++)
                Console.WriteLine(num);
            Console.WriteLine();
        }

        static void PrintPairs()
        {
            Console.WriteLine("PrintPairs");
            for (var num = 2; num <= 20; num += 2)
                Console.WriteLine(num);
            Console.WriteLine();
        }

        static void PrintPairswithargs(int from, int to)
        {

            Console.WriteLine("PrintPairswithargs");
            if (from % 2 != 0)
                from = from + 1;

            
            {  
                for (var num = from; num <= to; num += 2)
                    Console.WriteLine(num);
            }
            Console.WriteLine();

        }

        static void Sumuntilarg(int limit)
        {
            Console.WriteLine("Sumuntilarg");
            int sum=0;
            int consecutive = 1;
            while (sum <= limit)
            {
                sum = sum + consecutive;
                consecutive++;
            }
            Console.WriteLine(sum);
        }
    }

}
