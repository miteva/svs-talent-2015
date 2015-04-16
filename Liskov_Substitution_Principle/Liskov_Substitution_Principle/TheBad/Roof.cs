using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Liskov_Substitution_Principle.TheBad
{
    /// <summary>
    /// Class that inherits form PartsOfCar, here the method OpenRoof will throw an exception
    /// </summary>
   public class Roof : PartsOfCar
    {
        /// <summary>
        /// call to the base method t.e call to OpenRoof from PartsOfCar
        /// </summary>
       public override void OpenRoof()
       {
           throw new Exception("This roof can not be open");
       }

       /// <summary>
       /// call to the base method t.e call to NotifyThatPartIsProduced from PartsOfCar
       /// </summary>
       public override void NotifyThatPartIsProduced()
       {
           base.NotifyThatPartIsProduced();
       }

    }
}
