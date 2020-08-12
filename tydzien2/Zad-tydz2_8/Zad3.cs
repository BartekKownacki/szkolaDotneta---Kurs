using System;
using System.Collections.Generic;
using System.Text;

namespace Zad_tydz2_8
{
    class Zad3
    {
        public Zad3()
        {
            int maxId;
            Console.Write("Podaj zakres ciągu fibonnaciego (max = 100): ");
            Int32.TryParse(Console.ReadLine(), out maxId);
            if (maxId >100 || maxId < 0)
            {
                Console.WriteLine("Podano błędną liczbę");
            }
            else
            {
                int[] fibonacci = new int[maxId];
                for(int i = 0; i<maxId; i++)
                {
                    if(i==0 || i == 1)
                    {
                        fibonacci[i] = i;
                        Console.WriteLine(i);
                    }
                    else
                    {
                        fibonacci[i] = fibonacci[i - 1] + fibonacci[i - 2];
                        Console.WriteLine(fibonacci[i]);
                    }    
                }
            }
        }
    }
}
