using System;

namespace ConsoleAppAdapterAndFacade
{
    internal class Program
    {
        static void Main(string[] args)
        {
            PhonePay phonePay = new PhonePay(new YesBankAdapter());
            phonePay.fetchBalance();
            phonePay.TransferMoney(100000, "7894561230", "7418529630");

            //PhonePay phonePay1 = new PhonePay(new HDFCBankAdapter());
            //phonePay1.fetchBalance();
            //phonePay1.TransferMoney(150000, "22514419600", "28922525655");

            Console.ReadKey();
        }
    }
}
