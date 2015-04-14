using Accounts;
using Accounts.Interfaces;
using System;

namespace Logger
{

   public delegate void TransactionLogger(IAccount account, TransactionType transactionType, CurrencyAmount amount);

   public class BalanceChangedEventArguments : EventArgs 
   {
       public IAccount Account { private set; get; }
       public CurrencyAmount Change { private set; get; }

      public BalanceChangedEventArguments(IAccount account,CurrencyAmount change)
       {
           Account = account;
           Change = change;
       }

      public delegate void BalanceChanged(Object sender, BalanceChangedEventArguments eventArgs);
       

   }

}