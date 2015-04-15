using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExampleIsp.TheGood
{
    public class Bike :BaseFactory, IBikeFactory
    {
       
        public int ProduceFrameBike()
        {
            throw new NotImplementedException();
        }

        public int ProduceHandlesBike()
        {
            throw new NotImplementedException();
        }

        public int ProduceGearsBike()
        {
            throw new NotImplementedException();
        }

        public int Paint(int paintColour)
        {
            throw new NotImplementedException();
        }
        public int PaintBike(int paintColour)
        {
            throw new NotImplementedException();
        }
    }
}
