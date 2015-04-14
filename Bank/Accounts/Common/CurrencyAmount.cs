using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Accounts
{
  public  struct CurrencyAmount
    {
      public readonly decimal Amount;
      public readonly string Currency;

        public CurrencyAmount(decimal amount, string currency) 
        {
            this.Amount = amount;
            this.Currency = currency;
        }

    }
}
