using System;

namespace ConsoleAppAdapterAndFacade
{
    public class HDFCBankAdapter : IBankApi
    {
        public void CheckBalance()
        {
            //HDFC Bank API Call for CheckBalance
            Console.WriteLine("HDFC Bank Account Balance is 778000");
        }

        public void SendMoney(string fromAccount, string toAccount, double amount)
        {
            //HDFC Bank API Call for SendMoney
            Console.WriteLine($"HDFC Bank {amount} has been transferred from {fromAccount} to {toAccount}.");
        }
    }
}
