using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Accounts.Common
{
    public class LimitReachedException:ApplicationException
    {
        public int ErrorCode { set; get; }

        public LimitReachedException(int errorCode,string diff) : base(diff)
         {
             this.ErrorCode = errorCode;
         }
    }
}
