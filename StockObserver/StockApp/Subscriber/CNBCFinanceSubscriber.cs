using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StockApplication
{
    class CNBCFinanceSubscriber : IStockSubscriber
    {
        List<IStock> SubscribedStocks = new List<IStock>();

        public void Update(List<IStock> registrarStock)
        {

            SubscribedStocks = registrarStock;
        }

        public void StockAlertUpdate()
        {
            foreach (var Stock in SubscribedStocks)
            {
                Console.WriteLine("Value: " + Stock.GetStockValue());
            }
            Console.WriteLine("====================================");
        }
    }
}
