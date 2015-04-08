using Accounts.Helper;
using Accounts.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Accounts.Accounts
{
    public class LoanAccount : DepositAccount, ILoanAccount
    {


        public LoanAccount(string currency, TimePeriod depositPeriod, InterestRate interestRate, DateTime startDate, DateTime endDate, ITransactionAccount transactionAccount)
            : base(currency, depositPeriod, interestRate, startDate, endDate, transactionAccount)
        {
            int Id = AccountHelper.GenerateAccountId();
            this.ID = Id;
            this.Number = GenerateAccountNumber();
        }

       public override TransactionStatus DebitAmount(CurrencyAmount amount)
       {
           return base.CreditAmount(amount);
       }

       public override TransactionStatus CreditAmount(CurrencyAmount amount)
       {
           return base.DebitAmount(amount);
       }

       protected override string GenerateAccountNumber()
       {
           return AccountHelper.GenerateAccountNumber(typeof(LoanAccount), this.ID);
       }

       

    }
}
