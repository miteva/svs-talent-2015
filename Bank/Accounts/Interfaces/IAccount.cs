using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Accounts.Interfaces
{
  public  interface IAccount
    {
      /// <summary>
      /// property
      /// </summary>
      /// <returns></returns>
        int ID{get;}

      /// <summary>
      /// methods
      /// </summary>
      /// <param name="amount"></param>
      /// <returns></returns>
        TransactionStatus DebitAmount(CurrencyAmount amount);
        TransactionStatus CreditAmount(CurrencyAmount amount);
       

    }
}
