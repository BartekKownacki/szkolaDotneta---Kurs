using System;
using System.Collections.Generic;
using System.Text;

namespace Zad_tydz2_7
{
    class Zad11
    {
        public Zad11()
        {
            int mark;
            Console.Write("Podaj ocenę: ");
            Int32.TryParse(Console.ReadLine(), out mark);

            switch (mark)
            {
                case 6:
                    Console.WriteLine("Celujący");
                    break;
                case 5:
                    Console.WriteLine("Bardzo dobry");
                    break;
                case 4:
                    Console.WriteLine("Dobry");
                    break;
                case 3:
                    Console.WriteLine("Dostateczny");
                    break;
                case 2:
                    Console.WriteLine("Dopuszczający");
                    break;
                case 1:
                    Console.WriteLine("Niedostateczny");
                    break;
                default:
                    Console.WriteLine("Podano błędną liczbę");
                    break;
            }
        }
    }
}
