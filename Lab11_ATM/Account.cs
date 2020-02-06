using System;
using System.Collections.Generic;
using System.Text;

namespace Lab11_ATM
{
    class Account
    {
        public string Name { get; set; }
        public string Password { private get; set; }

        public double Balance {  get; set; }

        public Account() { }
        public Account(string name, string password)
        {
            Name = name;
            Password = password;
        }
        public Account(string name, string password, double balance)
        {
            Name = name;
            Password = password;
            Balance = balance;
        }

        public string GetPassword()
        {
            return Password; 
        }

     
    }
}
