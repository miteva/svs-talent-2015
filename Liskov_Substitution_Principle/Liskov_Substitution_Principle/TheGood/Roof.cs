using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Liskov_Substitution_Principle.TheGood
{
    /// <summary>
    /// this class inherits from PartsOfCar and the problem with the OpenRoof method
    /// no longer exist
    /// </summary>
    public class Roof : PartsOfCar
    {
        /// <summary>
        /// the base method is ovveriden and this method tells us that exactly the roof has been produced
        /// </summary>
        public override void NotifyThatPartIsProduced()
        {
            Console.WriteLine("The roof has been produced");
        }
    }
}
