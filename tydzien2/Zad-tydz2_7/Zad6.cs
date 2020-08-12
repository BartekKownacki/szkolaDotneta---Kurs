using System;
using System.Collections.Generic;
using System.Text;

namespace Zad_tydz2_7
{
    class Zad6
    {
        public Zad6()
        {
            string[] categories = new string[4];
            categories[0] = "Krasnolud";
            categories[1] = "Niziołek";
            categories[2] = "Gicior";
            categories[3] = "Kozak";
            int height;
            Console.Write("Podaj swój wzrost w cm: ");
            Int32.TryParse(Console.ReadLine(), out height);
            if(height<140)
            {
                Console.WriteLine($"Twoja kategoria wzrostu: {categories[0]}");
            }
            else if(height<160)
            {
                Console.WriteLine($"Twoja kategoria wzrostu: {categories[1]}");
            }
            else if(height<180)
            {
                Console.WriteLine($"Twoja kategoria wzrostu: {categories[2]}");
            }
            else
            {
                Console.WriteLine($"Twoja kategoria wzrostu: {categories[3]}");
            }

        }
    }
}
