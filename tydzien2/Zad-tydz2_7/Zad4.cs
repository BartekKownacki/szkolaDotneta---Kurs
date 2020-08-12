using System;
using System.Collections.Generic;
using System.Text;

namespace Zad_tydz2_7
{
    class Zad4
    {
        public Zad4()
        {
            int year;
            Console.Write("Podaj rok w formacie YYYY, np. 2015: ");
            Int32.TryParse(Console.ReadLine(), out year);
            if(year%4==0)
            {
                Console.WriteLine($"{year} jest rokiem przestępnym");
            }
            else
            {
                Console.WriteLine($"{year} nie jest rokiem przestępnym");
            }
        }
    }
}
