using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Accounts.Accounts
{
    public class LoanAccount : DepositAccount
    {


        public override TransactionStatus DebitAmount(CurrencyAmount amount)
        {

            return base.CreditAmount(amount);
        }

        public override TransactionStatus CreditAmount(CurrencyAmount amount)
        {

            return base.DebitAmount(amount);
        }

    }
}
