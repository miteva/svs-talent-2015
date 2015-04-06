using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test
{
    /// <summary>
    /// Delegate that will be called on each car start
    /// </summary>
    /// <param name="timeStarted"></param>
    /// <param name="numbers"></param>
    public delegate void CarStarted(DateTime timeStarted, int numbers);



    public class Car : ICar, IKillerCar
    {

        public int TotalNumberOFStarts { get; private set; }

        public event CarStarted OnCarstarted;

        public void StartTheCar(int delay)
        {

            //TODo startengine
            //TODO lock the car
            this.TotalNumberOFStarts++;
            //raise event

            this.OnCarstarted(DateTime.Now, this.TotalNumberOFStarts);

        }

         void ICar.Execute(int delay) {

            Console.WriteLine("Smth without kill");
            }

         void IKillerCar.Execute(int delay)
        {

            Console.WriteLine("Smth with kill");
        }


    }
}
