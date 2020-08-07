using System;

namespace Zad_tydz2_4
{
    public class zad5
    {
        public zad5()
        {
            string name, lastName, emailAdress;
            int phoneNumber, age;
            double weight, height; //weight - kilograms, height - meters
            bool isHungry;
            gender gender;
            DateTime dateAdded;

            Console.Write("Please write your name: ");
            name = Console.ReadLine();
            Console.Write("Please write your last name: ");
            lastName = Console.ReadLine();
            Console.Write("Please write your email adress: ");
            emailAdress = Console.ReadLine();
            Console.Write("Please write your phone number: ");
            Int32.TryParse(Console.ReadLine(), out phoneNumber);
            Console.Write("Please write how old are you: ");
            Int32.TryParse(Console.ReadLine(), out age);
            Console.Write("Please write your weight in kilograms: ");
            Double.TryParse(Console.ReadLine(), out weight);
            Console.Write("Please write your height in meters: ");
            Double.TryParse(Console.ReadLine(), out height);
            Console.Write("Are you hungry? (yes/no): ");
            string answer = Console.ReadLine().ToLower();
            isHungry = answer=="yes" ? true : false;
            Console.Write("Please choose your gender:\n1. Male \n2.Female \nWrite chosen number (1/2): ");
            Enum.TryParse(Console.ReadLine(), out gender);
            Console.WriteLine(gender);
            dateAdded = DateTime.Now;
            Console.WriteLine($"You created new person at{dateAdded.ToString("G")}");


        }
        public enum gender
        {
            M = 1,
            K
        }

    }
}