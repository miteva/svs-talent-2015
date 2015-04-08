using Accounts.Accounts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Accounts.Interfaces
{
   public  interface  IDeposiAccount :IAccount
    {
         /// <summary>
         /// properties
         /// </summary>
         DateTime StartDate {  get; }
         DateTime EndDate {  get; }
         ITransactionAccount TransactionAccount { get; }
    }
}
