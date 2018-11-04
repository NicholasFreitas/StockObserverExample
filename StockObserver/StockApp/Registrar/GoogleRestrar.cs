using System;
using System.Collections.Generic;

namespace StockApplication
{
    class GoogleRestrar : IStockRegistrar
    {
        List<IStockSubscriber> GoogleStockSubscribers = new List<IStockSubscriber>();
        List<IStock> GoogleStocks = new List<IStock>();

        public GoogleRestrar()
        {
            GoogleStocks.Add(new Stock("Google","GOOGLE",1071.41f));
        }

        public void NotifySubscriber()
        {
            GetStocksFromAPI();

            if (GoogleStockSubscribers.Count != 0)
            {
                foreach (var Sub in GoogleStockSubscribers)
                {
                    Sub.Update(GoogleStocks);
                }
            }    
        }

        public void RegisterSubscriber(IStockSubscriber sub)
        {
            GoogleStockSubscribers.Add(sub);
        }

        public void RemoveSubscriber(IStockSubscriber sub)
        {
            if (GoogleStockSubscribers.Count == 0)
                throw new Exception("There are no Subscribers");
            
            Type remove = sub.GetType();
            int indexOfStockToRemove = 0;

            foreach (var Sub in GoogleStockSubscribers)
            {

                if (Sub.GetType() == remove)
                {
                   indexOfStockToRemove = GoogleStockSubscribers.IndexOf(Sub);
                }        
                
            }

            GoogleStockSubscribers.RemoveAt(indexOfStockToRemove);            
        }

        public void GetStocksFromAPI()
        {
            float oldStockValue = 0.0f;
            float newStockValue = 0.0f;

            /*Here the API would fill or update it's stock data from an API*/
            foreach (var Stock in GoogleStocks)
            {
                oldStockValue = Stock.GetStockValue();

                newStockValue = (float)(oldStockValue * 1.1);

                Stock.UpdateStockValue(newStockValue);
                
            }            
        }
    }
}
