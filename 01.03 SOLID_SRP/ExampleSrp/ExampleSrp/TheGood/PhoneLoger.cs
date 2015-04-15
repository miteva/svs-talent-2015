using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExampleSrp.TheGood
{
   public class PhoneLoger :IPhoneLogger
    {
        private static PhoneLoger sPhoneLogger;

        static PhoneLoger()
        {
            sPhoneLogger = new PhoneLoger();
        }

        public static PhoneLoger GetPhoneLogger()
        {

            return sPhoneLogger;
        }
        public void PhoneLog(string state)
        {
            ClientLogger.ComputerLogChangeState(state);
        }
    }
}
