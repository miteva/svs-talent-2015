using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test
{
    public class Fruit : Text

    {
        
        private int _num1;
        private int _num2;
        private int _num3;

        /// <summary>
        /// Set and Get methods for the filed _num1
        /// </summary>
        /// 

       
        public int Num1
        {
            get
            {
                return _num1;
            }

            set
            {
                _num1 = value;
            }
        }

        /// <summary>
        /// Set and Get methods for the filed _num2
        /// </summary>
        protected int Num2
        {
            get
            {
                if (_num2 > 2)
                    return _num2;
                else return 0;
            }

            private set
            {
                _num2 = value;
            }
        }

        /// <summary>
        /// Set and Get methods for the filed _num3
        /// </summary>
        private int Num3
        {
            get
            {
                return _num3;
            }

            set
            {
                _num3 = value;
            }
        }


        public int Test1() {
            return 1;
        }
        public int Test1(int i=0)
        {
            return 2;
        }


        public string vitamins { get; set; }
        public string Color { get; set; }

        public bool hasVitamin(string vit) {

            if (vit != null)
            {

                return true;
            }
            else return false;

        }

        public virtual string Grow() {

            return grows = "";
        }

        public virtual void Does(bool check) {
            if (check)
            {
                does = "does have vitamins";
            }
            else {
                does = "doesn't have vitamins";
            }
        }

        //static void Main(string[] args)
        //{

        //    Fruit p = new Fruit();
        //    p.Color = "red";
        //    p.vitamins = "A";
        //    Console.Write(p.Color+  " "+ p.vitamins+  " "+p.Test1(1));
        //    Racer r = Racer.GetRacer();
          

        //    //ICar.thexperimentalCar.OnCarstarted += HandleCarStart;
        //    Car thexperimentalCar = new Car();
            
        //    ICar theInterfaceCar = thexperimentalCar;
            
        //    thexperimentalCar.OnCarstarted += HandleCarStart;
        //    thexperimentalCar.OnCarstarted += HandleCarStartTwo;
        //    for (int i = 0; i < 10; i++) {

        //        thexperimentalCar.StartTheCar(10);
               
        //    }

        //    Console.ReadLine();

        //}

       
    }

    

    
}

