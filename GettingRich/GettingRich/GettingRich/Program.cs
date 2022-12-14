using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GettingRich
{
    class Program
    {
        public static void Main (string[] args)
        {
            //Creates accounts
            InvestmentAccount savingsAccount = new SavingsAccount(0.0f, 2.5f);
            InvestmentAccount mutualFund = new MutualFund(2.5f);
            InvestmentAccount employerSponsoredAccount = new EmployerSponsoredAccount(2.5f);
            //InvestmentAccount investmentAccount = new InvestmentAccount(0.0f);

            //Puts money in each account
            savingsAccount.AddMoney(7.0f);
            mutualFund.AddMoney(77.0f);
            employerSponsoredAccount.AddMoney(777.0f);

            //Prints out the accounts
            Console.WriteLine(savingsAccount);
            Console.WriteLine(mutualFund);
            Console.WriteLine(employerSponsoredAccount);

            //Class specific operations
            (savingsAccount as SavingsAccount).UpdateBalance();
            (mutualFund as MutualFund).UpdateBalance();

            //Prints out each account
            Console.WriteLine(savingsAccount);
            Console.WriteLine(mutualFund);
            Console.WriteLine(employerSponsoredAccount);

            //This line allows the program to stay open.
            //For some reason it wont stay running without it
            //at least when I run the program.
            int userInput = int.Parse(Console.ReadLine());

            Console.WriteLine(); 
        }
    }
}
