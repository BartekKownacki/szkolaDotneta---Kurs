using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Zad_tydz2_7
{
    class Zad7
    {
        public Zad7()
        {
            // rozwiązanie 1 z wykorzystaniem Linq
            int[] numbers = new int[3];
            Console.Write("Podaj pierwszą liczbę: ");
            Int32.TryParse(Console.ReadLine(), out numbers[0]);
            Console.Write("Podaj drugą liczbę: ");
            Int32.TryParse(Console.ReadLine(), out numbers[1]);
            Console.Write("Podaj trzecią liczbę: ");
            Int32.TryParse(Console.ReadLine(), out numbers[2]);
            Console.WriteLine($"{numbers.Max()} jest największą z podanych");

            // rozwiązanie 2 


            if (numbers[0] > numbers[1] && numbers[0] > numbers[2])
            {
                Console.WriteLine($"{numbers[0]} jest najwięszką liczbą");
            }
            else if (numbers[1] > numbers[0] && numbers[1] > numbers[2])
            {
                Console.WriteLine($"{numbers[1]} jest najwięszką liczbą");
            }
            else
            {
                Console.WriteLine($"{numbers[2]} jest najwięszką liczbą");
            }

        }
    }
}
