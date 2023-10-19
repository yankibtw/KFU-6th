namespace Tumakov
{
    enum BankTypes
    {
        Сберегательный,
        Текущий
    }
    class Bank
    {
        private uint accountNumber;
        private decimal accountBalance;
        private BankTypes accountBankType;

        public Bank(uint accountNumber, decimal accountBalance, BankTypes accountBankType)
        {
            this.accountNumber = accountNumber;
            this.accountBalance = accountBalance;
            this.accountBankType = accountBankType;
        }
        public uint GetAccountNumber()
        {
            return accountNumber;
        }
        public decimal GetAccountBalance()
        {
            return accountBalance;
        }
        public BankTypes GetAccountBankType()
        {
            return accountBankType;
        }
        public void UpdateAccountNumber(uint accountNumber)
        {
            this.accountNumber = accountNumber;
        }
        public void UpdateAccountBalance(decimal accountBalance)
        {
            this.accountBalance = accountBalance;
        }
        public void UpdateAccountBankType(BankTypes accountBankType)
        {
            this.accountBankType = accountBankType;
        }
        public void ReplenishAccountBalance(decimal accountBalance)
        {
            this.accountBalance += accountBalance;
        }
        public void WithdrawAccountBalance(decimal accountBalance)
        {
            this.accountBalance -= accountBalance;
        }

    }
}
