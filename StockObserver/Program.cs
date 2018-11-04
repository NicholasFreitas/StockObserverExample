using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StockApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            var googleRegistrar = new GoogleRestrar();
            var cnbcFinance = new CNBCFinanceSubscriber();

            googleRegistrar.RegisterSubscriber(cnbcFinance);

            var stockService = new StockService(googleRegistrar);

            stockService.StockUpdater(cnbcFinance);
        }

     }
}
