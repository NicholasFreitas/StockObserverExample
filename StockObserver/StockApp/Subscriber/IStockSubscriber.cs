using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StockApplication
{
    interface IStockSubscriber
    {
        void Update(List<IStock> stocks);

        void StockAlertUpdate();
    }
}
