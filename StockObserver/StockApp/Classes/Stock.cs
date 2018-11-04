using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StockApplication
{
    class Stock : IStock
    {
        string Name;
        string Code;
        float CurrentValue { get; set; } = 0.0f;

        public Stock(string name, string code, float value)
        {
            Name = name;
            Code = code;
            CurrentValue = value;
        }

        public void UpdateStockValue(float newStockPrice)
        {
            CurrentValue = newStockPrice;
        }

        public float GetStockValue()
        {
            return CurrentValue;
        }
    }
}
