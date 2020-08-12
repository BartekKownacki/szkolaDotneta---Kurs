using System;
using System.Collections.Generic;
using System.Text;

namespace Zad_tydz2_8
{
    class Zad6
    {
        public Zad6()
        {
            double sum = 0.0;
            for(int i = 1; i<20; i++)
            {
                sum += 1.0 / i;
            }
            Console.WriteLine(sum.ToString());
        }
    }
}
