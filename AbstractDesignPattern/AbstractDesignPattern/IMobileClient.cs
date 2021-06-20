﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractDesignPattern
{
    interface IMobileClient
    {
        ISmartPhone GetSmartPhone();
        INormalPhone GetNormalPhone();
    }
}
