using Accounts.Accounts;
using Accounts.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Accounts.Processors
{
  public  class TransactionProcessor :ITransactionProcessor
    {
        public List<Account> ProcessTransaction(IAccount accountFrom, IAccount accountTo,CurrencyAmount amount,TransactionType transactionType)
        {
            
            DepositAccount da = (DepositAccount)accountTo;
            TransactionAccount ta = (TransactionAccount)accountFrom;
            List<Account> accounts=new List<Account>();

            if (transactionType == TransactionType.Transfer)
            {

                if (accountTo.CreditAmount(amount) == TransactionStatus.Completed && accountFrom.DebitAmount(amount) == TransactionStatus.Completed)
                {
                    da.m_Balance.Amount = amount.Amount;
                    ta.m_Balance.Amount = amount.Amount;

                }
            }

           if (transactionType == TransactionType.Debit)
           {  accountFrom.DebitAmount(amount);
               ta.m_Balance.Amount-=amount.Amount;
           }
                
              
           if (transactionType == TransactionType.Credit)
           { accountFrom.CreditAmount(amount);
               ta.m_Balance.Amount+=amount.Amount;
           }
                
               accounts.Add(ta);
               accounts.Add(da);
               int i = 0;
               return accounts;

           
        }

    }
}
