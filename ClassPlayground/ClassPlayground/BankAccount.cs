using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace ClassPlayground
{
    internal class BankAccount
    {
        public int accountNumber;
        public string ownerName;
        public string currency;
        public int balance;

        public void Stats()
        {
            Console.WriteLine($"Účet je veden na {ownerName} je veden v měně: {currency} číslo účtu je {accountNumber} a zůstatek je {balance}");
        }

        public void Deposit(int x)
        {
            balance = balance + x;
        }

        public void Withdrawn(int x)
        {
            balance = balance - x;
        }
        public void Trasnsfer (int amount, BankAccount otherAccount)
        {
            if (amount <= balance)
            {
                balance -= amount;
                otherAccount.balance += balance;
            }
            else
            {
                Console.WriteLine("u brokie");
            }

        }
    }
}
