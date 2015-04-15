using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExampleIsp.TheGood
{
  public  class Formula : BaseFactory, IFormulaFactory
    {
        

        public int ProduceTank()
        {
            throw new NotImplementedException();
        }
        public int Paint(int paintColour)
        {
            throw new NotImplementedException();
        }

    }
}
