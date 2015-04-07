using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace AccountClient
{
    public partial class Manage : System.Web.UI.Page
    {
        AccountService.AccountServiceClient client;
        AccountService.Account account; 
        decimal decimalBallance;
        string ballance;
        string currency;
        string note;

        protected void Page_Load(object sender, EventArgs e)
        {
            client = new AccountService.AccountServiceClient();
            
                ballance = Request.QueryString["ballance"];
                decimal.TryParse(ballance, out decimalBallance);
                currency = Request.QueryString["currency"];
                note = Request.QueryString["note"];

                account = new AccountService.Account();
                account.Ballance = decimalBallance;
                account.Currency = currency;
                account.Note = note;

                lblBallance.Text = decimalBallance.ToString();
                lblCurrency.Text = currency;
                lblNote.Text = note;
            
        }

        /// <summary>
        /// Method that enables function for convert or transfer depending on what is sellected
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void btnSubmitAction_Click(object sender, EventArgs e)
        {
            if (ddlAction.Text == "Convert")
            {
                lblChooseCurrency.Visible = true;
                ddlConvert.Visible = true;
                btnSubmitConvert.Visible = true;
            }
            else 
            {
                lblAmountTransfer.Visible = true;
                lblCurrencyTransfer.Visible = true;
                lblActionTransfer.Visible = true;
                txtAmountTransfer.Visible = true;
                ddlCurrency.Visible = true;
                ddlTypeTransfer.Visible = true;
                btnSubmitTransfer.Visible = true;
            }
        }

        /// <summary>
        /// Method that does the converting using the services from the AccountService
        /// if we have made some privious action on the account
        /// it takes the new changes
        /// ex: if we convert our ballance and after that we want to convert again we can only convert
        /// in the currency that is not provided after the prvious converting
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>

        protected void Button1_Click(object sender, EventArgs e)
        {
            decimal ballanceAfterAction;
            if (lblAccountAfterAction.Text == "")
            {
                    account = new AccountService.Account();
                    decimal.TryParse(lblBallance.Text, out ballanceAfterAction);
                    account.Ballance = ballanceAfterAction;
                    account.Currency = lblCurrency.Text;
                    account.Note = lblNote.Text;
                
                
            }
            else 
            {
                account = new AccountService.Account();
                decimal.TryParse(lblBallanceAfterAction.Text, out ballanceAfterAction);
                account.Ballance = ballanceAfterAction;
                account.Currency = lblCurrencyAfterAction.Text;
                account.Note = lblNoteAfterAction.Text;

            }
            AccountService.Account newAccount = client.Convert(account, ddlConvert.Text);

            lblAccountAfterAction.Text = "This is the result from converting";
            lblAccountAfterAction.Visible = true;

            lblNote0.Visible = true;
            lblBallanceAfterAction.Text = newAccount.Ballance.ToString("#.##");
            lblBallanceAfterAction.Visible = true;

            lblNote1.Visible = true;
            lblCurrencyAfterAction.Text = newAccount.Currency;
            lblCurrencyAfterAction.Visible = true;

            lblNote2.Visible = true;
            lblNoteAfterAction.Text = newAccount.Note;
            lblNoteAfterAction.Visible = true;

        }
        /// <summary>
        /// Method that does the transfer using the services from AccountService
        /// it takes the new changes
        /// ex: if we convert our ballance and after that we want to transfer we can only transfer
        /// in the currency that is provided after the converting
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void btnSubmitTransfer_Click(object sender, EventArgs e)
        {
            decimal ballanceAfterAction;
            decimal decimalAmount;

            
            string currencyTransfer = ddlCurrency.Text;
            string typeTransfer = ddlTypeTransfer.Text;
            if (lblAccountAfterAction.Text == "")
            {
                account = new AccountService.Account();
                decimal.TryParse(lblBallance.Text, out ballanceAfterAction);
                account.Ballance = ballanceAfterAction;
                account.Currency = lblCurrency.Text;
                account.Note = lblNote.Text;
            }
            else
            {
                account = new AccountService.Account();
                decimal.TryParse(lblBallanceAfterAction.Text, out ballanceAfterAction);
                account.Ballance = ballanceAfterAction;
                account.Currency = lblCurrencyAfterAction.Text;
                account.Note = lblNoteAfterAction.Text;

            }

            if (decimal.TryParse(txtAmountTransfer.Text, out decimalAmount))
            {
                AccountService.Account newAccount = client.ProccesTransfer(account, decimalAmount, currencyTransfer, typeTransfer);

                lblAccountAfterAction.Text = String.Format("This is the result from the {0} transfer", typeTransfer);
                lblAccountAfterAction.Visible = true;

                lblNote0.Visible = true;
                lblBallanceAfterAction.Text = newAccount.Ballance.ToString("#.##");
                lblBallanceAfterAction.Visible = true;

                lblNote1.Visible = true;
                lblCurrencyAfterAction.Text = newAccount.Currency;
                lblCurrencyAfterAction.Visible = true;

                lblNote2.Visible = true;
                lblNoteAfterAction.Text = newAccount.Note;
                lblNoteAfterAction.Visible = true;
                lblErrorAmount.Text = "";
            }
            else 
            {
                lblErrorAmount.Text = "You must enter number for the amount";
            }
           
            


        }

        
    }
}