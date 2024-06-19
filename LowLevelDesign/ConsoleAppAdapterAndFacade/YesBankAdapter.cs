using System;

namespace ConsoleAppAdapterAndFacade
{
    public class YesBankAdapter : IBankApi
    {
        public void CheckBalance ()
        {
            //Yes Bank API Call for CheckBalance
            Console.WriteLine("Yes Bank Account Balance is 478000");
        }

        public void SendMoney(string fromAccount, string toAccount, double amount)
        {
            //Yes Bank API Call for SendMoney
            Console.WriteLine($"Yes Bank {amount} has been transferred from {fromAccount} to {toAccount}.");
        }
    }
}
