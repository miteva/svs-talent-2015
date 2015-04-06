using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test
{
    /// <summary>
    /// Example for singleton pattern
    /// </summary>
    public class Racer : Person
    {

        private static Racer sRacer;
        static Racer() {

            sRacer = new Racer();
        }
        private Racer() { }
        public static Racer GetRacer() {

            ///<summary>
            /// Wihout static Racer() we should use the commented lines
            /// </summary>
            //if (sRacer == null)
            //    sRacer = new Racer();
            return sRacer;
        }
        /// <summary>
        /// The track where the racer drive
        /// </summary>
      public  string track { get; set; }

       
        

    }
}
