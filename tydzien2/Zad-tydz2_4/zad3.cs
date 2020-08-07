using System;

namespace Zad_tydz2_4
{
    public class zad3
    {
        public zad3()
        {
            Console.Write("Please write first dimension: ");
            int a = 0;
            Int32.TryParse(Console.ReadLine(), out a);
            
            Console.Write("Please write second dimension: ");
            int b = 0;
            Int32.TryParse(Console.ReadLine(), out b);

            double c = Math.Sqrt(Math.Pow(a,2) + Math.Pow(b,2));
            Console.WriteLine(c);
            
        }
    }
}