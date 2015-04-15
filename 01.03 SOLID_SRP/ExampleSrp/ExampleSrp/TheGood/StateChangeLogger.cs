using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExampleSrp.TheGood
{
   public class StateChangeLogger : IStateChangeLogger
    {
        

        private static StateChangeLogger sDevice;

        static StateChangeLogger()
        {
            sDevice = new StateChangeLogger();
        }

        public static StateChangeLogger GetDevice()
        {

            return sDevice;
        }
        public ILogger CreateLogger(int device)
        {


            if (device == 1)
            {
                IComputerLogger computerLoger = ComputerLogger.GetComputerLogger();
                
            }
            if (device == 2)
            {
                ITabletLogger tabletLoger = TabletLogger.GetTabletLogger();
               
            }
            if (device == 3)
            {
                IPhoneLogger phoneLoger = PhoneLoger.GetPhoneLogger();
                
            }

            else {
                ExceptionLogger exceptionLogger = ExceptionLogger.GetExceptionLogger();
                exceptionLogger.logException("no such device");
            }
        }
    }
}
