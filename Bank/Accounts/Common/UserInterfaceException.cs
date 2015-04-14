using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Accounts.Common
{
    public class UserInterfaceException:ApplicationException
    {
        Exception Exception { set; get; }

        public UserInterfaceException(Exception ex)
        {
            this.Exception = ex;

        }
    }
}
