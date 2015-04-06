using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test
{
    class Program
    {

        static void Main(string[] args)
        {
            Animal aa = Animal.Instance;
            //Animal a = Animal.getAnimal();
            //IFish animalFish = a;
            //animalFish.Breth();
            //IAnimal animal = a;
            //animal.Breth();

            IFish animalFish = aa;
            animalFish.Breth();
            IAnimal animal = aa;
            animal.Breth();
            Console.ReadLine();


        }
    }
}





















//    Racer r = Racer.GetRacer();



//    Car thexperimentalCar = new Car();

//    ICar theInterfaceCar = thexperimentalCar;

//    thexperimentalCar.OnCarstarted += HandleCarStart;
//    thexperimentalCar.OnCarstarted += HandleCarStartTwo;
//    for (int i = 0; i < 10; i++)
//    {

//        thexperimentalCar.StartTheCar(10);

//    }

//    Console.ReadLine();

//}

//private static void HandleCarStart(DateTime timeStart, int numbers)
//{
//    Console.WriteLine("This car has been started again on {0},this car is started {1} times", timeStart, numbers);
//}

//private static void HandleCarStartTwo(DateTime timeStart, int numbers)
//{
//    Console.WriteLine("This car has been started again on {0},this car is started {1} times", timeStart, numbers);
//}
