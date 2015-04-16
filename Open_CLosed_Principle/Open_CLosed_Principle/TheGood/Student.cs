using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Open_CLosed_Principle.TheGood
{

    /// <summary>
    /// class that implement the interface IStudent
    /// </summary>
    public class Student : IStudent
    {
        /// <summary>
        /// method that return previous titles
        /// </summary>
        /// <returns></returns>
        public virtual int GetTitles()
        {
            return 0;
          }

    }
}

