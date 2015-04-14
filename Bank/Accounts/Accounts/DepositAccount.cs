using Accounts.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Accounts.Accounts;
using Accounts.Helper;
using MyAttribute;

namespace Accounts.Accounts
{
     [AccountMetadata(AccountDescription = "Deposit Account", AccountLimitations = "You need to create Transaction Account in order to create this type of Account")]
     public class DepositAccount :Account, IDeposiAccount
    {
        public TimePeriod m_Period;

        public InterestRate m_Interest;
        public DateTime StartDate { private set; get; }
        public DateTime EndDate { private set; get; }

        public ITransactionAccount TransactionAccount { get; private set; }

        public DepositAccount(string currency, TimePeriod depositPeriod, InterestRate interestRate, DateTime startDate, DateTime endDate, ITransactionAccount transactionAccount) : base(currency)
        {
            
            this.m_Period = new TimePeriod();
            this.m_Period = depositPeriod;
            this.m_Interest = new InterestRate();
            this.m_Interest = interestRate;
            this.StartDate = startDate;
            this.EndDate = endDate;
            this.TransactionAccount = new TransactionAccount(transactionAccount.Limit.Amount, transactionAccount.Limit.Currency);
            CurrencyAmount amount = new CurrencyAmount(transactionAccount.Limit.Amount, transactionAccount.Limit.Currency);
         //   amount.Amount = transactionAccount.Limit.Amount;
         //   amount.Currency = transactionAccount.Limit.Currency;
            this.Ballance = amount;
            
        }
        protected override string GenerateAccountNumber()
        {
            //return AccountHelper.GenerateAccountNumber(typeof(DepositAccount), this.ID);
            return AccountHelper.GenerateAccountNumber<DepositAccount>(this.ID);
        }

        
    }
}
