using System;
using System.Collections.Generic;
using System.Text;

namespace Zad_tydz2_8
{
    class Zad4
    {
        public Zad4()
        {
            int chosenNumber, columnNumber = 1;
            Console.Write("Podaj liczbę całkowitą: ");
            Int32.TryParse(Console.ReadLine(), out chosenNumber);
            for (int i = 1; i<=chosenNumber; )
            {
                for(int j = 0; j<columnNumber; j++)
                {
                    if(i>chosenNumber)
                    {
                        continue;
                    }
                    else
                    {
                        Console.Write(i);
                        i++;
                    }
                }
                Console.WriteLine();
                columnNumber++;
            }
        }
    }
}
