using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Liskov_Substitution_Principle.TheBad
{
   public class PartsOfCar
    {
       
        ConvertibleRoof ConvertibleRoof {set; get;}
        Roof Roof { set; get; }

       
       /// <summary>
       /// method that open the convertible roof
       /// </summary>
       public virtual void OpenRoof() 
       {
           while (ConvertibleRoof.RoofLenthExposed > 0)
                   ConvertibleRoof.RoofLenthExposed--;
        }

       /// <summary>
       /// method that notify us when part is produced
       /// </summary>
       public virtual void NotifyThatPartIsProduced() 
       {
           Console.WriteLine("This part has been produced");
       }

       /// <summary>
       /// method that calls the OpenRoof method from all the instance that inherit from
       /// PartsOfCar, this will throw en exception because only convertible roofs can be open
       /// </summary>
       public void PaintParts() 
       {
           List<PartsOfCar> parts = new List<PartsOfCar>();
           ConvertibleRoof = new ConvertibleRoof();
           Roof = new Roof();
           parts.Add(ConvertibleRoof);
           parts.Add(Roof);

           foreach (PartsOfCar p in parts) 
           {
               p.OpenRoof();
           }
       }
    }

  
}
