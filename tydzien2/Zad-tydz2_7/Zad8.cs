using System;
using System.Collections.Generic;
using System.Text;

namespace Zad_tydz2_7
{
    class Zad8
    {
        public Zad8()
        {
            int math, chemistry, physics;
            Console.Write("Podaj swój wynik z matematyki: ");
            Int32.TryParse(Console.ReadLine(), out math);
            Console.Write("Podaj swój wynik z fizyki: ");
            Int32.TryParse(Console.ReadLine(), out physics);
            Console.Write("Podaj swój wynik z chemii: ");
            Int32.TryParse(Console.ReadLine(), out chemistry);

            if((math>70 && physics>55 && chemistry>45 && math+physics+chemistry>180)||(math+physics>150)||(math+chemistry>150))
            {
                Console.WriteLine("Kandydat dopuszczony do rekrutacji");
            }
            else
            {
                Console.WriteLine("Kandydat niedopuszczony do rekrutacji");
            }

        }
    }
}
