using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Liskov_Substitution_Principle.TheGood
{
    /// <summary>
    /// this class implement the IPartsOfCar interface
    /// </summary>
    public class PartsOfCar : IPartsOfCar
    {
        ConvertibleRoof ConvertibleRoof { set; get; }
        Roof Roof { set; get; }

        /// <summary>
        /// method that notify us when part is created
        /// </summary>
        public virtual void NotifyThatPartIsProduced()
        {
            Console.WriteLine("This part has been produced");
        }

        /// <summary>
        /// if we uncomment the commented lines we will have an error becausse 
        /// ConvertibleRoof doesn't inherit from PartsOfCar and can't be added in the List of PartsOfCar.
        /// Also we cann't call OpenRoof for the instace Roof because Roof doen't have that method now 
        /// </summary>
        public void PaintParts()
        {
            List<PartsOfCar> parts = new List<PartsOfCar>();
            ConvertibleRoof = new ConvertibleRoof();
            Roof = new Roof();
           //parts.Add(ConvertibleRoof);
            parts.Add(Roof);

            foreach (PartsOfCar p in parts)
            {
               // p.OpenRoof();
            }
        }
       
    }
}
