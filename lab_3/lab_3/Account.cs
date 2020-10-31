using System;
using System.Collections.Generic;
using System.Text;

namespace lab_3
{
    class Account
    {
        string accName;
        string acId;
        int balance;
        public string AccName
        {
            set { accName = value; }
            get { return accName; }
        }
        public string AcId
        {
            set { acId = value; }
            get { return acId; }
        }
        public int Balance
        {
            set { balance = value; }
            get { return balance; }
        }

        public void Deposite(int amount)
        {
            if (amount > 0)
            {
                Console.WriteLine("Name : " + accName);
                Console.WriteLine("Acc ID : " + acId);
                Console.WriteLine("Balance : " + balance);
                balance += amount;
                Console.WriteLine("Deposite Amount : " + amount);
                Console.WriteLine("Current Balance : " + balance);
            }
            else
                Console.WriteLine("Deposite unsuccessful.");

        }

        public void Withdraw(int amount)
        {
            if (amount > 0 && amount <= balance)
            {
                Console.WriteLine("Name : " + accName);
                Console.WriteLine("Acc ID : " + acId);
                Console.WriteLine("Balance : " + balance);
                balance -= amount;
                Console.WriteLine("Withdraw Amount : " + amount);
                Console.WriteLine("Current Balance : " + balance);
            }
            else
                Console.WriteLine("Withdraw unsuccessful.");
        }
    }
}
