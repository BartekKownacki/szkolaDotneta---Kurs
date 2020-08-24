using System;
using System.Collections.Generic;

namespace HospitalManager
{
    public class LoginActionService
    {
        private List<LoginAction> loginActions;
        public LoginActionService()
        {
            loginActions = new List<LoginAction>();
        }
        
        public LoginAction GetRegisterData(LoginAction user)
        {
            
            string login, password;
            int id;
            Console.Write("Please write your login: ");
            login = Console.ReadLine();
            Console.Write("Please write your password: ");
            password = Console.ReadLine();
            Console.Write("Please write your ID number: ");
            Int32.TryParse(Console.ReadLine(), out id);
            Register(login, password, id);
            user = new LoginAction() { Login = login, Password = password, Id = id };
            return user;
        }

        private void Register(string login, string password, int id)
        {
            LoginAction loginAction = new LoginAction() { Login = login, Password = password, Id = id};
            loginActions.Add(loginAction);
        }

        public LoginAction GetLoginData(LoginAction user, ref bool isLoggedIn)
        {
            Console.Write("Please write your login: ");
            user.Login = Console.ReadLine();
            Console.Write("Please write your password: ");
            user.Password = Console.ReadLine();
            bool isLogged;
            isLogged = SignIn(ref user);
            if (isLogged)
            {
                Console.WriteLine("You have successfully loggged in!");
                isLoggedIn = true;
            }
            else
            {
                Console.WriteLine("There is an error during your logging in...");
                isLoggedIn = false;
            }
            return user;
        }

        private bool SignIn(ref LoginAction userToLogIn)
        {
            foreach(var user in loginActions)
            {
                if (user.Login == userToLogIn.Login && user.Password == userToLogIn.Password)
                {
                    userToLogIn.Id = user.Id;
                }
            }
            if(userToLogIn.Id != 0)
            {
                return true;
            }
            else
            {
                return false;
            }
            
        }

        public void ShowAllDoctors()
        {
            foreach (var user in loginActions)
            {
                Console.WriteLine(user.Id);
            }
        }
    }
}
