using System;
using System.Collections.Generic;
using System.Text;

namespace Zad_tydz2_8
{
    class Zad9
    {
        public Zad9()
        {
            int decNumberToBinary;
            Console.Write("Podaj liczbę do zmiany na binarną: ");
            decNumberToBinary = int.Parse(Console.ReadLine());

            //Rozwiązanie 1- wykorzystanie metody ToString
            Console.WriteLine(Convert.ToString(decNumberToBinary, 2));

            //Rozwiązanie 2- wykorzystanie matematyki
            string answerReversed = string.Empty;
            bool finish = true;
            while(finish)
            {
                if(decNumberToBinary == 0)
                {
                    finish = false;
                }
                else
                {
                    answerReversed += (decNumberToBinary % 2).ToString();
                    decNumberToBinary /= 2;
                }
            }

            char[] answer = new char[answerReversed.Length];
            answer = answerReversed.ToCharArray();
            string output = string.Empty;
            for (int i = answer.Length - 1; i >= 0; i--)
            {
                output += answer[i];
            }

            Console.WriteLine(output);
            
        }
    }
}
