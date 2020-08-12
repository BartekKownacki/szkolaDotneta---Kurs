using System;
using System.Collections.Generic;
using System.Text;

namespace Zad_tydz2_7
{
    class Zad2
    {
        public Zad2()
        {
            int number;
            Console.Write("Podaj liczbę: ");
            Int32.TryParse(Console.ReadLine(), out number);
            if (number%2==0)
            {
                Console.WriteLine($"{number} jest parzystą");
            }
            else
            {
                Console.WriteLine($"{number} jest nieparzystą");
            }

        }
    }
}
