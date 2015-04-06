using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Accounts.Interfaces
{
  public  interface IAccount
    {
         TransactionStatus DebitAmount(CurrencyAmount amount);
        TransactionStatus CreditAmount(CurrencyAmount amount);
       

    }
}
