using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Liskov_Substitution_Principle.TheGood
{
    /// <summary>
    /// ConvertibleRoof now implements the two interfaces IConvertibleRoof and IPartsOfCar
    /// and here OpenRoof method is implemented and it won't throw an exception
    /// </summary>
    public class ConvertibleRoof : IConvertibleRoof,IPartsOfCar
    {
        public int RoofLenthExposed { set; get; }

        /// <summary>
        /// if the length that is exposed is 0 then the roof is closed
        /// </summary>
        public void OpenRoof()
        {
            while (RoofLenthExposed > 0)
                RoofLenthExposed--;
        }

        /// <summary>
        /// the base method is ovveriden and this method tells us that exactly the convertible roof has been produced
        /// </summary>
        public virtual void NotifyThatPartIsProduced()
        {
            Console.WriteLine("Convertible roof has been produced");
        }
    }
}
