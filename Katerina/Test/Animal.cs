using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test
{
  public  class Animal : IAnimal, IFish
    {
        List<Person> p = new List<Person>();
        

        private static Animal sAnimal;
        public static Animal Instance {
            get
            {
                return sAnimal;
            }
            
        }
        /// <summary>
        /// static constructor for Animal
        /// </summary>
        static Animal() {

            sAnimal = new Animal();
            //sAnimal = new Animal();
        }

        private Animal() { }

        //public static Animal getAnimal() {

        //    return sAnimal;
        //}


        void IAnimal.Breth() {
        

            Console.WriteLine("This animal breath with nose");
        }

        void IFish.Breth() {
            Console.WriteLine("This  animal doesn't breath with nose");
        }

    }
}
