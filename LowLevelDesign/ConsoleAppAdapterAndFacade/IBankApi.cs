namespace ConsoleAppAdapterAndFacade
{
    public interface IBankApi
    {
        void CheckBalance();
        void SendMoney(string fromAccount, string toAccount, double amount);
    }
}
