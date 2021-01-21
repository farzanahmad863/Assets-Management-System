using System;
using System.Collections.Generic;
using System.Text;

namespace Assets_Management_System
{
    class MobilePhone: Asset
    {
        public MobilePhone(DateTime purchaseDate, int price, string modelName, Office office, string currency, double exchangeRate)
        {
            PurchaseDate = purchaseDate;
            Price = price;
            ModelName = modelName;
            Currency = currency;
            ExchangeRate = exchangeRate;
        }
    }
}
