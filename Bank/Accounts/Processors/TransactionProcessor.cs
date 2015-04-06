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
        public void ProcessTransaction(IAccount accountFrom, IAccount accountTo,CurrencyAmount amount,TransactionType transactionType)
        {

           if(transactionType==TransactionType.Transfer)
            {
                
                    accountTo.CreditAmount(amount);
                    accountFrom.DebitAmount(amount);
              }

            if (transactionType == TransactionType.Debit)
                accountFrom.DebitAmount(amount);
            if(transactionType==TransactionType.Credit)
                accountFrom.CreditAmount(amount);
                

        }

    }
}
