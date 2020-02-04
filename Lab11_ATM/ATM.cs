using System;
using System.Collections.Generic;
using System.Text;

namespace Lab11_ATM
{
    class ATM
    {
        // public bool IsLoggedIn { get; set; } 
        private bool isLoggedIn;
        
        public bool IsloggedIn
        {
            get { return isLoggedIn; }
            set { isLoggedIn = IsloggedIn; }
        }
        public ATM() { }

        public ATM(bool _IsLoggedIn)
        {
            isLoggedIn = _IsLoggedIn;

        }
        //methods
        public static bool GetIsLogIn()
        {
            return true;
        }

        public static void Register(string userName, string password, List<Account> accounts)
        {

            Account newAccount = new Account(userName, password);
            accounts.Add(newAccount); 

        }

        public static void Login(string userName, string password, List<Account> accounts)
        {
            //while (!IsLoggedIn)
            //{
                for (int i = 0; i < accounts.Count; i++)
            {
                if(userName == accounts[i].Name && password == accounts[i].GetPassword())
                {
                  bool logInConfirmed =  GetIsLogIn(); 
                    currentUser(accounts[i]);
                    break;
                }
            }

                //if (!IsLoggedIn)//fix this for validation!
                //{
                //    Console.WriteLine("Invalid Entry!");
                //    Program.RegisterOrLogin("Please enter a valid username and password.");
                //}
            }
       // }

        public static void currentUser(Account currentAccount)
        {

            //add while loop for validation

           
            Console.WriteLine($"{currentAccount.Name}, please choose from the following options: ");
            string userChoice = Program.GetUserInput(("1. Check Balance \n2. Make a Deposit \n3. Make a withdrawl \n4. Logout "));
            
            int numChoice = int.Parse(userChoice); 

            if(numChoice -1 == 0)
            {
                //send to check balance
            }
           else if(numChoice -1 == 1)
            {
                //send to Make a deposit
            }
            else if(numChoice -1 == 2)
            {
                //send to make a withdrawl
            }
            else if(numChoice -1 == 3)
            {
                //send to logout
            }
            else
            {
                //validate and repeat choices
            }
        }

    }
}
