using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExampleSrp.TheGood
{
    class Logger : ILogger
    {
        public IComputerLogger createComputerLogger()
        {
            ComputerLogger computerLogger = ComputerLogger.GetComputerLogger();
            return computerLogger;
        }

        public IPhoneLogger createPhoneLogger()
        {
            PhoneLoger phoneLogger = PhoneLoger.GetPhoneLogger();
            return phoneLogger;
        }

        public ITabletLogger createTabletLogger()
        {
            TabletLogger tabletLogger = TabletLogger.GetTabletLogger();
            return tabletLogger;
        }
    }
}
