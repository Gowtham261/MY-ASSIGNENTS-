using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignement_4
{
    class Accounts
    {
        static void Main(string[] args) 
        {
            Console.WriteLine("Create an bank account");
            int Accountnumber;
            string CustomerName;
            string AccountType;
            string TransactionType;
            int amount;
            int balance=0;
            Console.WriteLine("Enter Account Number:");
            Accountnumber = Convert.ToInt32( Console.ReadLine());
            Console.WriteLine("Enter Customer's Name:");
            CustomerName = Console.ReadLine();
            Console.WriteLine("Enter Account Type:");
            AccountType = Console.ReadLine();
            Console.WriteLine("transaction type");
            Console.WriteLine("D->deposite / W->withdraw");
            TransactionType = Console.ReadLine();
            Console.WriteLine("enter amount");
            amount = Convert.ToInt32(Console.ReadLine());
            if (TransactionType == "D")
            {
                balance = balance + amount;
                Console.WriteLine("after deposite"+balance);
            }
            else if (TransactionType == "W") 
            {
                balance = balance - amount;
                Console.WriteLine("after withdraw"+balance);
            }
            Console.ReadLine();

        }
    }
}
