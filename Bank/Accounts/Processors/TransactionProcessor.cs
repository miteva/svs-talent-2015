using Accounts.Accounts;
using Accounts.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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

        public TransactionStatus ProcessTransaction(IAccount accountFrom, IAccount accountTo,CurrencyAmount amount,TransactionType transactionType)
        {
            
            DepositAccount da = (DepositAccount)accountTo;
            TransactionAccount ta = (TransactionAccount)accountFrom;
            IAccount[] accountsArray = new IAccount[2];
            TransactionStatus status = new TransactionStatus();

            if (transactionType == TransactionType.Transfer)
            {
                if (accountTo.CreditAmount(amount) == TransactionStatus.Completed && accountFrom.DebitAmount(amount) == TransactionStatus.Completed)
                {
                   
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
               ta.m_Balance.Amount-=amount.Amount;
           }
           
            if (transactionType == TransactionType.Credit)
           { accountFrom.CreditAmount(amount);
               ta.m_Balance.Amount+=amount.Amount;
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
                            a.CreditAmount(amount);
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
                            a.DebitAmount(amount);
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
            log.Accounts = new List<IAccount>();
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
        }
        public static TransactionProcessor GetTransactionProcessor() {
            
            return sTransactionProcessor;
        }
        #endregion
    }

    }


