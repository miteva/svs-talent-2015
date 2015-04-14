using Accounts.Helper;
using Accounts.Interfaces;
using MyAttribute;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Accounts.Accounts
{
    [AccountMetadata(AccountDescription = "Transaction Account", AccountLimitations = "You need amount and currency to create this type of Account")]
   public class TransactionAccount :Account, ITransactionAccount
    {
        private CurrencyAmount m_Limit;
        public CurrencyAmount Limit { private set {
            m_Limit = value;
        }
            get {

                return m_Limit;
            }
        } 

        public TransactionAccount(decimal limitAccount, string currency) :base(currency)
        {
            CurrencyAmount amount = new CurrencyAmount(limitAccount,currency);
           // amount.Amount=limitAccount;
          //  amount.Currency=currency;
            this.m_Limit = new CurrencyAmount(limitAccount, currency);
            //this.m_Limit.Amount = limitAccount;
            //this.m_Limit.Currency = currency;
            this.Ballance = amount;
            
            
        }

        
        protected override string GenerateAccountNumber()
       {
           return AccountHelper.GenerateAccountNumber<TransactionAccount>(this.ID);
         }



    }
}
