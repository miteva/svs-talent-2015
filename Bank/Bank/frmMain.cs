using Accounts;
using Accounts.Accounts;
using Accounts.Helper;
using Accounts.Interfaces;
using Accounts.Processors;
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
            
        }
        /// <summary>
        /// Method for creating transaction account
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>

        private void btnCreateTransactionAccount_Click(object sender, EventArgs e)
        {
            CurrencyAmount limit = new CurrencyAmount();
            decimal amount;
            Decimal.TryParse(txtLimit.Text.ToString(), out amount);
            limit.Amount = amount;
            limit.Currency = txtCurrency.Text.ToString();
            TransactionAccount transactionAccount = new TransactionAccount(limit.Amount,limit.Currency);
            transactionAccount.m_Balance.Amount = limit.Amount;
            transactionAccount.m_Balance.Currency = limit.Currency;
            DisplayTransactionAccount(transactionAccount);
            CheckAccount(transactionAccount);
             
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
            lblBalanceAmount.Text = account.m_Balance.Amount.ToString();
            lblBalanceCurrency.Text = account.m_Balance.Currency.ToString();
        }
        /// <summary>
        /// method that create Deposit Account
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCreateDepositAccount_Click(object sender, EventArgs e)
        {
            TimePeriod p = new TimePeriod();
            int.TryParse(txtPeriodPeriod.Text, out p.Period);
            string unit = cmbPeriodUnit.Text;
            if (unit == "Day")
                p.Unit = UnitOfTime.Day;
            if (unit == "Month")
                p.Unit = UnitOfTime.Month;
            if (unit == "Year")
                p.Unit = UnitOfTime.Year;
            InterestRate iR = new InterestRate();
            decimal.TryParse(txtInterestPercent.Text, out iR.Precent);
            string interestUnit = cmbInterestUnit.Text;
            if (unit == "Day")
                iR.Unit = UnitOfTime.Day;
            if (unit == "Month")
                iR.Unit = UnitOfTime.Month;
            if (unit == "Year")
                iR.Unit = UnitOfTime.Year;
            DateTime startDate = dtpStartDate.Value;
            DateTime endDate = dtpEndDate.Value;
            CurrencyAmount limit = new CurrencyAmount();
            decimal amount;
            Decimal.TryParse(txtLimit.Text.ToString(), out amount);
            limit.Amount = amount;
            limit.Currency = txtCurrency.Text.ToString();
            TransactionAccount transactionAccount = new TransactionAccount(limit.Amount, limit.Currency);
            DepositAccount depositAccount = new DepositAccount(limit.Currency,p, iR, startDate, endDate, transactionAccount);
            depositAccount.m_Balance.Amount = transactionAccount.Limit.Amount;
            depositAccount.m_Balance.Currency = transactionAccount.Limit.Currency;
            DisplayDepositAccount(depositAccount);
            CheckAccount(depositAccount);


        }
        ///// <summary>
        ///// met
        ///// </summary>
        ///// <param name="account"></param>
        //private void CheckDepositAccount(Account account)
        //{

        //    if (account.GetType() != typeof(DepositAccount))
        //    {
        //        lblPeriodPeriod.Text = "";
        //        lblPeriodUnit.Text = "";
        //        lblInterestPercent.Text = "";
        //        lblInterestUnit.Text = "";
        //        lblStartDate.Text = "";
        //        lblEndDate.Text = "";
        //    }
        //    if (account.GetType() != typeof(TransactionAccount))
        //    {
        //        lblLimitAmount.Text = " ";
        //        lblLimitCurrency.Text = " ";
        //    }
        //}

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
            lblBalanceAmount_To.Text = a.m_Balance.Amount.ToString();
            lblBalanceCurrency_To.Text = a.m_Balance.Currency;
            lblId_To.Text = a.ID.ToString();
            lblLimitAmount_To.Text = a.m_Balance.Amount.ToString();
            lblLimitCurrency_To.Text = a.m_Balance.Currency;
            lblNumber_To.Text = a.Number;
            lblCurrency_To.Text = a.m_Balance.Currency;


        }


        /// <summary>
        /// method that does the transaction
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnMakeTrasaction_Click(object sender, EventArgs e)
        {
            CurrencyAmount limit = new CurrencyAmount();
            decimal amount;
            Decimal.TryParse(txtLimit.Text, out amount);
            limit.Amount = amount;
            limit.Currency = txtCurrency.Text.ToString();

            
            TransactionAccount transactionAccount = new TransactionAccount(limit.Amount, limit.Currency);
           

            transactionAccount.m_Balance.Amount = limit.Amount;
            transactionAccount.m_Balance.Currency = limit.Currency;
            TimePeriod p = new TimePeriod();
            int.TryParse(txtPeriodPeriod.Text, out p.Period);
            string unit = cmbPeriodUnit.Text;
            if (unit == "Day")
                p.Unit = UnitOfTime.Day;
            if (unit == "Month")
                p.Unit = UnitOfTime.Month;
            if (unit == "Year")
                p.Unit = UnitOfTime.Year;
            InterestRate iR = new InterestRate();
            decimal.TryParse(txtInterestPercent.Text, out iR.Precent);
            string interestUnit = cmbInterestUnit.Text;
            if (unit == "Day")
                iR.Unit = UnitOfTime.Day;
            if (unit == "Month")
                iR.Unit = UnitOfTime.Month;
            if (unit == "Year")
                iR.Unit = UnitOfTime.Year;
            DateTime startDate = dtpStartDate.Value;
            DateTime endDate = dtpEndDate.Value;
           
            DepositAccount depositAccount = new DepositAccount(limit.Currency, p, iR, startDate, endDate, transactionAccount);
           
            TransactionProcessor processor = new TransactionProcessor();

            CurrencyAmount currencyAmount = new CurrencyAmount();
            currencyAmount.Amount = 20000;
            currencyAmount.Currency = "MKD";
            List<Account> accounts=new List<Account>();
          //  accounts= processor.ProcessTransaction(transactionAccount, depositAccount, currencyAmount, TransactionType.Transfer);
            //TransactionAccount newTranssactionAccount = (TransactionAccount)accounts[0];

            //DepositAccount newDepositAccount =(DepositAccount) accounts[1];

            //DisplayDepositAccountTo(newDepositAccount);
            //DisplayTransactionAccount(newTranssactionAccount);

            LoanAccount loanAccount = new LoanAccount(limit.Currency, p, iR, startDate, endDate, transactionAccount);
            
            accounts = processor.ProcessTransaction(transactionAccount, loanAccount, currencyAmount, TransactionType.Transfer);
            TransactionAccount newTranssactionAccount = (TransactionAccount)accounts[0];
            LoanAccount newLoanAccount = (LoanAccount)accounts[1];
            DisplayDepositAccountTo(newLoanAccount);
            DisplayTransactionAccount(newTranssactionAccount);

        }
    }
}
