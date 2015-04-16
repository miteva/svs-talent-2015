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
    public class Master : Student
    {
        /// <summary>
        /// method that override the base method GetTitle and returns previous titles for master
        /// </summary>
        /// <returns></returns>
        public override int GetTitles()
        {
            return base.GetTitles() + 1;
        }
    }
}
