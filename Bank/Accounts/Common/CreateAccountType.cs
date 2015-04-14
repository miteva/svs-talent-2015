﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Accounts.Common
{
    [Flags]
    public enum CreateAccountType
    {
        None=0,
        TransactionAccount=1,
        DepositAccount=2,
        LoanAccount=4
    }
}
