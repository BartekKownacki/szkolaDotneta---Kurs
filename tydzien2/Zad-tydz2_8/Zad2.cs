using System;
using System.Collections.Generic;
using System.Text;

namespace Zad_tydz2_8
{
    class Zad2
    {
        public Zad2()
        {
            int i = 0;
            do
            {
                if (i % 2 == 0)
                {
                    Console.WriteLine(i);
                }
                i++;
            } while (i <= 1000);
        }
    }
}
