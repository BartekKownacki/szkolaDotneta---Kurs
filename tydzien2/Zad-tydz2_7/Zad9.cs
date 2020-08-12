using System;
using System.Collections.Generic;
using System.Text;

namespace Zad_tydz2_7
{
    class Zad9
    {
        public Zad9()
        {
            int temp;
            Console.Write("Podaj temperaturę: ");
            Int32.TryParse(Console.ReadLine(), out temp);
            if (temp<0)
            {
                Console.WriteLine("cholernie piździ");
            }
            else if (temp<10)
            {
                Console.WriteLine("zimno");
            }
            else if (temp<20)
            {
                Console.WriteLine("chłodno");
            }
            else if (temp<30)
            {
                Console.WriteLine("w sam raz");
            }
            else if (temp<40)
            {
                Console.WriteLine("zaczyna być słabo bo gorąco");
            }
            else
            {
                Console.WriteLine("a weź wyprowadzam się na Alaskę");
            }
        }
    }
}
