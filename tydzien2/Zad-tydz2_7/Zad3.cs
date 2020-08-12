using System;
using System.Collections.Generic;
using System.Text;

namespace Zad_tydz2_7
{
    class Zad3
    {
        public Zad3()
        {
            int number;
            Console.Write("Podaj liczbę: ");
            Int32.TryParse(Console.ReadLine(), out number);
            if (number > 0)
            {
                Console.WriteLine($"{number} jest liczbą dodatnią");
            }
            else if (number < 0)
            {
                Console.WriteLine($"{number} jest liczbą ujemną");
            }
            else
            {
                Console.WriteLine($"{number} jest równy 0");
            }

        }
    }
}
