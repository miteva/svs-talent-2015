using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test
{
    public interface ICar
    {

        void Execute(int delay);
    }

    public interface IKillerCar
    {
        /// <summary>
        /// Execute is different from Execute from ICar
        /// </summary>
        /// <param name="delay"></param>
        void Execute(int delay);
    }

    
}
