using System;
using System.Collections.Generic;
using System.Text;

namespace Zad_tydz2_7
{
    class Zad10
    {
        public Zad10()
        {
            int a, b, c;
            Console.Write("Podaj pierwszy wymiar: ");
            Int32.TryParse(Console.ReadLine(), out a);
            Console.Write("Podaj drugi wymiar: ");
            Int32.TryParse(Console.ReadLine(), out b);
            Console.Write("Podaj trzeci wymiar: ");
            Int32.TryParse(Console.ReadLine(), out c);

            if (a>b && a>c)
            {
                if (b+c>a)
                {
                    Console.WriteLine("Można zbudować trójkąt");
                }
            }
            else if (b>c && b>a)
            {
                if(c+a>b)
                {
                    Console.WriteLine("Można zbudować trójkąt");
                }

            }
            else
            {
                if(a+b>c)
                {
                    Console.WriteLine("Można zbudować trójkąt");
                }
            }
        }
    }
}
