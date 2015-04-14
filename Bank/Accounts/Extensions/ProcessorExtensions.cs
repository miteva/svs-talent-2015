using Accounts.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Accounts.Extensions
{
    public static class ProcessorExtensions
    {
        public static TransactionStatus ChargeProcessingFee(this ITransactionProcessor processor,CurrencyAmount amount,IEnumerable<IAccount> accounts)
        {
            IAccount[] arrayAccount = accounts.ToArray();
            return processor.ProcessGroupTransaction(TransactionType.Debit, amount, arrayAccount);
        }
    }
}
