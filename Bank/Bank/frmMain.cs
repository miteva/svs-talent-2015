using Accounts;
using Accounts.Accounts;
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
            
        }

        private void btnCreateTransactionAccount_Click(object sender, EventArgs e)
        {
            CurrencyAmount limit = new CurrencyAmount();
            decimal amount;
            Decimal.TryParse(txtLimit.Text.ToString(), out amount);
            limit.Amount = amount;
            limit.Currency = txtCurrency.Text.ToString();
            TransactionAccount transactionAccount = new TransactionAccount(limit.Amount,limit.Currency);
           DisplayTransactionAccount(transactionAccount);
            CheckTranssactionAccount(transactionAccount);
             
        }

        private void CheckTranssactionAccount(Account account) {

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

        private void DisplayTransactionAccount(Account account) {
            lblId.Text = account.ID.ToString();
            lblNumber.Text = account.Number;
            lblCurrency.Text = account.Currency;
            lblLimitAmount.Text = account.m_Balance.Amount.ToString();
            lblLimitCurrency.Text = account.Currency;
            lblBalanceAmount.Text = account.m_Balance.Amount.ToString();
            lblBalanceCurrency.Text = account.m_Balance.Currency.ToString();



        }

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
            DisplayDepositAccount(depositAccount);
            CheckDepositAccount(depositAccount);


        }

        private void CheckDepositAccount(Account account)
        {

            if (account.GetType() != typeof(DepositAccount))
            {
                lblPeriodPeriod.Text = "";
                lblPeriodUnit.Text = "";
                lblInterestPercent.Text = "";
                lblInterestUnit.Text = "";
                lblStartDate.Text = "";
                lblEndDate.Text = "";
            }
            if (account.GetType() != typeof(TransactionAccount))
            {
                lblLimitAmount.Text = " ";
                lblLimitCurrency.Text = " ";
            }
        }


        private void DisplayDepositAccount(Account a) {

            DepositAccount depositAccount = (DepositAccount)a;
            lblPeriodPeriod.Text = depositAccount.m_Period.Period.ToString();
            lblPeriodUnit.Text = depositAccount.m_Period.Unit.ToString();
            lblInterestPercent.Text = depositAccount.m_Interest.Precent.ToString();
            lblInterestUnit.Text = depositAccount.m_Interest.Unit.ToString();
            lblStartDate.Text = depositAccount.StartDate.ToString();
            lblEndDate.Text = depositAccount.EndDate.ToString();


        }

        private void btnMakeTrasaction_Click(object sender, EventArgs e)
        {
            CurrencyAmount limit = new CurrencyAmount();
            decimal amount;
            Decimal.TryParse(txtLimit.Text.ToString(), out amount);
            limit.Amount = amount;
            limit.Currency = txtCurrency.Text.ToString();
            TransactionAccount transactionAccount = new TransactionAccount(limit.Amount, limit.Currency);

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
            processor.ProcessTransaction(transactionAccount,depositAccount,currencyAmount, TransactionType.Transfer);


            DisplayDepositAccount(depositAccount);
            DisplayTransactionAccount(transactionAccount);

        }
    }
}
