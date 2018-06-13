using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MultiplesOf3And5
{
    class Program
    {
        static void Main(string[] args)
        {
            int suma = 0;
            bool result;
            
            var result1 = Enumerable.Range(0,1000).Where(i => i% 3 == 0 || i% 5 == 0).Sum();  //
            
            for (int i=0; i<1000; i++)
            {
                result = i % 3==0 || i % 5 == 0;
                if(result)
                {
                    suma += i;
                }
            }

            System.Console.WriteLine(suma);
            System.Console.ReadKey();
        }
    }
}
