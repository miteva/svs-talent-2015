using Accounts;
using Accounts.Processors;
using Logger;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Accounts.Interfaces
{
    public interface ITransactionProcessor
    {
        TransactionStatus ProcessTransaction(IAccount accountFrom, IAccount accountTo, CurrencyAmount amount, TransactionType transactionType);
        TransactionStatus ProcessGroupTransaction(TransactionType transactionType, CurrencyAmount amount, IAccount[] accounts);
        TransactionLogEntry LastTransaction { get; }
        int TransactionCount { get; }
        TransactionLogger ExternalLogger { set; get; }
        TransactionLogEntry this[int number] { get; }
    }

 
}
