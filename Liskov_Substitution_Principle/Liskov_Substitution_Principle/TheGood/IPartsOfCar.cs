using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Liskov_Substitution_Principle.TheGood
{
    /// <summary>
    /// Interface for PartsOfCar without OpenRoof method
    /// because that method is only for instances from ConvertibleRoof
    /// </summary>
    public interface IPartsOfCar
    {
        void NotifyThatPartIsProduced();
    }
}
