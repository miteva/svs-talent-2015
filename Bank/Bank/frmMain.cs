using Accounts;
using Accounts.Accounts;
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

             
        }

        private void DisplayAccount(Account account) {


        }
    }
}
