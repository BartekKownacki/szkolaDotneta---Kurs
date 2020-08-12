using System;
using System.Collections.Generic;
using System.Text;

namespace Zad_tydz2_8
{
    class Zad7
    {
        public Zad7()
        {
            string line = string.Empty;
            int size; 
            int dot = 0;
            int space = 1;
            
            Console.Write("Podaj wielkość: ");
            Int32.TryParse(Console.ReadLine(), out size);
            //pierwsza połowa + środek
            for(int i=0; i<=size/2; i++)
            {
                for (int j = 0; j <= size / 2 - dot; j++)
                {
                    line += " ";
                }
                for (int k = 0; k<space; k++ )
                {
                    line += "*";
                }
                Console.WriteLine(line);
                line = string.Empty;
                dot++;
                space += 2;
            }
            dot -= 3;
            space -= 4;
            //druga połowa
            for (int i = 0; i < size / 2; i++)
            {
                for (int j = 0; j<size/2 - dot; j++)
                {
                    line += " ";
                }
                for (int k = 0; k < space; k++)
                {
                    line += "*";
                }
                space -= 2;
                Console.WriteLine(line);
                line = string.Empty;
                dot--;
            }
        }
    }
}




            
