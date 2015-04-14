using Accounts.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Accounts.Processors
{
      public  class TransactionLogEntry
    {
        public TransactionType TransactionType { get; set; }
        public CurrencyAmount CurrencyAmount{ get; set; }
        public List<IAccount> Accounts { get; set; }
        public TransactionStatus Status { get; set; }

        public TransactionLogEntry() {

            Accounts = new List<IAccount>();
        }

    }
}
