using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EulerEvenFibonaciNumbers
{
    class Program
    {
        

        static void Main(string[] args)
        {
            long fibA =1, fibB =2;
            long sum = fibB;

            while (fibB < 4000000)
            {   
                if(fibB > fibA)
                {
                    fibA = fibA + fibB;
                    if(fibA%2==0)
                    {
                        sum += fibA;
                    }
                }
                else if(fibA>fibB)
                {
                    fibB = fibA + fibB;

                    if (fibB % 2 == 0)
                    {
                        sum += fibB;
                    }
                }
                
            }
            Console.WriteLine(sum);
            Console.ReadKey();
        }
    }
}
