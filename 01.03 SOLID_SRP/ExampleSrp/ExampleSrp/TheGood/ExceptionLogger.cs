using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExampleSrp.TheGood
{
  public  class ExceptionLogger :IExceptionLogger
    {
        private static ExceptionLogger sExceptionLogger;

        static ExceptionLogger()
        {
            sExceptionLogger = new ExceptionLogger();
        }

        public static ExceptionLogger GetExceptionLogger()
        {

            return sExceptionLogger;
        }
        public  void logException(string stateChangeInfo)
        {
            Console.WriteLine( stateChangeInfo);
        }
    }
}
