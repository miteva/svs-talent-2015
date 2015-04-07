using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace BankService
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select Service1.svc or Service1.svc.cs at the Solution Explorer and start debugging.
    public class AccountService : IAccountService
    {

        /// <summary>
        /// Depending on the currency and the transfer, money are added or deducted from the account
        /// </summary>
        /// <param name="account"></param>
        /// <param name="amount"></param>
        /// <param name="currency"></param>
        /// <param name="transfer"></param>
        /// <returns></returns>
        public Account ProccesTransfer(Account account, decimal amount, string currency, string transfer)
        {
            if (account == null)
            {
                throw new ArgumentNullException("account");
            }
            if (currency == account.Currency && transfer == "Credit")
            {
                account.Ballance += amount;
                account.Note = String.Format("{0} has been added to your account", amount);
                return account;
            }
            else if (currency == account.Currency && transfer == "Debit" && account.Ballance>=amount)
            {
                account.Ballance -= amount;
                account.Note = String.Format("{0} has been deducted from your account", amount);
                return account;
            }
            else
            {
                account.Note = "Something went wrong no transfer is proccesed";
                return account;
            }
        }

        /// <summary>
        /// Method that return account with how much money do we have if the primary currency is changed to another
        /// </summary>
        /// <param name="account"></param>
        /// <param name="currency"></param>
        /// <returns></returns>
        public Account Convert(Account account, string currency)
        {

            if (account.Currency == "MKD")
            {

                if (currency == "EU")
                {
                    account.Currency = "EU";
                    account.Ballance /= 61;
                    account.Note = String.Format("You have {0:0.00} EU on your account", account.Ballance);
                }
                else
                    if (currency == "USD")
                    {

                        account.Currency = "USD";
                        account.Ballance /= 45;
                        account.Note = String.Format("You have {0:0.00} USD on your account", account.Ballance);

                    }
                return account;
            }
            else if (account.Currency == "USD")
            {
                if (currency == "EU")
                {
                    account.Currency = "EU";
                    account.Ballance /= 1;
                    account.Note = String.Format("You have {0:0.00} EU on your account", account.Ballance);
                }
                else
                    if (currency == "MKD")
                    {

                        account.Currency = "MKD";
                        account.Ballance *= 45;
                        account.Note = String.Format("You have {0:0.00} MKD on your account", account.Ballance);

                    }
                return account;
            }
            else if (account.Currency == "EU")
            {
                if (currency == "MKD")
                {
                    account.Currency = "MKD";
                    account.Ballance *= 61;
                    account.Note = String.Format("You have {0:0.00} MKD on your account", account.Ballance);
                }
                else
                    if (currency == "USD")
                    {

                        account.Currency = "USD";
                        account.Ballance *= 1;
                        account.Note = String.Format("You have {0:0.00} USD on your account", account.Ballance);

                    }
                return account;
            }
            else return account;
                }

            }
        }
                
        