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
        ILogger logger = Logger.GetLogger();
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
                ILogger loggerToLog= logger.CreateLogger(choose);
                logger.Log("CarLocked");
                

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
                ILogger loggerToLog = logger.CreateLogger(choose);
                logger.Log("CarUnlocked");
              

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
            ILogger loggerToLog = logger.CreateLogger(choose);
            logger.Log("CarSold");
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

