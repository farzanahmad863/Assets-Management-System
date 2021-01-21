using System;
using System.Collections.Generic;
using System.Text;

namespace Assets_Management_System
{
    class LaptopComputer: Asset
    {
        public int LaptopComputerId { get; set; }
        public LaptopComputer()
        {

        }
       public LaptopComputer(DateTime purchaseDate,int price, string modelName,Office office, string currency, double exchangeRate)
        {
                PurchaseDate = purchaseDate;
                Price = price;
                ModelName = modelName;
                Currency = currency;
                ExchangeRate = exchangeRate;
                Office = office;
            
        }
    }
}
