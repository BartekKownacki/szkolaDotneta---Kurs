using System;
using System.Collections.Generic;

namespace HospitalManager
{
    class Program
    {
        static void Main(string[] args)
        {
            //TODO
            //Logowanie Lekarza
            ////1. Logowanie
            ////2. Rejestracja
            //Menu:
            ////1. Sprawdz listę pacjentów w bazie
            ////2. Dodaj nowego pacjenta do listy pacjentów
            ////3. Usuń pacjenta
            ////4. Przypisz chorobę do pacjenta
            ////5. Sprawdz wczesniejsze choroby danego pacjenta (PESEL)
            ////6. Wygeneruj receptę (.txt) dla pacjenta (wykorzystując gotowy szablon)
            ////7. Wylogowanie
            //////2a. Id(numer pacjenta), Imie, Nazwisko, PESEL, Numer telefonu, Adres Email
            //////3a. Usuwanie poprzez podanie id lub numeru PESEL
            //////4a. Wybór kategorii: Zakaźna, Nowotwór, Przewlekła, Cywilizacyjna, Psychiczne, Genetyczne itd...
            //////4b. Wybór stopnia zaawansowania choroby (1-5) - różny kolor czcionki przy wypisywaniu w konsoli
            //////4c. Opis objawów
            //////4d. Zalecenia
            //////5a. Recepta: id lekarza, Zalecenia, Dawkowanie leków 

            MenuActionService menuActionService = new MenuActionService();
            menuActionService = Initialize(menuActionService);
            var loginMenu = menuActionService.GetMenuActionsByMenuName("Login");

            LoginActionService loginActionService = new LoginActionService();
            LoginAction user = new LoginAction();
            bool isUserLoggedIn = false;
            bool isAnOption = true;
            do
            {
                Console.WriteLine("Please choose what you want to do: ");
                foreach (var element in loginMenu)
                {
                    Console.WriteLine($"{ element.Id }. {element.Name}");
                }
                do
                {
                    var option = Console.ReadKey();
                    switch (option.KeyChar)
                    {
                        case '1':
                            Console.Clear();
                            Console.WriteLine($"===Log in===");
                            user = loginActionService.GetLoginData(user, ref isUserLoggedIn);
                            Console.WriteLine($"You have successfully logged in! Your ID number is: {user.Id}");
                            ConsoleActions.ShowWaitingDots();
                            isUserLoggedIn = true;
                            break;
                        case '2':
                            Console.Clear();
                            Console.WriteLine($"===Register===");
                            user = loginActionService.GetRegisterData(user);
                            Console.WriteLine($"You have successfully registered! Your ID number is: {user.Id}");
                            ConsoleActions.ShowWaitingDots();
                            isUserLoggedIn = true;
                            break;
                        default:
                            ConsoleActions.ClearChosenNumberFromLine();
                            Console.WriteLine($"Operation number {option.KeyChar} does not exist please try again");
                            isAnOption = false;
                            break;
                    }
                }
                while (!isAnOption);
            }
            while (!isUserLoggedIn);

            //User can choose what he want to do
            loginMenu = menuActionService.GetMenuActionsByMenuName("mainMenu");
            Console.WriteLine("Please choose what you want to do: ");
            foreach (var element in loginMenu)
            {
                Console.WriteLine($"{ element.Id }. {element.Name}");
            }

            PatientService patientService = new PatientService();
            do
            {
                var option = Console.ReadKey();
                switch (option.KeyChar)
                {
                    case '1':
                        List<Patient> patients = new List<Patient>();
                        patients=patientService.GetAllPatients();
                        foreach(var patient in patients)
                        {
                            Console.WriteLine($"{patient.Id} | " +
                                $"{patient.FirstName} {patient.LastName}  | " +
                                $"PESEL: {patient.PESEL} | " +
                                $"Tel: {patient.PhoneNumber} | " +
                                $"E-mail: {patient.EmailAdress}");

                        }
                        break;
                    case '2':
                        patientService.GetNewPatientData(user);
                        break;
                    case '3':
                        Console.WriteLine("Do you want to remove by PESEL number or ID number: \n1. PESEL\n2. ID" );
                        switch (option.KeyChar)
                        {
                            case '1':
                                string pesel;
                                patientService.RemoveByPesel(pesel)
                                break;

                        }
                        break;
                    default:
                        ConsoleActions.ClearChosenNumberFromLine();
                        Console.WriteLine($"Operation number {option.KeyChar} does not exist please try again");
                        isAnOption = false;
                        break;
                }
            }
            while (!isAnOption);
        }

        private static MenuActionService Initialize(MenuActionService menuActionService)
        {
            //Login menu
            menuActionService.AddNewAction(1, "Login", "Login");
            menuActionService.AddNewAction(2, "Register", "Login");

            //ActionMenu
            menuActionService.AddNewAction(1, "Show patients list", "mainMenu");
            menuActionService.AddNewAction(2, "Add new patient", "mainMenu");
            menuActionService.AddNewAction(3, "Remove patient", "mainMenu");
            menuActionService.AddNewAction(4, "Add new illness to patient", "mainMenu");
            menuActionService.AddNewAction(5, "Generate prescription for patient (txt file)", "mainMenu");
            menuActionService.AddNewAction(6, "Sign out", "mainMenu");


            return menuActionService;
        }
    }
}
