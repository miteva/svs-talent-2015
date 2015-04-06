using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Accounts.Accounts
{
   public class TransactionAccount : Account
    {
        private CurrencyAmount m_Limit;

        public TransactionAccount(decimal limitAccount, string currency) : base(currency) {

            this.m_Limit = new CurrencyAmount();
            this.m_Limit.Amount = limitAccount;
            this.m_Limit.Currency = currency;
            

        }

    }
}
