using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Open_CLosed_Principle.TheGood
{
    /// <summary>
    /// this class inherits from student because Doctor is type of student
    /// </summary>
    class Doctor : Student
    {
        /// <summary>
        /// method that override the base method GetTitle and returns previous titles for doctor
        /// </summary>
        /// <returns></returns>
        public virtual int GetTitles()
        {
            return base.GetTitles() + 2;
        }
 
    }

   
}
