﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Zad_tydz2_7
{
    class Zad5
    {
        public Zad5()
        {
            int age;
            Console.Write("Proszę podaj swój wiek: ");
            Int32.TryParse(Console.ReadLine(), out age);
            if (age >= 21 && age < 30)
            {
                Console.WriteLine("Możesz zostać posłem");
            }
            else if (age >= 21 && age < 35)
            {
                Console.WriteLine("Możesz zostać posłem i senatorem (premierem?)");
            }
            else if (age >= 21)
            {
                Console.WriteLine("Możesz zostać posłem i senatorem (premierem? oraz prezydentem RP)");
            }
            else
            {
                Console.WriteLine("Niestety nie możesz kandydować :(");
            }
        }
    }
}
