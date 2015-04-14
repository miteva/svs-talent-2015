using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Accounts.Common
{
   public class CurrencyMismatchException : ApplicationException
    {
       public CurrencyMismatchException(string diff) : base(diff) { }
    }
}
