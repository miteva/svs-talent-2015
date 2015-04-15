using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExampleIsp.TheGood
{
   public abstract class BaseFactory
    {
        public int Shift { get; private set; }

        public int StartShift()
        {
            this.Shift = Shift + 1;
            if (this.Shift > 3)
            {
                this.Shift = 3;
                throw new Exception("Maximum 3 shifts can be started!");
            }
            Console.WriteLine("Shift started!");
            return this.Shift;
        }

        public int CloseShift()
        {
            this.Shift = Shift - 1;
            if (this.Shift < 0)
            {
                this.Shift = 0;
                throw new Exception("Atleast one shift needs to be started in order to close it!");
            }

            Console.WriteLine("Shift closed!");
            return this.Shift;
        }

        public int StartProductionLane()
        {
            throw new NotImplementedException();
        }

        public int StopProductionLane()
        {
            throw new NotImplementedException();
        }

        public int ProduceBody()
        {
            throw new NotImplementedException();
        }

        public int ProduceEngine()
        {
            throw new NotImplementedException();
        }

        public int ProduceGears()
        {
            throw new NotImplementedException();
        }

        public int ProduceHeadLamps()
        {
            throw new NotImplementedException();
        }

        public int ProduceElectronics()
        {
            throw new NotImplementedException();
        }
    }
}
