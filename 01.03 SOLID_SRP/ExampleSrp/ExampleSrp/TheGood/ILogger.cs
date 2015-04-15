﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExampleSrp.TheGood
{
    public interface ILogger
    {
        IComputerLogger createComputerLogger();
        ITabletLogger createTabletLogger();
        IPhoneLogger createPhoneLogger();

    }
}
