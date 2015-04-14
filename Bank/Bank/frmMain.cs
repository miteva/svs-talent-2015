using Accounts;
using Accounts.Accounts;
using Accounts.Common;
using Accounts.Extensions;
using Accounts.Helper;
using Accounts.Interfaces;
using Accounts.Processors;
using Logger;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Bank
{
    public partial class frmMain : Form
    {
        public EventHandler<Logger.BalanceChangedEventArguments> BalanceChangedDelegate;
        bool _errorOccured = false;
        ITransactionProcessor processor;
        string _errorMsg = "";
        ExceptionLogger exceptionLogger = new ExceptionLogger();

        public frmMain()
        {
            InitializeComponent();
            lblLimitAmount.Text = " ";
            lblLimitCurrency.Text = " ";
            lblPeriodPeriod.Text = "";
            lblPeriodUnit.Text = "";
            lblInterestPercent.Text = "";
            lblInterestUnit.Text = "";
            lblStartDate.Text = "";
            lblEndDate.Text = "";

            lblPeriodPeiod_To.Text = "";
            lblPeriodUnit_To.Text = "";
            lablblInteresetPercent_To.Text = "";
            lblInterestUnit_To.Text = "";
            lblStartDate_To.Text = "";
            lblEndDate_To.Text = "";
            cmbPeriodUnit.SelectedIndex = 0;
            cmbInterestUnit.SelectedIndex = 0;
            BalanceChangedDelegate += PrintDelegateMessage;
            processor = TransactionProcessor.GetTransactionProcessor();

            
        }



        /// <summary>
        /// Method for creating transaction account
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>

     private TransactionAccount CreateTransactionAccount() {

         decimal amount;

         if (txtLimit.Text == "")
         {
             throw new FormatException("You have to enter account limit in order to procced");
         }
         else if (!Decimal.TryParse(txtLimit.Text.ToString(), out amount))
         {
             throw new FormatException("Please enter valid decimal number for the limit");
         }
         else
         {

             if (txtCurrency.Text == "")
             {
                 throw new FormatException("You have to enter account currency in order to procced");
             }

             else
             {
                 CurrencyAmount limit = new CurrencyAmount(amount, txtCurrency.Text.ToString());
                 TransactionAccount transactionAccount = new TransactionAccount(limit.Amount, limit.Currency);
                 transactionAccount.OnBalanceChanged += BalanceChangedDelegate;
                 return transactionAccount;
             }
         }
            //limit.Amount = amount;
            //limit.Currency = txtCurrency.Text.ToString();
           


        }
        /// <summary>
        /// this method call the CreateTransactionAccount and also handels wit exceptions
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCreateTransactionAccount_Click(object sender, EventArgs e)
        {
            TransactionAccount transactionAccount = null;
            try
            {
                
                try
                {

                    transactionAccount = CreateTransactionAccount();

                }
                catch (FormatException formatException)
                {
                    _errorOccured = true;
                    _errorMsg = formatException.Message;
                    throw new UserInterfaceException(formatException);
                }

                
            }
            catch (UserInterfaceException UserInterfaceException)
            {
                
                exceptionLogger.InnerException = UserInterfaceException.InnerException;
                //Console.WriteLine(exceptionLogger.InnerException.Message);
            }
            finally 
            {
                
                    if (_errorOccured)
                    {
                        System.Windows.Forms.MessageBox.Show(_errorMsg);
                        

                    }
                    else
                    {

                        DisplayTransactionAccount(transactionAccount);
                        CheckAccount(transactionAccount);
                        
                    }

                
                
            }

}
        /// <summary>
        /// metthods that check what is the type of the account 
        /// and clear the labels that are not connected 
        /// to that type of account
        /// </summary>
        /// <param name="account"></param>

        private void CheckAccount(Account account) {

            if (account.GetType() != typeof(TransactionAccount))
            {
                lblLimitAmount.Text = " ";
                lblLimitCurrency.Text = " ";
            }
            else if (account.GetType() != typeof(DepositAccount)) {
                lblPeriodPeriod.Text = "";
                lblPeriodUnit.Text = "";
                lblInterestPercent.Text = "";
                lblInterestUnit.Text = "";
                lblStartDate.Text = "";
                lblEndDate.Text = "";

            }
        }

        /// <summary>
        /// method that displays the details about Transaction Account
        /// </summary>
        /// <param name="account"></param>
           private void DisplayTransactionAccount(Account account) 
         {
            TransactionAccount trnasactionAccout = (TransactionAccount)account;
            lblId.Text = account.ID.ToString();
            lblNumber.Text = account.Number;
            lblCurrency.Text = account.Currency;
            lblLimitAmount.Text = trnasactionAccout.Limit.Amount.ToString();
            lblLimitCurrency.Text = trnasactionAccout.Limit.Currency.ToString();
            lblBalanceAmount.Text = account.Ballance.Amount.ToString();
            lblBalanceCurrency.Text = account.Ballance.Currency.ToString();
        }

        /// <summary>
        /// method that create deposit account and throws exception about 
        /// the values that user has entered
        /// </summary>
        /// <returns></returns>
           private DepositAccount CreateDepositAccount() {

               TimePeriod p = new TimePeriod();
               if (!int.TryParse(txtPeriodPeriod.Text, out p.Period))
                   throw new FormatException("Enter valid number for Period for deposit account");
               else
               {
                   string unit = cmbPeriodUnit.Text;
                   if (unit == "Day")
                       p.Unit = UnitOfTime.Day;
                   if (unit == "Month")
                       p.Unit = UnitOfTime.Month;
                   if (unit == "Year")
                       p.Unit = UnitOfTime.Year;

                   InterestRate iR = new InterestRate();

                   if (!decimal.TryParse(txtInterestPercent.Text, out iR.Precent))
                       throw new FormatException("Enter valid number for Interest Percent for deposit account");
                   else
                   {
                       string interestUnit = cmbInterestUnit.Text;
                       if (unit == "Day")
                           iR.Unit = UnitOfTime.Day;
                       if (unit == "Month")
                           iR.Unit = UnitOfTime.Month;
                       if (unit == "Year")
                           iR.Unit = UnitOfTime.Year;

                       DateTime startDate = dtpStartDate.Value;
                       DateTime endDate = dtpEndDate.Value;

                       TransactionAccount transationAccount = CreateTransactionAccount();

                       DepositAccount depositAccount = new DepositAccount(transationAccount.Currency, p, iR, startDate, endDate, transationAccount);
                       depositAccount.OnBalanceChanged += BalanceChangedDelegate;
                       return depositAccount;

                   }
               }
           }

        /// <summary>
        /// method that call CreateDepositAccount() and handes with the exceptions
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        /// 
           private void btnCreateDepositAccount_Click(object sender, EventArgs e)
           {
               DepositAccount depositAccount = null ;
               try
               {
                   try
                   {
                       depositAccount = CreateDepositAccount();
                   }
                   catch (FormatException formatException)
                   {
                       _errorOccured = true;
                       _errorMsg = formatException.Message;
                       throw new UserInterfaceException(formatException);
                   }


               }
               catch (UserInterfaceException UserInterfaceException)
               {

                   exceptionLogger.InnerException = UserInterfaceException.InnerException;
                   //Console.WriteLine(exceptionLogger.InnerException.Message);
               }
               finally
               {

                   if (_errorOccured)
                   {
                       System.Windows.Forms.MessageBox.Show(_errorMsg);


                   }
                   else
                   {

                       DisplayDepositAccount(depositAccount);
                       CheckAccount(depositAccount);

                   }



               }
           }

          
        /// <summary>
        /// method that diplays details about Depoist account
        /// </summary>
        /// <param name="a"></param>
        private void DisplayDepositAccount(Account a) {

            DepositAccount depositAccount = (DepositAccount)a;
            lblPeriodPeriod.Text = depositAccount.m_Period.Period.ToString();
            lblPeriodUnit.Text = depositAccount.m_Period.Unit.ToString();
            lblInterestPercent.Text = depositAccount.m_Interest.Precent.ToString();
            lblInterestUnit.Text = depositAccount.m_Interest.Unit.ToString();
            lblStartDate.Text = depositAccount.StartDate.ToString();
            lblEndDate.Text = depositAccount.EndDate.ToString();
            lblBalanceAmount.Text = a.Ballance.Amount.ToString();
            lblBalanceCurrency.Text = a.Ballance.Currency;
            lblId.Text = a.ID.ToString();
            lblLimitAmount.Text = a.Ballance.Amount.ToString();
            lblLimitCurrency.Text = a.Ballance.Currency;
            lblNumber.Text = a.Number;
            lblCurrency.Text = a.Ballance.Currency;


        }

        /// <summary>
        /// method that create Loan account and hrows exceptions
        /// </summary>
        /// <returns></returns>
        private LoanAccount CreateLoanAccount()
        {
            TimePeriod p = new TimePeriod();
            if (!int.TryParse(txtPeriodPeriod.Text, out p.Period))
                throw new FormatException("Enter valid number for loan account");
            else
            {
                string unit = cmbPeriodUnit.Text;
                if (unit == "Day")
                    p.Unit = UnitOfTime.Day;
                if (unit == "Month")
                    p.Unit = UnitOfTime.Month;
                if (unit == "Year")
                    p.Unit = UnitOfTime.Year;

                InterestRate iR = new InterestRate();

                if (!decimal.TryParse(txtInterestPercent.Text, out iR.Precent))
                    throw new FormatException("Enter valid number for loan account");
                else
                {
                    string interestUnit = cmbInterestUnit.Text;
                    if (unit == "Day")
                        iR.Unit = UnitOfTime.Day;
                    if (unit == "Month")
                        iR.Unit = UnitOfTime.Month;
                    if (unit == "Year")
                        iR.Unit = UnitOfTime.Year;

                    DateTime startDate = dtpStartDate.Value;
                    DateTime endDate = dtpEndDate.Value;



                    TransactionAccount transationAccount = CreateTransactionAccount();
                    LoanAccount loanAccount = new LoanAccount(transationAccount.Currency, p, iR, startDate, endDate, transationAccount);
                    loanAccount.OnBalanceChanged += BalanceChangedDelegate;
                    return loanAccount;
                }
            }
        }
        /// <summary>
        /// method that displays details about the depoist account
        /// after transaction
        /// </summary>
        /// <param name="a"></param>
        private void DisplayDepositAccountTo(Account a)
        {

            DepositAccount depositAccount = (DepositAccount)a;
            lblPeriodPeiod_To.Text = depositAccount.m_Period.Period.ToString();
            lblPeriodUnit_To.Text = depositAccount.m_Period.Unit.ToString();
            lablblInteresetPercent_To.Text = depositAccount.m_Interest.Precent.ToString();
            lblInterestUnit_To.Text = depositAccount.m_Interest.Unit.ToString();
            lblStartDate_To.Text = depositAccount.StartDate.ToString();
            lblEndDate_To.Text = depositAccount.EndDate.ToString();
            lblBalanceAmount_To.Text = a.Ballance.Amount.ToString();
            lblBalanceCurrency_To.Text = a.Ballance.Currency;
            lblId_To.Text = a.ID.ToString();
            lblLimitAmount_To.Text = a.Ballance.Amount.ToString();
            lblLimitCurrency_To.Text = a.Ballance.Currency;
            lblNumber_To.Text = a.Number;
            lblCurrency_To.Text = a.Ballance.Currency;


        }


        /// <summary>
        /// method that does the transaction
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnMakeTrasaction_Click(object sender, EventArgs e)
        {

            IDeposiAccount depositAccount = null;
            ILoanAccount loanAccount = null;
            try
            {
                try
                {
                    depositAccount = CreateDepositAccount();
                    loanAccount=CreateLoanAccount(); 
                }
                catch (FormatException formatException)
                {
                    _errorOccured = true;
                    _errorMsg = formatException.Message;
                    throw new UserInterfaceException(formatException);
                }


            }
            catch (UserInterfaceException UserInterfaceException)
            {

                exceptionLogger.InnerException = UserInterfaceException.InnerException;
                //Console.WriteLine(exceptionLogger.InnerException.Message);
            }
            finally
            {

                if (_errorOccured)
                {
                    System.Windows.Forms.MessageBox.Show(_errorMsg);


                }
                else
                {

                    DisplayDepositAccount((DepositAccount)depositAccount);
                    CheckAccount((DepositAccount)depositAccount);

                }



            }

           

            


            

            CurrencyAmount currencyAmount = new CurrencyAmount(200000, "MKD");
            

            IAccount[] accounts = new IAccount[2];
            accounts[0] = depositAccount;
            accounts[1] = loanAccount;
            try
            {
                processor.ProcessGroupTransaction(TransactionType.Debit, currencyAmount, accounts);
            }
            catch (CurrencyMismatchException exception)
            {
                _errorOccured = true;
                _errorMsg = exception.Message;

            }
            catch (LimitReachedException exception)
            {
                _errorOccured = true;
                _errorMsg = String.Format("An exception with code "+exception.ErrorCode+" happend, please read the message for more details. Message: "+ exception.Message);
                
            }
            catch (ApplicationException exception)
            {
                throw exception;
            }
            finally
            {
                if (_errorOccured)
                    System.Windows.Forms.MessageBox.Show(_errorMsg);
                else
                    DisplayLastTransactionDetail();

            }

           
        }

        /// <summary>
        /// method that does group transaction,creating accounts using flags, handeling with more that one exception
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnMakeGroupTransaction_Click(object sender, EventArgs e)
        {

            ITransactionAccount transactionAccount = CreateTransactionAccount();
            CreateAccountType accountTypeToCreate = CreateAccountType.TransactionAccount;
            CreateAccountType accountsTypeToCreate = CreateAccountType.DepositAccount | CreateAccountType.LoanAccount;
            Dictionary<CreateAccountType, List<IAccount>> result = new Dictionary<CreateAccountType, List<IAccount>>();
            Dictionary<CreateAccountType, List<IAccount>> resultDepositLoan = new Dictionary<CreateAccountType, List<IAccount>>();

            result = CreateAccounts(accountTypeToCreate, transactionAccount);
            if (result[accountTypeToCreate] != null)
            {
                ITransactionAccount resultTransaction = (ITransactionAccount)result[accountTypeToCreate].ElementAt(0);
            }

            resultDepositLoan = CreateAccounts(accountsTypeToCreate, transactionAccount);
            if (resultDepositLoan[accountsTypeToCreate] != null)
            {
                IDeposiAccount depositAccount = (IDeposiAccount)resultDepositLoan[accountsTypeToCreate].ElementAt(0);


                ILoanAccount loanAccount = (ILoanAccount)resultDepositLoan[accountsTypeToCreate].ElementAt(1);



                //IDeposiAccount depositAccount = CreateDepositAccount();


                //ILoanAccount loanAccount = CreateLoanAccount();

                 

                CurrencyAmount currencyAmount = new CurrencyAmount(20, "MKD");
                //currencyAmount.Amount = 20;
                //currencyAmount.Currency = "MKD";

                IAccount[] accounts = new IAccount[2];
                accounts[0] = depositAccount;
                accounts[1] = loanAccount;
                try
                {
                    processor.ProcessGroupTransaction(TransactionType.Debit, currencyAmount, accounts);
                }
                catch (CurrencyMismatchException exception)
                {
                    _errorOccured = true;
                    _errorMsg = exception.Message;

                }
                catch (ApplicationException exception) 
                {
                    throw exception;
                }
                finally 
                {
                    if(_errorOccured)
                        System.Windows.Forms.MessageBox.Show(_errorMsg); 
                    else
                        DisplayLastTransactionDetail();

                }
                //DisplayDepositAccountTo((DepositAccount)accounts[0]);
                //DisplayDepositAccount((LoanAccount)accounts[1]);
            }
        }

        /// <summary>
        /// displays the last transaction
        /// </summary>
        private void DisplayLastTransactionDetail()
        {
            TransactionProcessor processor = TransactionProcessor.GetTransactionProcessor();

            TransactionLogEntry log = processor.LastTransaction;

            DisplayDepositAccount((Account)log.Accounts.ElementAt(0));
            DisplayDepositAccountTo((Account)log.Accounts.ElementAt(1));

            lblTransactionLogCount.Text ="There are " +processor.TransactionCount.ToString()+" transaction by now";
            lbltransactionLogDetails.Text = "The last transaction was in " + log.CurrencyAmount.Currency + " the amount was "+log.CurrencyAmount.Amount+" the status of the"+log.TransactionType +" transaction is "+log.Status;

        }

        /// <summary>
        /// method that has same struct as the delegate
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="arg"></param>
        private void PrintDelegateMessage(Object sender, BalanceChangedEventArguments arg)
        {
            Console.WriteLine("Details:");
            Console.WriteLine("Account Number: " + arg.Account.Number);
            Console.WriteLine(" Cuurent ballance amount: " + arg.Account.Ballance.Amount);
            Console.WriteLine(" Current ballance currency: " + arg.Account.Ballance.Currency);
            Console.ReadLine();

        
        }

        /// <summary>
        /// creates accounts depending on flags
        /// </summary>
        /// <param name="accountsTypeToCreate"></param>
        /// <param name="transactionAccount"></param>
        /// <returns></returns>
        private Dictionary<CreateAccountType,List<IAccount>> CreateAccounts(CreateAccountType accountsTypeToCreate, ITransactionAccount transactionAccount) 
        {
            List<IAccount> accounts = new List<IAccount>();
            
           if(accountsTypeToCreate==(accountsTypeToCreate & (CreateAccountType.TransactionAccount | CreateAccountType.DepositAccount)))
           {
               IDeposiAccount depositAccount = null;
               ITransactionAccount transAccount = null;
               try
               {
                   try
                   {
                       depositAccount = CreateDepositAccount();
                       transAccount = CreateTransactionAccount();
                   }
                   catch (FormatException formatException)
                   {
                       _errorOccured = true;
                       _errorMsg = formatException.Message;
                       throw new UserInterfaceException(formatException);
                   }


               }
               catch (UserInterfaceException UserInterfaceException)
               {

                   exceptionLogger.InnerException = UserInterfaceException.InnerException;
                   //Console.WriteLine(exceptionLogger.InnerException.Message);
               }
               finally
               {

                   if (_errorOccured)
                   {
                       System.Windows.Forms.MessageBox.Show(_errorMsg);


                   }
                   



               }

           
               accounts.Add(transAccount);
               accounts.Add(depositAccount);
           }
           if (accountsTypeToCreate == (accountsTypeToCreate & (CreateAccountType.TransactionAccount | CreateAccountType.LoanAccount)))
           {
               ITransactionAccount transAccount = null;
               ILoanAccount loanAccount = null;
               try
               {
                   try
                   {
                       transAccount = CreateTransactionAccount();
                       loanAccount = CreateLoanAccount();
                   }
                   catch (FormatException formatException)
                   {
                       _errorOccured = true;
                       _errorMsg = formatException.Message;
                       throw new UserInterfaceException(formatException);
                   }


               }
               catch (UserInterfaceException UserInterfaceException)
               {

                   exceptionLogger.InnerException = UserInterfaceException.InnerException;
                   //Console.WriteLine(exceptionLogger.InnerException.Message);
               }
               finally
               {

                   if (_errorOccured)
                   {
                       System.Windows.Forms.MessageBox.Show(_errorMsg);


                   }
                   



               }

           
               accounts.Add(transAccount);
               accounts.Add(loanAccount);
           }
           if (accountsTypeToCreate == (accountsTypeToCreate & (CreateAccountType.DepositAccount | CreateAccountType.LoanAccount)))
           {

               IDeposiAccount depAccount = null;
               ILoanAccount loanAccount = null;
               try
               {
                   try
                   {
                       depAccount = CreateDepositAccount();
                       loanAccount = CreateLoanAccount();
                   }
                   catch (FormatException formatException)
                   {
                       _errorOccured = true;
                       _errorMsg = formatException.Message;
                       throw new UserInterfaceException(formatException);
                   }


               }
               catch (UserInterfaceException UserInterfaceException)
               {

                   exceptionLogger.InnerException = UserInterfaceException.InnerException;
                   //Console.WriteLine(exceptionLogger.InnerException.Message);
               }
               finally
               {

                   if (_errorOccured)
                   {
                       System.Windows.Forms.MessageBox.Show(_errorMsg);


                   }
                  



               }
               accounts.Add(depAccount);
               accounts.Add(loanAccount);
           }
           if (accountsTypeToCreate == (accountsTypeToCreate & (CreateAccountType.TransactionAccount)))
           {

               ITransactionAccount transAccount = null;
              
               try
               {
                   try
                   {
                       transAccount = CreateTransactionAccount();
                       
                   }
                   catch (FormatException formatException)
                   {
                       _errorOccured = true;
                       _errorMsg = formatException.Message;
                       throw new UserInterfaceException(formatException);
                   }


               }
               catch (UserInterfaceException UserInterfaceException)
               {

                   exceptionLogger.InnerException = UserInterfaceException.InnerException;
                   //Console.WriteLine(exceptionLogger.InnerException.Message);
               }
               finally
               {

                   if (_errorOccured)
                   {
                       System.Windows.Forms.MessageBox.Show(_errorMsg);


                   }
                  



               }
               accounts.Add(transAccount);
               
           }
           if (accountsTypeToCreate == (accountsTypeToCreate & (CreateAccountType.DepositAccount)))
           {

               IDeposiAccount depAccount = null;
              
               try
               {
                   try
                   {
                       
                       depAccount = CreateDepositAccount();
                   }
                   catch (FormatException formatException)
                   {
                       _errorOccured = true;
                       _errorMsg = formatException.Message;
                       throw new UserInterfaceException(formatException);
                   }


               }
               catch (UserInterfaceException UserInterfaceException)
               {

                   exceptionLogger.InnerException = UserInterfaceException.InnerException;
                   //Console.WriteLine(exceptionLogger.InnerException.Message);
               }
               finally
               {

                   if (_errorOccured)
                   {
                       System.Windows.Forms.MessageBox.Show(_errorMsg);


                   }
                  



               }
               accounts.Add(depAccount);
           }
           if (accountsTypeToCreate == (accountsTypeToCreate & (CreateAccountType.LoanAccount)))
           {


              
               ILoanAccount loanAccount = null;
               try
               {
                   try
                   {
                       
                       loanAccount = CreateLoanAccount();
                   }
                   catch (FormatException formatException)
                   {
                       _errorOccured = true;
                       _errorMsg = formatException.Message;
                       throw new UserInterfaceException(formatException);
                   }


               }
               catch (UserInterfaceException UserInterfaceException)
               {

                   exceptionLogger.InnerException = UserInterfaceException.InnerException;
                   //Console.WriteLine(exceptionLogger.InnerException.Message);
               }
               finally
               {

                   if (_errorOccured)
                   {
                       System.Windows.Forms.MessageBox.Show(_errorMsg);


                   }
                  



               }
               accounts.Add(loanAccount);
           }
           if (accountsTypeToCreate == (accountsTypeToCreate & (CreateAccountType.TransactionAccount | CreateAccountType.LoanAccount | CreateAccountType.DepositAccount)))
           {

               ITransactionAccount transAccount = null;
               ILoanAccount loanAccount = null;
               IDeposiAccount depAccount = null;
               try
               {
                   try
                   {
                       transAccount = CreateTransactionAccount();
                       depAccount = CreateDepositAccount();
                       loanAccount = CreateLoanAccount();
                   }
                   catch (FormatException formatException)
                   {
                       _errorOccured = true;
                       _errorMsg = formatException.Message;
                       throw new UserInterfaceException(formatException);
                   }


               }
               catch (UserInterfaceException UserInterfaceException)
               {

                   exceptionLogger.InnerException = UserInterfaceException.InnerException;
                   //Console.WriteLine(exceptionLogger.InnerException.Message);
               }
               finally
               {

                   if (_errorOccured)
                   {
                       System.Windows.Forms.MessageBox.Show(_errorMsg);


                   }
                  


               }
               accounts.Add(transAccount);
               accounts.Add(depAccount);
               accounts.Add(loanAccount);
           }
           Dictionary<CreateAccountType, List<IAccount>> result = new Dictionary<CreateAccountType, List<IAccount>>();
            result[accountsTypeToCreate]=accounts;
            return result;
            
        }
        /// <summary>
        /// method for charging fee on already done transaction
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnChargeFee_Click(object sender, EventArgs e)
        {
            CurrencyAmount fee=new CurrencyAmount(15,"MKD");
            TransactionLogEntry lastTransaction= processor.LastTransaction;
            IEnumerable<IAccount> accounts=lastTransaction.Accounts;
            processor.ChargeProcessingFee(fee, accounts);
            DisplayLastTransactionDetail();
        }
    }
}
