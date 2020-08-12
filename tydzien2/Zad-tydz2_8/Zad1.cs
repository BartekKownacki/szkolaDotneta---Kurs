using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Zad_tydz2_8
{
    class Zad1
    {
        public Zad1()
        {
            int[] numbers = new int[] { 2, 3, 5, 7 };
            int numbersCounter = 0;
            for (int i = 0; i <= 100; i++)
            {
                if (i == 0 || i == 1)
                {
                    continue;
                }
                else if (numbers.Contains(i))
                {
                    numbersCounter++;
                }
                else if (i % 2 != 0 && i % 3 != 0 && i % 5 != 0 && i % 7 != 0)
                {
                    numbersCounter++;
                }
            }
            Console.WriteLine($"Liczb pierwszych w przedziale od 0 do 100 jest: {numbersCounter}");
        }
    }
}
