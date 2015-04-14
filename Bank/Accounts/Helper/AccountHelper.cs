using Accounts.Accounts;
using Accounts.Interfaces;
using Logger;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Accounts.Helper
{
   public static class AccountHelper
    {
       private static int s_AccountId;

       public static int GenerateAccountId() 
       {

           Random r = new Random();
           s_AccountId = r.Next(100, 1000);
           s_AccountId += 1;
            return s_AccountId;
       
       }

       static AccountHelper() {

           s_AccountId = 0;
       }

      
       public static string GenerateAccountNumber(Type accountType,long accountId) 
       {
           string number=null;
           if (accountType == typeof(TransactionAccount))
               number = "TR000" + GenerateAccountId();
           if (accountType == typeof(DepositAccount))
               number = "DP000" + GenerateAccountId();
           if (accountType == typeof(LoanAccount))
               number = "LN000" + GenerateAccountId();

           return number;
       }

       public new static string GenerateAccountNumber<T>(long accountID) where T : IAccount
       {
           if (typeof(T) == typeof(TransactionAccount))
               return GenerateAccountNumber(typeof(TransactionAccount), accountID);
           if (typeof(T) == typeof(DepositAccount))
               return GenerateAccountNumber(typeof(DepositAccount), accountID);
           if (typeof(T) == typeof(LoanAccount))
               return GenerateAccountNumber(typeof(LoanAccount), accountID);
           else return "error";

       }

       public static void LogTransaction(IAccount account, TransactionType transactionType, CurrencyAmount amount) 
       {
           if (amount.Amount > 20000 && amount.Currency == "MKD")
           {
               Console.WriteLine("Account number: " + account.Number + " transaction type: " + transactionType + " amount: " + amount.Amount + " in currency: " + amount.Currency);
               Console.ReadLine();
           }
       }

       public static void NotifyNationalBank(IAccount account, TransactionType transactionType, CurrencyAmount amount)
       {
           if (amount.Amount > 25000 && amount.Currency == "MKD")
           {
               Console.WriteLine(" Notify National bank about this transaction: Account number: " + account.Number + " transaction type: " + transactionType + " amount: " + amount.Amount + " in currency: " + amount.Currency);
               Console.ReadLine();
           }
       }
    }
}
