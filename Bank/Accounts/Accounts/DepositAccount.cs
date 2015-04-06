using Accounts.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Accounts.Accounts
{
   public class DepositAccount :Account
    {
        public TimePeriod m_Period;

        public InterestRate m_Interest;
        public DateTime StartDate { private set; get; }
        public DateTime EndDate { private set; get; }

        public TransactionAccount TransactionAccount { get; private set; }

        public DepositAccount(string currency, TimePeriod depositPeriod, InterestRate interestRate, DateTime startDate, DateTime endDate, TransactionAccount transactionAccount) : base(currency)
        {

            this.m_Period = new TimePeriod();
            this.m_Period = depositPeriod;
            this.m_Interest = new InterestRate();
            this.m_Interest = interestRate;
            this.StartDate = startDate;
            this.EndDate = endDate;
            this.TransactionAccount = transactionAccount;
    }

        
    }
}
