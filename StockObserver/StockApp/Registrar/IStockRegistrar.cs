﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StockApplication
{
    interface IStockRegistrar
    {
        void RegisterSubscriber(IStockSubscriber obs);
        void RemoveSubscriber(IStockSubscriber obs);
        void NotifySubscriber();

    }
}
