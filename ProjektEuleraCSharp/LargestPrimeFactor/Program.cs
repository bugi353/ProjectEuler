using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LargestPrimeFactor
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 0;
            long[] liczbyPierwsze = new long [1000];
            double liczba = 600851475143;
            long liczbaspr = 600851475143L;
            //liczba = Console.Read();
            long pierwiastek = (long)Math.Sqrt(liczba);
            long a, b;

            for (long i = 2; i <= pierwiastek; i++)
            {


                if (liczbaspr % i == 0)
                {
                    a = i;
                    b = liczbaspr / a;
                    for (double j = 2; j < a; j++)
                    {
                        if (a % j != 0 && j == a - 1)
                        {
                            liczbyPierwsze[x] = a;
                            x++;
                        }
                        if (a % j == 0)
                        {
                            break;
                        }
                    }
                    for (double k = 2; k < b; k++)
                    {
                        if (b % k != 0 && k == b - 1)
                        {
                            liczbyPierwsze[x] = b;
                            x++;
                        }
                        if (b % k == 0)
                        {
                            break;
                        }
                    }
                }



            }

            for (int i = 0; i < 1000; i++)
            {

                if (liczbyPierwsze[i] != 0)
                {
                    Console.WriteLine(liczbyPierwsze[i]);
                }

            }

            Console.ReadKey();
        }
    }
}
