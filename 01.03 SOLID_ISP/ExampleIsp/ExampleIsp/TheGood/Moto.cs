using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExampleIsp.TheGood
{
  public  class Moto :BaseFactory, IMotoFactory
    {
        public int ProduceFrame()
        {
            throw new NotImplementedException();
        }

        public int ProduceHandles()
        {
            throw new NotImplementedException();
        }

        public int ProduceTankMoto()
        {
            throw new NotImplementedException();
        }

        public int ProduceEngineMoto()
        {
            throw new NotImplementedException();
        }

        public int ProduceGearsMoto()
        {
            throw new NotImplementedException();
        }
        public int Paint(int paintColour)
        {
            throw new NotImplementedException();
        }
        public int PaintMoto(int paintColour)
        {
            throw new NotImplementedException();
        }
    }
}
