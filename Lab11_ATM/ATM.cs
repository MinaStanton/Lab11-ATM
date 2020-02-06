using System;
using System.Collections.Generic;
using System.Text;

namespace Lab11_ATM
{
    class ATM
    {
         public bool IsLoggedIn { get; set; } 
        //private bool isLoggedIn;
        
        //public bool IsloggedIn
        //{
        //    get { return isLoggedIn; }
        //    set { isLoggedIn = IsloggedIn; }
        //}
        public ATM() { }

        public ATM(bool _IsLoggedIn)
        {
            IsLoggedIn = _IsLoggedIn;

        }
        //methods
        public static void SetIsLogIn(bool login)
        {
            ATM setLogin = new ATM(login);
             
        }
      

        public static void Register(string userName, string password, List<Account> accounts)
        {

            Account newAccount = new Account(userName, password);
            accounts.Add(newAccount);
            Login(userName, password, accounts); 
          

        }

        public static void Login(string userName, string password, List<Account> accounts)
        {
            //while (!IsLoggedIn)
            //{
           // ATM isLogIn = new ATM(true);
            int index = 0;
            //bool logInConfirmed = false;
            for (int i = 0; i < accounts.Count; i++)
            {
              
                if (userName == accounts[i].Name && password == accounts[i].GetPassword())
                {
                    //logInConfirmed = true;
                    ATM.SetIsLogIn(true);
                    index = i; 
                    break;
                }
            }
            
                currentUser(accounts[index]);
            
           
            //if (!IsLoggedIn)//fix this for validation!
            //{
            //    Console.WriteLine("Invalid Entry!");
            //    Program.RegisterOrLogin("Please enter a valid username and password.");
            //}
            // }
        }

        public static void currentUser(Account currentAccount)
        {

            //add while loop for validation

           
            Console.WriteLine($"\n{currentAccount.Name}, please choose from the following options: ");
            string userChoice = Program.GetUserInput(("1. Check Balance \n2. Make a Deposit \n3. Make a withdrawl \n4. Logout "));
            
            int numChoice = int.Parse(userChoice); 

            if(numChoice -1 == 0)
            {
                //send to check balance
                GetBalance(currentAccount);
            }
           else if(numChoice -1 == 1)
            {
                //send to Make a deposit
                MakeDeposit(currentAccount);
            }
            else if(numChoice -1 == 2)
            {
                //send to make a withdrawl
                MakeWithdrawl(currentAccount);
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

        public static void GetBalance(Account currentAccount)
        {
            Console.WriteLine($"\nYour balance is: ${currentAccount.Balance}\n");
            currentUser(currentAccount); 
        }

        public static void MakeDeposit(Account currentAccount)
        {
            //Console.WriteLine($"\nYour balance is: {currentAccount.Balance}\n");
            Console.WriteLine("How much would you like to deposit?");
            double deposit = double.Parse(Console.ReadLine());

            currentAccount.Balance += deposit;

            Console.WriteLine($"You deposit has been added. Your total balance is now: ${currentAccount.Balance}\n");

            currentUser(currentAccount);
            //return to main menu

        }
        public static void MakeWithdrawl(Account currentAccount)
        {
            Console.WriteLine("How much would you like to withdraw?");
            double withdrawl = double.Parse(Console.ReadLine());

            currentAccount.Balance -= withdrawl;

            Console.WriteLine($"Your new balance after withdrawl is: ${currentAccount.Balance}");
            currentUser(currentAccount);
        }

        public static void LogOut(Account currentAccount)
        {
            SetIsLogIn(false);
            Console.WriteLine("You have sucessfully logged out!");
            
        }

    }
}
