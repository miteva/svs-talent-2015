using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Open_CLosed_Principle.TheBad
{
    /// <summary>
    /// class that have different types of student
    /// the problem here is if we add anoter type of student
    /// we have to have another case for chekcing and we have to change this class
    /// </summary>
    public class Student : IStudent
    {
        public StudentType TypeOfStudent { set; get; }

        /// <summary>
        /// method that returns previous title of a student depending of it's type
        /// </summary>
        /// <returns></returns>
      public int GetTitles()
        {
            if (TypeOfStudent == StudentType.Student)
                return 1;
            if (TypeOfStudent == StudentType.Master)
                return 2;
            else
                return 3;
       }


    }
    /// <summary>
    /// types of student
    /// </summary>
    public enum StudentType
    {
        Student,
        Master,
        Doctor
    }

}