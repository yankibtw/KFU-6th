using System;

namespace Tumakov
{
    class SecondBank
    {
        private static uint accountNumberSeed = 0;
        private uint accountNumber;
        private decimal accountBalance;
        private BankTypes accountBankType;

        public SecondBank(decimal accountBalance, BankTypes accountBankType)
        {
            this.accountNumber = GenerateAccountNumber();
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
        public void UpdateAccountBalance(decimal accountBalance)
        {
            this.accountBalance = accountBalance;
        }
        public void UpdateAccountBankType(BankTypes accountBankType)
        {
            this.accountBankType = accountBankType;
        }
        private uint GenerateAccountNumber()
        {
            accountNumberSeed++;
            return accountNumberSeed;
        }
        public void ReplenishAccountBalance(decimal accountBalance)
        {
            this.accountBalance += accountBalance;
        }
        public void WithdrawAccountBalance(decimal accountBalance)
        {
            if (accountBalance <= this.accountBalance)
            {
                this.accountBalance -= accountBalance;
            }
            else
            {
                Console.WriteLine("Недостаточно денег на счете!");
            }

        }
    }
}
