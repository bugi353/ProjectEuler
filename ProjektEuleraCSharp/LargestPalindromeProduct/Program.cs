using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LargestPalindromeProduct
{
    class Program
    {
        static void Main(string[] args)
        {
            int c = 0, d=0;
            string liczba, palindrom ="";
            
            for(int i = 999; i>99; i--)
            {
                for(int j=999; j>99; j--)
                {
                    c = i * j;
                    
                    liczba = c.ToString();

                    if(c<100000)
                    {
                        break;
                    }

                    for(int k=0; k<6; k++)
                    {
                        if(liczba[k] == liczba[5-k]&&k==5)
                        {
                            if(c>d)
                            {
                                palindrom = liczba;
                                d = c;
                            }
                            

                        }
                        if (liczba[k] != liczba[5 - k])
                        {
                            break;
                        }
                    }
                    
                }
            }
            
            Console.WriteLine(palindrom);
            Console.ReadKey();
        }
    }
}
