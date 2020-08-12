using System;
using System.Collections.Generic;
using System.Text;

namespace Zad_tydz2_7
{
    class Zad12
    {
        public Zad12()
        {
            int day;
            Console.Write("Podaj numer dnia tygodnia: ");
            Int32.TryParse(Console.ReadLine(), out day);

            switch (day)
            {
                case 7:
                    Console.WriteLine("Niedziela");
                    break;
                case 6:
                    Console.WriteLine("Sobota");
                    break;
                case 5:
                    Console.WriteLine("Piątek");
                    break;
                case 4:
                    Console.WriteLine("Czwartek");
                    break;
                case 3:
                    Console.WriteLine("Środa");
                    break;
                case 2:
                    Console.WriteLine("Wtorek");
                    break;
                case 1:
                    Console.WriteLine("Poniedziałek");
                    break;
                default:
                    Console.WriteLine("Podano blędny numer dnia tygodnia");
                    break;
            }
        }
    }
}
