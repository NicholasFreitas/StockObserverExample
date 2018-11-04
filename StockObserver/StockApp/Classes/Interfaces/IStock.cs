using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StockApplication
{
    interface IStock
    {
        void UpdateStockValue(float newStockValue);

        float GetStockValue();

    }
}
