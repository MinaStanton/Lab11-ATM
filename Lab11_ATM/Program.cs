using System;
using System.Collections.Generic;

namespace Lab11_ATM
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello and welcome to the ATM!");

            List<Account> accounts = new List<Account>
            {
                {new Account("Joker", "Heath_Ledger", 500.50 ) }, {new Account("Batman", "BatMobile", 2000.46)}, {new Account("Harely", "Quinn", 2.50)}, {new Account("test", "test", 1.50)}
            };

            bool userContinue = true;
            while (userContinue)
            {

                string output = RegisterOrLogin($"Please make the following selection: \n1. Register \n2. Login", accounts);

                bool exitProgram;
                userContinue = UserOption("Would you like to register or Login? (y/n)", "y", "n");

            }

            Console.WriteLine("Thanks for using the ATM. Goodbye!");
            //PrintList(accounts);
        }

        public static string GetUserInput(string message)
        {
            Console.WriteLine(message);
            return Console.ReadLine();
        }
        public static bool UserOption(string message, string option1_true, string option2_false)
        {
            string input = "";
            while (input.ToLower() != option1_true && input.ToLower() != option2_false)
            {
                input = GetUserInput(message);
            }
            if (input == option1_true)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static string RegisterOrLogin(string message, List<Account> accounts)
        {
            string output = "";
            try
            {
                int choice = int.Parse(GetUserInput(message));
                if (choice - 1 == 0)
                {
                    //call on Register method
                    string username = GetUserInput("Please enter a username: ");
                    string password = GetUserInput("Please enter a password: ");
                    ATM.Register(username, password, accounts); 
                }
                else if (choice - 1 == 1)
                {
                    //call LogIn method
                     
                    string username = GetUserInput("Please enter your username: ");
                    string password = GetUserInput("Please enter your password: ");
                    ATM.Login(username, password, accounts);
                    
                }
                else
                {
                    return RegisterOrLogin("Invalid Entry! " + message, accounts);
                }
            }
            catch (IndexOutOfRangeException)
            {
                return RegisterOrLogin("Invalid Numeric Entry! " + message, accounts);
            }
            catch (FormatException)
            {
                return RegisterOrLogin("Invalid Entry! " + message, accounts);
            }

            return output;
        }


        public static void PrintList(List<Account> accounts)
        {
            foreach (Account account in accounts)
            {
                Console.Write($"{account.Name}\t");
                Console.WriteLine(account.GetPassword());
            }

            //for(int i = 0; i < accounts.Count; i++)
            //{
            //    Console.WriteLine(accounts[i].Name);
            //    Console.WriteLine(accounts[i].GetPassword());
            //}
        }

    }
}
