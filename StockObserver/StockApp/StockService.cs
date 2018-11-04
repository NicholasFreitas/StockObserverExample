using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StockApplication
{
    class StockService
    {
        List<IStockRegistrar> RegisteredRegistrars = new List<IStockRegistrar>();

        public StockService(IStockRegistrar registerStockerRunner)
        {
            RegisteredRegistrars.Add(registerStockerRunner);
        }

        public async void StockUpdater(IStockSubscriber sub)
        {
            DateTime CurrentDateTimePlusFive = DateTime.Now.AddMinutes(5);

            while (CurrentDateTimePlusFive > DateTime.Now)
            {
                foreach (var Registrar in RegisteredRegistrars)
                {
                    Registrar.NotifySubscriber();
                }

                sub.StockAlertUpdate();
                System.Threading.Thread.Sleep(5000);
            } 
        }


    }
}
