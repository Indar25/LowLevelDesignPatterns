namespace ConsoleAppAdapterAndFacade
{
    public class PhonePay
    {
        private readonly IBankApi _bankAdapter;
        public PhonePay(IBankApi bankAdapter)
        {
            _bankAdapter = bankAdapter;
        }
        public void fetchBalance()
        {
            _bankAdapter.CheckBalance();
        }
        public void TransferMoney(double amount, string toAcc, string fromAcc)
        {
            _bankAdapter.SendMoney(fromAcc, toAcc, amount);
        }
    }
}
