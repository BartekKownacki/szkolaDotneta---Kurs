using System;
using System.Collections.Generic;
using System.Text;

namespace Zad_tydz2_8
{
    class Zad8
    {
        public Zad8()
        {
            string word, output = string.Empty;
            Console.Write("Podaj słowo do zmiany: ");
            word = Console.ReadLine();

            char[] letters = new char[word.Length];
            letters = word.ToCharArray();
            for ( int i = letters.Length-1; i>= 0; i--)
            {
                output += letters[i];
            }
            Console.WriteLine($"Twoje słowo odwrócone: {output}");
        }
    }
}
