using Accounts.Common;
using Accounts.Helper;
using Accounts.Interfaces;
using Logger;
using MyAttribute;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Accounts
{
   public abstract class Account :IAccount
    {
       public event EventHandler<Logger.BalanceChangedEventArguments> OnBalanceChanged;
        private int m_ID;

        public int ID {
        private     set {

                this.m_ID = value;
            }
         get {
                return m_ID;
            }
        }
        public string Currency { private set; get; }

       [FormatRestriction(FormatString="XXXX-XXXX-XXXX-XXXX",MaxLength=16)]
       public string Number {  set; get; }


        private CurrencyAmount m_ballance;

        public CurrencyAmount Ballance {

            set
            {
                if (m_ballance.Amount != 0)
                {
                    if (value.Amount != m_ballance.Amount)
                    {
                        BalanceChangedEventArguments arg = new BalanceChangedEventArguments(this, m_ballance);
                        this.OnBalanceChanged(this, arg);
                    }
                }
                m_ballance = value;
                //m_ballance.Amount = value.Amount;
                //m_ballance.Currency = value.Currency;
            }
            get
            {
                return m_ballance;
            }
        
        }

        

        public Account(int ID, string Currency, string Number)
        {
            int Id = AccountHelper.GenerateAccountId();
            this.ID = Id;
            this.Number = GenerateAccountNumber();
            this.Currency = Currency;
            
           
        }

        public Account(string Currency) :this(-1,Currency,"X") {

            
            
        }
        

        #region Public Methods

        public virtual TransactionStatus DebitAmount(CurrencyAmount amount) {

            TransactionStatus status = CheckCurrency(amount.Currency);
            if (status != TransactionStatus.Completed) 
            {
                
                    string difference = String.Format("Provided currency in the amount is " + amount.Currency + " but the currency of the account is " + this.Currency);
                    throw new CurrencyMismatchException(difference);
                
            }
             if (this.Ballance.Amount < amount.Amount)
            {

                string difference = String.Format("Provided amount is " + amount.Amount + " but the amount of the account is " + this.Ballance.Amount);
                throw new LimitReachedException(987,difference);

            }else
           
            {
               
                    decimal b = this.Ballance.Amount;
                    b -= amount.Amount;
                    CurrencyAmount ca = new CurrencyAmount(b, this.Ballance.Currency);
                    this.Ballance = ca;
                    return TransactionStatus.Completed;
                

            }
           
        }
        public virtual TransactionStatus CreditAmount(CurrencyAmount amount)
        {
            TransactionStatus status = CheckCurrency(amount.Currency);
            if (status == TransactionStatus.Completed)
            {
                decimal b = this.Ballance.Amount;
                b += amount.Amount;
                CurrencyAmount ca = new CurrencyAmount(b, this.Ballance.Currency);
                this.Ballance = ca;
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
