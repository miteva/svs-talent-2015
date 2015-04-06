using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Accounts.Interfaces
{
    public interface ITransactionProcessor
    {
        void ProcessTransaction(IAccount accountFrom, IAccount accountTo, CurrencyAmount amount, TransactionType transactionType);

    }
}
