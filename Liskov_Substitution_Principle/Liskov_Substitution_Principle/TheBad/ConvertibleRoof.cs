using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Liskov_Substitution_Principle.TheBad
{
    /// <summary>
    /// Convertible roof inherits form PartsOfCar and OpenRoof here doesn't throw exception
    /// </summary>
    public class ConvertibleRoof : PartsOfCar
    {
        
        public int RoofLenthExposed { set; get; }


        /// <summary>
        /// call to the base method t.e call to NotifyThatPartIsProduced from PartsOfCar
        /// </summary>
        public override void NotifyThatPartIsProduced()
        {
            base.NotifyThatPartIsProduced();
        }

        /// <summary>
        /// call to the base method t.e call to OpenRoof from PartsOfCar
        /// </summary>
        public override void OpenRoof()
        {
            base.OpenRoof();
        }
    }
}
