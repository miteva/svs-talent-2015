using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExampleSrp.TheGood
{
    public class Logger : ILogger
    {
         private static Logger sLogger;

        static Logger()
        {
            sLogger = new Logger();
        }

        public static Logger GetLogger()
        {

            return sLogger ;
        }


        public void Log(string state)
        {
            ClientLogger.ComputerLogChangeState(state);
        }


        public ILogger CreateLogger(int device)
        {


            if (device == (int)Device.Computer)
            {
                IComputerLogger computerLoger = ComputerLogger.GetComputerLogger();
                return computerLoger;

            }
            else if (device == (int)Device.Tablet)
            {
                ITabletLogger tabletLoger = TabletLogger.GetTabletLogger();
                return tabletLoger;

            }
            else if (device == (int)Device.Phone)
            {
                IPhoneLogger phoneLoger = PhoneLoger.GetPhoneLogger();
                return phoneLoger;

            }

            else
            {
                ExceptionLogger exceptionLogger = ExceptionLogger.GetExceptionLogger();
                exceptionLogger.logException("no such device");
                return null;
            }
        }
    }

    public enum Device 
    {
        Computer,
        Tablet,
        Phone
    }
}
