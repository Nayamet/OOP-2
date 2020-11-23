using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Final_First_Lab
{
    class Program
    {
        static void Main(string[] args)
        {
            Account a1 = new Savings("Nayamet Ullah", "A101", 5000);
            a1.ShowInfo();
            a1.Deposit(5000);
            a1.Withdraw(9700);
            a1.ShowInfo();
            Console.WriteLine();
           /* int a = Int32.Parse(DateTime.Now.Year.ToString());
            Console.WriteLine(DateTime.Now.Year.ToString());*/
            Account a2 = new Fixed("Nayamet Ullah", "A101", 5000,5,2015);
            a2.ShowInfo();
            a2.Deposit(5000);
            a2.Withdraw(9700);
            a2.ShowInfo();
            
        }
    }
}
