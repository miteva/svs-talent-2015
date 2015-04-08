using Accounts.Helper;
using Accounts.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Accounts
{
   public abstract class Account :IAccount
    {
        private int m_ID;

        public int ID {
             set {

                this.m_ID = value;
            }
         get {
                return m_ID;
            }
        }
        public string Currency { private set; get; }
        public string Number {  set; get; }

        public CurrencyAmount m_Balance;
        


        public Account(int ID, string Currency, string Number)
        {

            this.ID = ID;
            this.Currency = Currency;
            this.Number = Number;
            this.m_Balance= new CurrencyAmount();
            this.m_Balance.Amount = 0;
            this.m_Balance.Currency = Currency;
        }

        public Account(string Currency) :this(AccountHelper.GenerateAccountId(),Currency,"X") {

            
            
        }
        

        #region Public Methods

        public virtual TransactionStatus DebitAmount(CurrencyAmount amount) {

            TransactionStatus status = CheckCurrency(amount.Currency);
            if (status == TransactionStatus.Completed && this.m_Balance.Amount>=amount.Amount)
            {
                this.m_Balance.Amount -= amount.Amount;
                return TransactionStatus.Completed;
            }
            else
            {
                return status;
            }
        }
        public virtual TransactionStatus CreditAmount(CurrencyAmount amount)
        {
            TransactionStatus status = CheckCurrency(amount.Currency);
            if (status == TransactionStatus.Completed)
            {
                this.m_Balance.Amount += amount.Amount;
                return TransactionStatus.Completed;
            }
            else
            {
                return status;
            }
        }



        #endregion

        #region Private methods
        private TransactionStatus CheckCurrency(string currency) {

            if (this.Currency == currency) {

                return TransactionStatus.Completed;

            }
            else return TransactionStatus.Failed;
        }

        #endregion

        #region Protected methods
        protected abstract string GenerateAccountNumber();
        
        #endregion

    }
}
