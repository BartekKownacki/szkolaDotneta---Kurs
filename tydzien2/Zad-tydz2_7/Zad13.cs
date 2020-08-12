using System;
using System.Collections.Generic;
using System.Text;

namespace Zad_tydz2_7
{
    class Zad13
    {
        public Zad13()
        {
            int a, b;
            int choice;
            Console.Write("Podaj pierwszą liczbę: ");
            Int32.TryParse(Console.ReadLine(), out a);
            Console.Write("Podaj drugą liczbę: ");
            Int32.TryParse(Console.ReadLine(), out b);

            Console.WriteLine("Podaj numer operacji do wykonania: \n1. Dodawanie \n2. Odejmowanie \n3. Mnożenie \n4. Dzielenie");
            Int32.TryParse(Console.ReadLine(), out choice);
            Console.Write("Twój wynik to: "); 
            switch (choice)
            {
                case 1:
                    Console.Write(a + b);
                    break;
                case 2:
                    Console.Write(a - b);
                    break;
                case 3:
                    Console.Write(a * b);
                    break;
                case 4:
                    Console.Write(a / b);
                    break;
                default:
                    Console.WriteLine("Błędny wybór operacji");
                    break;
            }
        }
    }
}
