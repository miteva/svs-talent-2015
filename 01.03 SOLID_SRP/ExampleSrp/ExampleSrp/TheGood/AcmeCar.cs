using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ExampleSrp.TheGood
{
   public class AcmeCar
    {
        public LockState IsLocked { get; private set; }
        IStateChangeLogger device = StateChangeLogger.GetDevice();
        IExceptionLogger exceptionLogger = ExceptionLogger.GetExceptionLogger();
        int choose = 0;
        
       

        public void Lock()
        {
            try
            {
                //
                this.IsLocked = LockState.Locked;


                //log state change in computer
                ChooseDeviceForLogging();
                device.LogToAppropriateDevice(choose,"CarLocked");

                //ClientLogger.ComputerLogChangeState("CarLocked");
               

            }
            catch (Exception)
            {
                   
                    exceptionLogger.logException("There was an error locking the car!");
               
            }
        }


        public void Unlock()
        {
            try
            {
                //
                this.IsLocked = LockState.Unlocked;

                ChooseDeviceForLogging();
                IStateChangeLogger logger = device.CreateLogger(choose);
                logger.LogStateChange("CarUnlocked!");
               // device.LogToAppropriateDevice(choose, "CarUnlocked");

                //ClientLogger.ComputerLogChangeState("CarUnlock");

                //

            }
            catch (Exception)
            {
                
                exceptionLogger.logException("There was an error locking the car!");
            }

        }

        public void CarSold()
        {
            ChooseDeviceForLogging();
            device.LogToAppropriateDevice(choose, "Car is sold");
        }

        public void ChooseDeviceForLogging()
        {
           
            Console.WriteLine("Choose 1 for computer, choose 2 for tablet, chose 3 for phone");
            int.TryParse(Console.ReadLine(), out choose);

        }

       

    }

    public enum LockState
    {
        Error = 0,
        Locked = 1,
        Unlocked = 2,

    }

}

