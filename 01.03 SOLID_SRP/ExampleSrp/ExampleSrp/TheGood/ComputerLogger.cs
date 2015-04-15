using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExampleSrp.TheGood
{
  public  class ComputerLogger : IComputerLogger
    {
        private static ComputerLogger sComputerLogger;
        static ComputerLogger()
        {
            sComputerLogger = new ComputerLogger();
           

        }

        public static ComputerLogger GetComputerLogger()
        {

            return sComputerLogger;
        }



        public void ComputerLog(string state)
        {
            ClientLogger.ComputerLogChangeState(state);
        }
       
    }
}
