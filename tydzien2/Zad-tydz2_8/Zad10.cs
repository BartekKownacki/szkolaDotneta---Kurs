using System;
using System.Collections.Generic;
using System.Text;

namespace Zad_tydz2_8
{
    class Zad10
    {
        public Zad10()
        {
            // a - wieksza liczba
            // b - mniejsza liczba

            int a, b;
            Console.Write("Podaj pierwszą liczbę: ");
            Int32.TryParse(Console.ReadLine(), out a);
            Console.Write("Podaj drugą liczbę: ");
            Int32.TryParse(Console.ReadLine(), out b);

            if (b > a) 
            {
                int temp;
                temp = a;
                a = b;
                b = temp;
            }

            for (int i = 1; i<=a; i++)
            {
                if((b*i)%a == 0)
                {
                    Console.WriteLine($"NWW dla {a} i {b} wynosi: {b*i}");
                    break;
                }
            }

        }
    }
}