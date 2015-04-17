using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExampleSrp.TheGood
{
   public class TabletLogger :Logger, ITabletLogger
    {
        private static TabletLogger sTabletLogger;

        static TabletLogger()
        {
            sTabletLogger = new TabletLogger();
        }

        public static TabletLogger GetTabletLogger()
        {

            return sTabletLogger;
        }

        
    }
}
