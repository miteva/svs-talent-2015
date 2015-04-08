using Accounts.Helper;
using Accounts.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Accounts.Accounts
{
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

            this.m_Limit = new CurrencyAmount();
            this.m_Limit.Amount = limitAccount;
            this.m_Limit.Currency = currency;
            int Id = AccountHelper.GenerateAccountId();
            this.ID = Id;
            this.Number = GenerateAccountNumber();
            
        }

        
        protected override string GenerateAccountNumber()
       {
           return AccountHelper.GenerateAccountNumber(typeof(TransactionAccount), this.ID);
         }



    }
}
