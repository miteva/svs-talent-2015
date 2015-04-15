using Accounts.Accounts;
using Accounts;
using Accounts.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Logger;
using Accounts.Helper;

namespace Accounts.Processors
{
  public  class TransactionProcessor :ITransactionProcessor
    {
        private IList<TransactionLogEntry> m_transactionLog;

        private static TransactionProcessor sTransactionProcessor;

        public TransactionLogEntry LastTransaction { get {

                if (m_transactionLog.Count > 0)
                    return m_transactionLog.Last();
                else
                    return null;

            } }

        public int TransactionCount
        {
        get {

                return m_transactionLog.Count;
            } }

        public TransactionLogEntry this[int number] {
            get
            {
                if (number > m_transactionLog.Count || number < 0)
                    return null;
                else
                    return
                        m_transactionLog.ElementAt(number);
            }
        }
        private TransactionProcessor()
        {
            m_transactionLog = new List<TransactionLogEntry>();
        }

        private TransactionLogger m_ExternalLogger;
       public  TransactionLogger ExternalLogger
       {
           set { m_ExternalLogger = value; }
           get { return m_ExternalLogger; }
         }

       private void CallExternalLogger(IAccount account, TransactionType transactionType, CurrencyAmount amount) 
       {
           ExternalLogger(account, transactionType, amount);
       }

        public TransactionStatus ProcessTransaction(IAccount accountFrom, IAccount accountTo,CurrencyAmount amount,TransactionType transactionType)
        {
            
           
            IAccount[] accountsArray = new IAccount[2];
            TransactionStatus status = new TransactionStatus();

            if (transactionType == TransactionType.Transfer)
            {
                if (accountTo.CreditAmount(amount) == TransactionStatus.Completed && accountFrom.DebitAmount(amount) == TransactionStatus.Completed)
                {
                    CallExternalLogger(accountTo, transactionType, amount);
                    CallExternalLogger(accountFrom, transactionType, amount);
                    accountsArray[0] = accountTo;
                    accountsArray[1] = accountFrom;
                   
                    status = TransactionStatus.Completed;
                }
                else
                {
                    status = TransactionStatus.Failed;
                }
                LogTransaction(transactionType, amount, accountsArray,status);
            }

            if (transactionType == TransactionType.Debit)
           {  accountFrom.DebitAmount(amount);
           CallExternalLogger(accountFrom, transactionType, amount);
           }
           
            if (transactionType == TransactionType.Credit)
           { 
                accountFrom.CreditAmount(amount);
                CallExternalLogger(accountTo, transactionType, amount);
               
           }



            return status;
        }

        public TransactionStatus ProcessGroupTransaction(TransactionType transactionType, CurrencyAmount amount, IAccount[] accounts)
        {
            TransactionStatus status = new TransactionStatus();
            if (transactionType != TransactionType.Credit && transactionType != TransactionType.Debit )
            {
                return TransactionStatus.Failed;

            }
             

            else
            {
                if (accounts == null)
                {
                    status = TransactionStatus.Failed;
                    LogTransaction(transactionType, amount, accounts, status);
                    return TransactionStatus.Failed;
                }

                if (transactionType == TransactionType.Credit)
                {

                    foreach (Account a in accounts)
                    {
                        if (a != null)
                        {
                            a.CreditAmount(amount);
                            CallExternalLogger(a, transactionType, amount);
                        }
                        else
                            continue;
                    }
                    status = TransactionStatus.Completed;
                    LogTransaction(transactionType, amount, accounts, status);
                    return TransactionStatus.Completed;
                }
                else
                {
                    foreach (Account a in accounts)
                    {
                        if (a != null)
                        {
                            a.DebitAmount(amount);
                            CallExternalLogger(a, transactionType, amount);
                        }
                        else
                            continue;
                    }
                    status = TransactionStatus.Completed;
                    LogTransaction(transactionType, amount, accounts, status);
                    return TransactionStatus.Completed;
                }
                }
            }

        private void LogTransaction(TransactionType transactionType, CurrencyAmount amount, IAccount[] accounts, TransactionStatus transactionStatus)
        {
            TransactionLogEntry log = new TransactionLogEntry();
            
            log.CurrencyAmount = amount;
            log.TransactionType = transactionType;
            log.Accounts.Add(accounts[0]);
            log.Accounts.Add(accounts[1]);
            m_transactionLog.Add(log);
        }

        #region Singleton Pattern

        static TransactionProcessor()
        {
            sTransactionProcessor = new TransactionProcessor();
            sTransactionProcessor.ExternalLogger += AccountHelper.LogTransaction;
            sTransactionProcessor.ExternalLogger += AccountHelper.NotifyNationalBank;

        }

        public static TransactionProcessor GetTransactionProcessor() {
            
            return sTransactionProcessor;
        }
        #endregion


        public TransactionStatus ChargeProcessingFee(CurrencyAmount amount, IEnumerable<IAccount> accounts)
        {
            throw new NotImplementedException();
        }
    }

    }


