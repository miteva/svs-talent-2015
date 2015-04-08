using Accounts.Accounts;
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
    }
}
