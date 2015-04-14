using Accounts.Helper;
using Accounts.Interfaces;
using MyAttribute;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Accounts.Accounts
{
    [AccountMetadata(AccountDescription = "Loan Account", AccountLimitations = "You need to create Transaction Account in order to create this type of Account")]
    public class LoanAccount : DepositAccount, ILoanAccount
    {


        public LoanAccount(string currency, TimePeriod depositPeriod, InterestRate interestRate, DateTime startDate, DateTime endDate, ITransactionAccount transactionAccount)
            : base(currency, depositPeriod, interestRate, startDate, endDate, transactionAccount)
        {

            this.Ballance = transactionAccount.Limit;
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
           return AccountHelper.GenerateAccountNumber<LoanAccount>( this.ID);
       }

       

    }
}
